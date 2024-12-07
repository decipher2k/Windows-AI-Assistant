using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

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
