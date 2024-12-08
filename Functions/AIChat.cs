﻿using OllamaSharp;
using OllamaSharp.Models.Chat;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Functions
{
	public static class AIChat
	{
		public static String sendToOllama(string text, String systemPrompt, String model, List<Tuple<String, String>> chatHistory)
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
						TextToSpeech.speakWindows("Pulling AI model. This may take a while.");

						await foreach (var status in ollama.PullModelAsync(model)) ;
						TextToSpeech.speakWindows("Finished pulling AI model.");
						return "";
					}
                    AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
                    var chat = new Chat(ollama, systemPrompt);

                    List<OllamaSharp.Models.Chat.Message> messageHistory = new List<OllamaSharp.Models.Chat.Message>();
                    foreach (Tuple<String, String> chatHistoryItem in chatHistory)
					{
						OllamaSharp.Models.Chat.Message messageUser = new OllamaSharp.Models.Chat.Message();
						messageUser.Role = ChatRole.User;
						messageUser.Content = chatHistoryItem.Item1;
						messageHistory.Add(messageUser);

                        OllamaSharp.Models.Chat.Message messageAssistant = new OllamaSharp.Models.Chat.Message();
                        messageAssistant.Role = ChatRole.Assistant;
                        messageAssistant.Content = chatHistoryItem.Item2;
                        messageHistory.Add(messageAssistant);
                    }

					chat.Messages = messageHistory;

					ollama.SelectedModel = model;
                    ret = chat.SendAsync(text).StreamToEndAsync().Result;
                    AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
                    return ret.Replace("*","");
				}).Result;
			}
			catch (Exception) 
			{ 
				Functions.TextToSpeech.speakWindows("Error querying Ollama."); 
			}

            AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
            return ret.Replace("*","");
		}

		public static String sendToChatGPT(string text, String apiKey, List<Tuple<String, String>> chatHistory)
		{
			String ret = "";
			try
			{
                AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
                ChatClient client = new ChatClient("gpt-4o", new System.ClientModel.ApiKeyCredential(apiKey));
                List<ChatMessage> chatMessages = new List<ChatMessage>();
                foreach (Tuple<String, String> chatHistoryMessage in chatHistory)
                {
                    chatMessages.Add(ChatMessage.CreateUserMessage(chatHistoryMessage.Item1));
                    chatMessages.Add(ChatMessage.CreateAssistantMessage(chatHistoryMessage.Item2));
                }

                ChatMessage userMessageObj = ChatMessage.CreateUserMessage(text);
                chatMessages.Add(userMessageObj);
                ChatCompletion completion = client.CompleteChat(chatMessages);

                foreach (ChatMessageContentPart contentPart in completion.Content)
					ret = ret + contentPart.Text + " ";
			}
			catch (Exception) 
			{ 
				Functions.TextToSpeech.speakWindows("Error querying ChatGPT."); 
			}
            AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
            return ret.Replace("*","");
		}

        public static String sendToGroq(string text, String apiKey, String model, List<Tuple<String, String>> chatHistory)
        {
            String ret = "";
            try
            {
                AppContext.trayIcon.Icon = new System.Drawing.Icon("robot_thinking.ico");
                ChatClient client = new ChatClient(model, new System.ClientModel.ApiKeyCredential(apiKey), new OpenAI.OpenAIClientOptions() { Endpoint = new Uri("https://api.groq.com/openai/v1") });
				List<ChatMessage> chatMessages = new List<ChatMessage>();
				foreach (Tuple<String, String> chatHistoryMessage in chatHistory)
				{
					chatMessages.Add(ChatMessage.CreateUserMessage(chatHistoryMessage.Item1));
                    chatMessages.Add(ChatMessage.CreateAssistantMessage(chatHistoryMessage.Item2));
                }

				ChatMessage userMessageObj=ChatMessage.CreateUserMessage(text);
                chatMessages.Add(userMessageObj);
                ChatCompletion completion = client.CompleteChat(chatMessages);

                foreach (ChatMessageContentPart contentPart in completion.Content)
                    ret = ret + contentPart.Text + " ";
            }
            catch (Exception) 
			{ 
				Functions.TextToSpeech.speakWindows("Error querying Groq."); 
			}
            AppContext.trayIcon.Icon = new System.Drawing.Icon("robot.ico");
            return ret.Replace("*", "");
        }

        public static String sendToAWAN(String text, String apiKey, String chatHistory)
		{
			try
			{
				String template = File.ReadAllText(".\\awan.txt");
				template = template.Replace("TOKEN", chatHistory + " " + text);
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
			}
			catch(Exception)
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
					TextToSpeech.speakWindows("Error querying Awan.");
					return "";
				}
			}
		}
	}
}
