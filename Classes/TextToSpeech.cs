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
	public class TextToSpeech
	{
		public void speakElevenlabs(String text, String key, String sVoice)
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
			catch (Exception ex) { new Classes.TextToSpeech().speakWindows("Error querying Elevenlabs."); }
		}

		public void speakWindows(String text)
		{		
			try
			{
				var synthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
				synthesizer.SetOutputToDefaultAudioDevice();
				synthesizer.Speak(text);
			}catch(Exception ex)
			{
				new Classes.TextToSpeech().speakWindows("Microsoft Speech error.");
			}
		}		
	}
}
