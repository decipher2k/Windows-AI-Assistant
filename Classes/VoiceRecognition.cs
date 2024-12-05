using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Classes
{
	public class VoiceRecognition
	{
		public String recognizeAzure(String subscriptionKey, String region, String lang="en-US")
		{
			try
			{
				SpeechConfig speechConfig = SpeechConfig.FromSubscription(subscriptionKey, region);
				SpeechRecognitionResult result;
				using (SpeechRecognizer recognizer = new(speechConfig, AutoDetectSourceLanguageConfig.FromLanguages(new String[] { lang })))
				{
					result = recognizer.RecognizeOnceAsync().Result;
					if (result.Reason == ResultReason.RecognizedSpeech)
						return result.Text;
				}
			}
			catch (Exception ex) { }
			return "";
		}
	}
}
