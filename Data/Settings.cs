using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Data
{
	public class Settings
	{
		public Azure azure {  get; set; } = new Azure();
		public ChatGPT chatGPT { get; set; } = new ChatGPT();
		public Elevenlabs elevenlabs { get; set; } = new Elevenlabs();
		public Ollama ollama { get; set; } = new Ollama();
		public List<Program> programs { get; set; } = new List<Program>();
		public List<Webhook> webhooks { get; set; } = new List<Webhook>();
		public List <Plugin> plugins { get; set; } = new List<Plugin>();
		public SpeechToText speechToText { get; set; } = SpeechToText.Azure;
		public TextToSpeech textToSpeech { get; set; } = TextToSpeech.Windows;
		public AIChat aiChat { get; set; }=AIChat.Ollama;
		public Command command { get; set; } = Command.Program;
		public String keyword { get; set; } = "Computer";
		public Awan awan { get; set; } = new Awan();
		public WindowsSpeech windowsSpeech { get; set; }=new WindowsSpeech();

		public enum SpeechToText
		{
			Azure
		}

		public enum TextToSpeech
		{
			Elevenlabs,
			Windows
		}

		public enum AIChat
		{
			ChatGPT,
			Ollama,
			Awan
		}

		public enum Command
		{
			Program
		}
	}
}
