using OllamaSharp;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Classes
{
	public class AIChat
	{
		public String sendToOllama(string text, String systemPrompt = "you are a helpful assistant.", String model= "llama3")
		{
			String ret = "";
			try
			{
				var uri = new Uri("http://localhost:11434");
				var ollama = new OllamaApiClient(uri);

				if (ollama.ListLocalModelsAsync().Result.Where(a => a.Name.Contains(model)).Count() == 0)
				{
					new TextToSpeech().speakWindows("Pulling AI model.");
					foreach (var m in ollama.PullModelAsync(model).ToBlockingEnumerable()) ;
					new TextToSpeech().speakWindows("Finished pulling AI model.");
					return "";
				}

				var chat = new Chat(ollama, systemPrompt);
				ollama.SelectedModel = model;

				ret = chat.SendAsync(text).StreamToEndAsync().Result;
			}
			catch (Exception ex) { new Classes.TextToSpeech().speakWindows("Error querying Ollama."); }
			return ret;
		}

		public String sendToChatGPT(string text, String apiKey)
		{
			String ret = "";
			try
			{
				ChatClient client = new ChatClient("gpt-4o", apiKey);

				ChatCompletion completion = client.CompleteChat(text);
				
				foreach (ChatMessageContentPart contentPart in completion.Content)
					ret = ret + contentPart.Text + " ";
			}
			catch (Exception ex) { new Classes.TextToSpeech().speakWindows("Error querying ChatGPT."); }
			return ret;
		}
	}
}
