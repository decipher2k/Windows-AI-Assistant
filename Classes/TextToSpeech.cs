using ElevenLabs.TextToSpeech;
using ElevenLabs;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI;

namespace Windows_AI_Assistant.Classes
{
	public static class TextToSpeech
	{
		public static void speakElevenlabs(String text, String key, String sVoice)
		{
			try
			{
				var api = new ElevenLabsClient(key);
				var voice = (api.VoicesEndpoint.GetAllVoicesAsync().Result).Where(a => a.Name.Contains(sVoice)).First();
				var request = new TextToSpeechRequest(voice, text, null, null, ElevenLabs.OutputFormat.PCM_16000);
				var voiceClip = api.TextToSpeechEndpoint.TextToSpeechAsync(request).Result;
				IWaveProvider provider = new RawSourceWaveStream(
					new MemoryStream(voiceClip.ClipData.ToArray()), new WaveFormat(16000, 1));
				var _waveOut = new WaveOut();
				_waveOut.Init(provider);
				_waveOut.Play();
				while (_waveOut.PlaybackState != PlaybackState.Stopped)
					System.Threading.Thread.Sleep(500);
            }
			catch (Exception ex) 
			{
				speakWindows(text);
			}
		}

		public static void speakWindows(String text)
		{		
			try
			{
				var synthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
				synthesizer.SetOutputToDefaultAudioDevice();
				if(Globals.settings.windowsSpeech.Voice!="")
					synthesizer.SelectVoice(Globals.settings.windowsSpeech.Voice);

				synthesizer.Speak(text);
				System.Threading.Thread.Sleep(1000);			
            }
            catch(Exception ex)
			{
				var synthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
				synthesizer.SetOutputToDefaultAudioDevice();

                if (synthesizer.SpeakAsync(text).IsCompleted) ;
            }
		}		
	}
}
