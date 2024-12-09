using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Windows_AI_Assistant.Functions;
using Windows_AI_Assistant.Data;

namespace Windows_AI_Assistant
{
	public class AppContext : ApplicationContext
	{
        MainForm mainForm = new MainForm();
        public static NotifyIcon trayIcon=new NotifyIcon();		
		public static bool running = true;
	
		public AppContext()
		{			
			var icon = new System.Drawing.Icon("robot.ico"); // Load an icon for the tray
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			contextMenuStrip.Items.Add("Open");
			contextMenuStrip.Items.Add("Exit");
			contextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
			trayIcon = new NotifyIcon()
			{
				Icon = icon,
				ContextMenuStrip = contextMenuStrip,
				Visible = true
			};
			trayIcon.DoubleClick += TrayIcon_DoubleClick;
			new System.Threading.Thread(mainThread).Start();
		}

		private void ContextMenuStrip_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem.Text=="Open")
			{
				if(!mainForm.Visible) 
					mainForm.ShowDialog();
			}
			if(e.ClickedItem.Text=="Exit")
			{
                running = false;
				Application.Exit();
			}
		}

		private void TrayIcon_DoubleClick(object? sender, EventArgs e)
		{
			if (!mainForm.Visible)
				mainForm.ShowDialog();
		}

		void Exit(object sender, EventArgs e)
		{
			trayIcon.Visible = false;
			Application.Exit();
		}

		bool EvaluateCommand(String text)
		{
			foreach (Data.Program program in Globals.settings.programs)
			{
				if (text.ToLower().Contains(program.Token.ToLower()) && program.Token!="")
				{
					try
					{
						Command.runProgram(program.Command, program.Parameter,text.Replace(program.Token,""));
					}
					catch (Exception ex) 
					{ 
						TextToSpeech.speakWindows("Error starting program."); 
					}
					return true;
				}
			}

			foreach (Data.Webhook webhook in Globals.settings.webhooks)
			{
				if (text.ToLower().Contains(webhook.Token.ToLower()) && webhook.Token!="")
				{
					try
					{
						Command.openURL(webhook.URl, webhook.Getpost.ToString(), webhook.Parameter, text.Replace(webhook.Token,""));
					}
					catch (Exception ex) 
					{ 
						TextToSpeech.speakWindows("Error calling webhook."); 
					}
					return true;
				}
			}

			foreach(Data.Plugin plugin in Globals.settings.plugins)
			{
				if(text.ToLower().Contains(plugin.Token.ToLower()) &&  plugin.Token!="")
				{
					String ret=Functions.Plugin.RunPlugin(text,plugin.DLL,plugin.Parameter);
					if (ret != null && ret != "")
					{
						switch (Globals.settings.textToSpeech)
						{
							case Data.Settings.TextToSpeech.Elevenlabs:
								{
									if (Globals.settings.elevenlabs.APIKey != "" && Globals.settings.elevenlabs.Voice != "")
										Functions.TextToSpeech.speakElevenlabs(ret, Globals.settings.elevenlabs.APIKey, Globals.settings.elevenlabs.Voice);
									break;
								}
							case Data.Settings.TextToSpeech.Windows:
								{
									Functions.TextToSpeech.speakWindows(ret);
									break;
								}
						}
						return true;
					}
					else
					{
						return true;
					}
				}
			}

			return false;
		}

		void mainThread()
		{
			while (running)
			{
				String text = "";
				String result = "";

                bool recognized = true;
                if (Globals.settings.useWindowsSpeech)
                {
                    String ret = new VoiceRecognition().recognizeWindows();
                    if (ret != Globals.settings.keyword)
                        recognized = false;
                }

				if (recognized)
				{
					switch (Globals.settings.speechToText)
					{
						case Data.Settings.SpeechToText.Azure:
							{
								if (Globals.settings.azure.APIKey != "" && Globals.settings.azure.Region != "" && Globals.settings.azure.Language != "")
									text = new Functions.VoiceRecognition().recognizeAzure(Globals.settings.azure.APIKey, Globals.settings.azure.Region, Globals.settings.azure.Language);
								break;
							}
						case Data.Settings.SpeechToText.Groq:
							{
								if (Globals.settings.groq.APIKey != "" && Globals.settings.groq.Language != "")
									text = new Functions.VoiceRecognition().recognizeGroq(Globals.settings.groq.APIKey, Globals.settings.groq.Language);
								break;
							}
					}

					text = text.Replace(".", "");
					text = text.Replace(",", "");
					text = text.Trim();



					if (text.StartsWith(Globals.settings.keyword) || (Globals.settings.useWindowsSpeech && recognized))
					{
						if (!Globals.settings.useWindowsSpeech)
							text = text.Substring(Globals.settings.keyword.Length);

						if (!EvaluateCommand(text))
						{

							switch (Globals.settings.aiChat)
							{
								case Data.Settings.AIChat.Ollama:
									{
										if (Globals.settings.ollama.SystemPrompt != "" && Globals.settings.ollama.Model != "")
											result = Functions.AIChat.sendToOllama(text, Globals.settings.ollama.SystemPrompt, Globals.settings.ollama.Model);
										break;
									}
								case Data.Settings.AIChat.ChatGPT:
									{
										if (Globals.settings.chatGPT.APIKey != "")
											result = Functions.AIChat.sendToChatGPT(text, Globals.settings.chatGPT.APIKey);
										break;
									}
								case Data.Settings.AIChat.Awan:
									if (Globals.settings.awan.APIKey != "")
										result = Functions.AIChat.sendToAWAN(text, Globals.settings.awan.APIKey);
									break;
								case Data.Settings.AIChat.Groq:
                                    if (Globals.settings.groq.APIKey != "")
                                        result = Functions.AIChat.sendToGroq(text, Globals.settings.groq.APIKey, Globals.settings.groq.LLMModel);
                                    break;
                            }

							switch (Globals.settings.textToSpeech)
							{
								case Data.Settings.TextToSpeech.Elevenlabs:
									{
										if (Globals.settings.elevenlabs.APIKey != "" && Globals.settings.elevenlabs.Voice != "")
											Functions.TextToSpeech.speakElevenlabs(result, Globals.settings.elevenlabs.APIKey, Globals.settings.elevenlabs.Voice);
										break;
									}
								case Data.Settings.TextToSpeech.Windows:
									{
										Functions.TextToSpeech.speakWindows(result);
										break;
									}
							}
						}
					}
				}                
            }
        }
	}
}
