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
					try
					{
						SpeechRecognitionEngine recognizer =
							new SpeechRecognitionEngine(new System.Globalization.CultureInfo(Globals.settings.azure.Language));

						recognizer.LoadGrammar(new DictationGrammar());
						recognizer.SetInputToDefaultAudioDevice();

						var recognized = recognizer.Recognize();
						if (recognized != null)
						{
							recognitionResult = recognized.Text;
							if (recognitionResult != Globals.settings.keyword)
							{
								String ret = recognize(subscriptionKey, region, language);
							}
							else
							{
								return "";
							}
						}
						else
						{
							return "";
						}
						
					}
					catch (Exception ex) { }
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
			SpeechConfig speechConfig = SpeechConfig.FromSubscription(subscriptionKey, region);
			SpeechRecognitionResult result;
			using (Microsoft.CognitiveServices.Speech.SpeechRecognizer recognizer = new(speechConfig, AutoDetectSourceLanguageConfig.FromLanguages(new String[] { language })))
			{
				result = recognizer.RecognizeOnceAsync().Result;
				if (result.Reason == ResultReason.RecognizedSpeech)
					return result.Text;
			}
			return "";
		}
	}
}
