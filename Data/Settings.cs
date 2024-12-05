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
		public Program program { get; set; } = new Program();
		public SpeechToText speechToText { get; set; } = SpeechToText.Azure;
		public TextToSpeech textToSpeech { get; set; } = TextToSpeech.Windows;
		public AIChat aiChat { get; set; }=AIChat.Ollama;
		public Command command { get; set; } = Command.Program;
		public String keyword { get; set; } = "Computer";

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
			Claude
		}

		public enum Command
		{
			Program
		}
	}
}
