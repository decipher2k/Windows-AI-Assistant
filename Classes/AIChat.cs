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
		public String sendToOllama(string text, String systemPrompt = "you are a helpful assistant.", String model = "llama3")
		{
			String ret = "";
			try
			{
                AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
                return Task.Run(async Task<String> () => {

					var uri = new Uri("http://localhost:11434");
					var ollama = new OllamaApiClient(uri);


					var mdl = ollama.ListLocalModelsAsync().Result;
					if (ollama.ListLocalModelsAsync().Result.Where(a => a.Name.Contains(model)).Count() == 0)
					{
						new TextToSpeech().speakWindows("Pulling AI model. This may take a while.");

						await foreach (var status in ollama.PullModelAsync(model)) ;
						new TextToSpeech().speakWindows("Finished pulling AI model.");
						return "";
					}
                    AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
                    var chat = new Chat(ollama, systemPrompt);
					ollama.SelectedModel = model;
                    ret = chat.SendAsync(text).StreamToEndAsync().Result;
                    AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
                    return ret.Replace("*","");
				}).Result;
			}
			catch (Exception) { new Classes.TextToSpeech().speakWindows("Error querying Ollama."); }
            AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
            return ret.Replace("*","");
		}

		public String sendToChatGPT(string text, String apiKey)
		{
			String ret = "";
			try
			{
                AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
                ChatClient client = new ChatClient("gpt-4o", new System.ClientModel.ApiKeyCredential(apiKey));

				ChatCompletion completion = client.CompleteChat(text);
				
				foreach (ChatMessageContentPart contentPart in completion.Content)
					ret = ret + contentPart.Text + " ";
			}
			catch (Exception) { new Classes.TextToSpeech().speakWindows("Error querying ChatGPT."); }
            AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
            return ret.Replace("*","");
		}

        public String sendToGroq(string text, String apiKey, String model)
        {
            String ret = "";
            try
            {
                AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
                ChatClient client = new ChatClient(model, new System.ClientModel.ApiKeyCredential(apiKey), new OpenAI.OpenAIClientOptions() { Endpoint = new Uri("https://api.groq.com/openai/v1") });

                ChatCompletion completion = client.CompleteChat(text);

                foreach (ChatMessageContentPart contentPart in completion.Content)
                    ret = ret + contentPart.Text + " ";
            }
            catch (Exception) { new Classes.TextToSpeech().speakWindows("Error querying Groq."); }
            AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
            return ret.Replace("*", "");
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
                AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
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
                AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
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
