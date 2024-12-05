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


namespace Windows_AI_Assistant
{


	public partial class frmMain : Form
	{

		public frmMain()
		{
			InitializeComponent();
			tbKeyword.Text = Globals.settings.keyword;
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			cbVoiceRecognition.SelectedItem = Globals.settings.speechToText==Data.Settings.SpeechToText.Azure?"Microsoft Azure" : "";

			cbSpeechSynthesis.SelectedItem = Globals.settings.textToSpeech == Data.Settings.TextToSpeech.Elevenlabs ? "Elevenlabs" :
				(Globals.settings.textToSpeech == Data.Settings.TextToSpeech.Windows ? "Microsoft Windows Speech" : "");

			cbChatAI.SelectedItem = Globals.settings.aiChat == Data.Settings.AIChat.ChatGPT ? "ChatGPT" :
				 Globals.settings.aiChat == Data.Settings.AIChat.Ollama ? "Ollama":"";
		}

		public void cbVoiceRecognition_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbVoiceRecognition.SelectedItem.ToString() == "Microsoft Azure")
				Globals.settings.speechToText = Data.Settings.SpeechToText.Azure;
			Globals.Save();
		}

		public void cbChatAI_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbChatAI.SelectedItem.ToString()== "ChatGPT")
				Globals.settings.aiChat = Data.Settings.AIChat.ChatGPT;
			else if (cbChatAI.SelectedItem.ToString() == "Ollama")
				Globals.settings.aiChat = Data.Settings.AIChat.Ollama;
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
			if(cbVoiceRecognition.SelectedItem.ToString() == "Microsoft Azure")
			{
				Settings.AzureSettings azureSettings = new Settings.AzureSettings();
				azureSettings.ShowDialog();				
			}
			Globals.Save();
		}

		public void bnSettingsChatAI_Click(object sender, EventArgs e)
		{
			if (cbChatAI.SelectedItem.ToString() == "ChatGPT")
			{				
				Settings.ChatGPTSettings chatGPTSettings = new Settings.ChatGPTSettings();
				chatGPTSettings.ShowDialog();
			}
			else if(cbChatAI.SelectedItem.ToString() == "Ollama")
			{
				Settings.OllamaSettings ollamaSettings = new Settings.OllamaSettings();
				ollamaSettings.ShowDialog();
			}
			Globals.Save();
		}

		public void bnSettingsSpeechSynthesis_Click(object sender, EventArgs e)
		{
			if(cbSpeechSynthesis.SelectedItem.ToString() == "Elevenlabs")
			{
				Settings.ElevenlabsSettings elevenlabsSettings = new Settings.ElevenlabsSettings();
				elevenlabsSettings.ShowDialog();
			}
			Globals.Save();
		}

		public void tbKeyword_TextChanged(object sender, EventArgs e)
		{
			Globals.settings.keyword = tbKeyword.Text;
			Globals.Save();
		}



	}
}
