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
		public String LLMModel { get; set; } = "llama3-8b-8192";

    }
}
