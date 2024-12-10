using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Data
{
	public class Groq
	{
		public String APIKey { get; set; } = "";
		public String Language { get; set; } = "";
		public String LLMModel { get; set; } = "llama-3.1-70b-versatile";

    }
}
