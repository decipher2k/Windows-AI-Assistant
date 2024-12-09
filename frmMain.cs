using NAudio.Wave.Compression;
using NAudio.Wave;
using Microsoft.CognitiveServices.Speech;
using OpenAI.Chat;
using System.Speech.Synthesis;
using OllamaSharp;
using System.IO;
using NAudio.CoreAudioApi;
using static System.Net.Mime.MediaTypeNames;
using ElevenLabs;
using ElevenLabs.TextToSpeech;
using System.Diagnostics;
using Windows_AI_Assistant.Classes;
using NAudio.Utils;
using Windows_AI_Assistant.Data;
using Microsoft.Win32;


namespace Windows_AI_Assistant
{


	public partial class frmMain : Form
	{
		RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

		public frmMain()
		{
			InitializeComponent();
			tbKeyword.Text = Globals.settings.keyword;
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			cbVoiceRecognition.SelectedItem = Globals.settings.speechToText == Data.Settings.SpeechToText.Azure ? "Microsoft Azure" :
				 Globals.settings.speechToText == Data.Settings.SpeechToText.Groq ? "Groq" : "";

			cbSpeechSynthesis.SelectedItem = Globals.settings.textToSpeech == Data.Settings.TextToSpeech.Elevenlabs ? "Elevenlabs" :
				(Globals.settings.textToSpeech == Data.Settings.TextToSpeech.Windows ? "Microsoft Windows Speech" : "");

			cbChatAI.SelectedItem = Globals.settings.aiChat == Data.Settings.AIChat.ChatGPT ? "ChatGPT" :
				 Globals.settings.aiChat == Data.Settings.AIChat.Ollama ? "Ollama" : Globals.settings.aiChat == Data.Settings.AIChat.Awan ? "Awan" :
                  Globals.settings.aiChat == Data.Settings.AIChat.Groq ? "Groq" : "";

			cbKeywordDetection.Checked = Globals.settings.useWindowsSpeech;

			if (rkApp.GetValue("WAIA") == null)
			{
				cbAutostart.Checked = false;
			}
			else
			{
				cbAutostart.Checked = true;
			}
		}

		public void cbVoiceRecognition_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbVoiceRecognition.SelectedItem.ToString() == "Microsoft Azure")
				Globals.settings.speechToText = Data.Settings.SpeechToText.Azure;
			else if(cbVoiceRecognition.SelectedItem.ToString() == "Groq")
				Globals.settings.speechToText = Data.Settings.SpeechToText.Groq;
			Globals.Save();
		}

		public void cbChatAI_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbChatAI.SelectedItem.ToString() == "ChatGPT")
				Globals.settings.aiChat = Data.Settings.AIChat.ChatGPT;
			else if (cbChatAI.SelectedItem.ToString() == "Ollama")
				Globals.settings.aiChat = Data.Settings.AIChat.Ollama;
			else if (cbChatAI.SelectedItem.ToString() == "Awan")
				Globals.settings.aiChat = Data.Settings.AIChat.Awan;
            else if (cbChatAI.SelectedItem.ToString() == "Groq")
                Globals.settings.aiChat = Data.Settings.AIChat.Groq;

            Globals.Save();
		}

		public void cbSpeechSynthesis_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbSpeechSynthesis.SelectedItem.ToString() == "Elevenlabs")
				Globals.settings.textToSpeech = Data.Settings.TextToSpeech.Elevenlabs;
			else if (cbSpeechSynthesis.SelectedItem.ToString() == "Microsoft Windows Speech")
				Globals.settings.textToSpeech = Data.Settings.TextToSpeech.Windows;
			Globals.Save();
		}

		public void bnSettingsVoiceRecognition_Click(object sender, EventArgs e)
		{
			if (cbVoiceRecognition.SelectedItem.ToString() == "Microsoft Azure")
			{
				Settings.AzureSettings azureSettings = new Settings.AzureSettings();
				azureSettings.ShowDialog();
			}
			else if(cbVoiceRecognition.SelectedItem.ToString() == "Groq")
			{
				Settings.GroqSettings azureSettings = new Settings.GroqSettings();
				azureSettings.ShowDialog();
			}
			Globals.Save();
		}

		public void bnSettingsCommands_Click(object sender, EventArgs e)
		{
			Settings.CommandSettings commandSettings = new Settings.CommandSettings();
			commandSettings.ShowDialog();
			Globals.Save();
		}

		public void bnSettingsChatAI_Click(object sender, EventArgs e)
		{
			if (cbChatAI.SelectedItem.ToString() == "ChatGPT")
			{
				Settings.ChatGPTSettings chatGPTSettings = new Settings.ChatGPTSettings();
				chatGPTSettings.ShowDialog();
			}
			else if (cbChatAI.SelectedItem.ToString() == "Ollama")
			{
				Settings.OllamaSettings ollamaSettings = new Settings.OllamaSettings();
				ollamaSettings.ShowDialog();
			}
			else if (cbChatAI.SelectedItem.ToString() == "Awan")
			{
				Settings.AwanSettings awanSettings = new Settings.AwanSettings();
				awanSettings.ShowDialog();
			}
			else if(cbChatAI.SelectedItem.ToString()=="Groq")
			{
				Settings.GroqSettings groqSettings = new Settings.GroqSettings();
				groqSettings.ShowDialog();
			}
			Globals.Save();
		}

		public void bnSettingsSpeechSynthesis_Click(object sender, EventArgs e)
		{
			if (cbSpeechSynthesis.SelectedItem.ToString() == "Elevenlabs")
			{
				Settings.ElevenlabsSettings elevenlabsSettings = new Settings.ElevenlabsSettings();
				elevenlabsSettings.ShowDialog();
			}
			else if (cbSpeechSynthesis.SelectedItem.ToString() == "Microsoft Windows Speech")
			{
				Settings.WindowsSpeechSettings windowsSpeechSettings = new Settings.WindowsSpeechSettings();
				windowsSpeechSettings.ShowDialog();
			}
			Globals.Save();
		}

		public void tbKeyword_TextChanged(object sender, EventArgs e)
		{
			Globals.settings.keyword = tbKeyword.Text;
			Globals.Save();
		}

		private void cbKeywordDetection_CheckedChanged(object sender, EventArgs e)
		{
			Globals.settings.useWindowsSpeech = cbKeywordDetection.Checked;
			if(cbKeywordDetection.Checked)
			{
				tbKeyword.Text = "Windows";
				Globals.settings.keyword = "Windows";
				tbKeyword.Enabled = false;
			}
			else
			{
				tbKeyword.Enabled = true;
			}
			Globals.Save();
		}

		private void cbAutostart_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAutostart.Checked)
			{
				rkApp.SetValue("WAIA", System.Windows.Forms.Application.ExecutablePath);
			}
			else
			{
				rkApp.DeleteValue("WAIA", false);
			}
		}
	}
}
