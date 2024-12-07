using GroqApiLibrary;
using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Windows_AI_Assistant.Classes
{
	public class VoiceRecognition
	{
		public String recognizeAzure(String subscriptionKey, String region, String language="en-US")
		{
			String recognitionResult = "";

			try
			{
				if(Globals.settings.useWindowsSpeech)
				{
					while (!Pocketsphinx.keywordDetected)
						System.Threading.Thread.Sleep(100);
					String ret = recognize(subscriptionKey, region, language);
				}
				else
				{
					return recognize(subscriptionKey, region,language);
				}
				
			}
			catch (Exception ex) 
			{ 
				new Classes.TextToSpeech().speakWindows("Error recognizing speech."); 
			}

			return "";
		}

		public String recognizeGroq(String subscriptionKey, String language)
		{
			string ret = "";
			if (Globals.settings.useWindowsSpeech)
			{
				while (!Pocketsphinx.keywordDetected)
					System.Threading.Thread.Sleep(100);
				ret = doRecognizeGro(subscriptionKey, language);
			}
			else
			{
				ret= doRecognizeGro(subscriptionKey,language);
			}
			return ret;

		}

		private string doRecognizeGro(String subscriptionKey, String language)
		{
			var groqApi = new GroqApiClient(subscriptionKey);

			RecordAudio recordAudio = new RecordAudio();
			recordAudio.startRecording();
			while (recordAudio.finished == false)
			{
				System.Threading.Thread.Sleep(100);
			}

			MemoryStream memoryStream =  new MemoryStream(File.ReadAllBytes("output.wav"));

			using MultipartFormDataContent content = new MultipartFormDataContent();
			content.Add(new StreamContent(memoryStream), "file","output.wav");
			content.Add(new StringContent("whisper-large-v3-turbo"), "model");
			content.Add(new StringContent("en"), "language");
			content.Add(new StringContent("json"), "response_format");

			HttpClient httpClient=new HttpClient();
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", subscriptionKey);
			HttpResponseMessage obj = httpClient.PostAsync("https://api.groq.com/openai/v1/audio/transcriptions", content).Result;
					obj.EnsureSuccessStatusCode();
			JsonObject result = obj.Content.ReadFromJsonAsync<JsonObject>().Result;

			if (result != null)
				return result?["text"]?.ToString();
			else
				return "";
		}

		private String recognize(String subscriptionKey, String region, String language)
		{
			try
			{
				SpeechConfig speechConfig = SpeechConfig.FromSubscription(subscriptionKey, region);				
				SpeechRecognitionResult result;
				using (Microsoft.CognitiveServices.Speech.SpeechRecognizer recognizer = new(speechConfig, AutoDetectSourceLanguageConfig.FromLanguages(new String[] { language })))
				{
					recognizer.Canceled += Recognizer_Canceled;
					result = recognizer.RecognizeOnceAsync().Result;
					if (result.Reason == ResultReason.RecognizedSpeech)					
						return result.Text;								
				}
			}
			catch (Exception ex)
			{
				new TextToSpeech().speakWindows("Microsoft Azure error.");
			}
			return "";
		}

		private void Recognizer_Canceled(object? sender, SpeechRecognitionCanceledEventArgs e)
		{
			if(e.ErrorDetails.Contains("Quota"))
			{
				new TextToSpeech().speakWindows("Microsoft Azure quota exceeded.");
			}
		}

		private bool detectKeyword()
		{
			return false;
		}
	}
}
