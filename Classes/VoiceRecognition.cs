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
		public String recognizeAzure(String subscriptionKey, String region, String lang="en-US")
		{
			String recognitionResult = "";

			try
			{
				if(Globals.settings.useWindowsSpeech)
				{
					try
					{
						System.Speech.Recognition.Choices choices = new System.Speech.Recognition.Choices();
						choices.Add(Globals.settings.keyword);
						GrammarBuilder gb = new GrammarBuilder();
						gb.Append(choices);

						SpeechRecognitionEngine recognizer =
							new SpeechRecognitionEngine(new System.Globalization.CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name));

						recognizer.LoadGrammar(new System.Speech.Recognition.Grammar(gb));
						recognizer.SetInputToDefaultAudioDevice();

						recognitionResult = recognizer.Recognize().Text;
						if (recognitionResult != Globals.settings.keyword)
							return "";
					}
					catch (Exception ex) { }
				}

				SpeechConfig speechConfig = SpeechConfig.FromSubscription(subscriptionKey, region);				
				SpeechRecognitionResult result;
				using (Microsoft.CognitiveServices.Speech.SpeechRecognizer recognizer = new(speechConfig, AutoDetectSourceLanguageConfig.FromLanguages(new String[] { lang })))
				{
					result = recognizer.RecognizeOnceAsync().Result;
					if (result.Reason == ResultReason.RecognizedSpeech)
						return result.Text;					
				}
			}
			catch (Exception ex) 
			{ 
				new Classes.TextToSpeech().speakWindows("Error recognizing speech."); 
			}

			return "";
		}
	}
}
