using OllamaSharp;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

				
				var mdl = ollama.ListLocalModelsAsync().Result;
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
			catch (Exception) { new Classes.TextToSpeech().speakWindows("Error querying Ollama."); }
			return ret.Replace("*","");
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
			catch (Exception) { new Classes.TextToSpeech().speakWindows("Error querying ChatGPT."); }
			return ret.Replace("*","");
		}

		public String sendToAWAN(String text, String apiKey)
		{
			try
			{
				String template = File.ReadAllText(".\\awan.txt");
				template = template.Replace("TOKEN", text);
				template = template.Replace("MODEL", Globals.settings.awan.Model);
				HttpClient client = new HttpClient();
				var content = new StringContent(template);//FormUrlEncodedContent(values);

				using var request = new HttpRequestMessage(HttpMethod.Post, "https://api.awanllm.com/v1/chat/completions");
				request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
				client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header		

				request.Content = content;
				request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
				var response = client.SendAsync(request).Result;
				response.EnsureSuccessStatusCode();

				String ret = response.Content.ReadAsStringAsync().Result;

				var responseString = response.Content.ReadAsStringAsync().Result;
				String answer = responseString.Substring(responseString.IndexOf("\"content\":\"") + "\"content\":\"".Length);
				answer = answer.Replace("\\\"", "");
				answer = answer.Substring(0, answer.IndexOf("\""));
				return answer.Replace("\\n", "").Replace("*", "");
			}catch(Exception)
			{
				try
				{
					String template = File.ReadAllText(".\\awan.txt");
					template = template.Replace("TOKEN", text);
					template = template.Replace("MODEL", "Meta-Llama-3-8B-Instruct");
					HttpClient client = new HttpClient();
					var content = new StringContent(template);//FormUrlEncodedContent(values);

					using var request = new HttpRequestMessage(HttpMethod.Post, "https://api.awanllm.com/v1/chat/completions");
					request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
					client.DefaultRequestHeaders
					  .Accept
					  .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header		

					request.Content = content;
					request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
					var response = client.SendAsync(request).Result;
					response.EnsureSuccessStatusCode();

					String ret = response.Content.ReadAsStringAsync().Result;

					var responseString = response.Content.ReadAsStringAsync().Result;
					String answer = responseString.Substring(responseString.IndexOf("\"content\":\"") + "\"content\":\"".Length);
					answer = answer.Replace("\\\"", "");
					answer = answer.Substring(0, answer.IndexOf("\""));
					return answer.Replace("\\n", "").Replace("*", "");
				}
				catch (Exception)
				{
					new TextToSpeech().speakWindows("Error querying Awan.");
					return "";
				}
			}
		}
	}
}
