using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Data
{
	public class Ollama
	{
		public String Model { get; set; } = "llama3.2";
		public String SystemPrompt { get; set; } = "You are a helpful AI assistant.";
	}
}
