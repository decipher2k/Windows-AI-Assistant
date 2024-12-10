using NAudio.Wave.Compression;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Speech.Recognition;

namespace Windows_AI_Assistant.Functions
{
	public class RecordAudio
	{
		WaveInEvent waveSource = new WaveInEvent();
	
		public bool finished=false;
		public bool running = false;

        public List<byte> buffer = new List<byte>();
        DateTime lastUpdate = DateTime.Now;
        bool started = false;
        public bool failed = false;
        bool silence = true;
        long silenceCount = 0;
		public bool speechRecognized = false;
        DateTime lastUpdateTime = DateTime.Now;
        DateTime recordingStarted = DateTime.Now;


        private void waveSource_DataAvailableImpedance(object? sender, WaveInEventArgs e)
		{
			int silenceCount = 0;
			for (int i = 0; i < e.Buffer.Length; i++)
			{
				if (e.Buffer[i] < 50)
				{
					silenceCount++;
				}
			}
		}

		public void startRecording()
		{			
			waveSource.WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(16000, 1);
			waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
			SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
			speechRecognitionEngine.LoadGrammar(new DictationGrammar());
			speechRecognitionEngine.SetInputToDefaultAudioDevice();
            speechRecognitionEngine.RecognizeAsync();            
            speechRecognitionEngine.SpeechRecognized += SpeechRecognitionEngine_SpeechRecognized;
			waveSource.StartRecording();
		}

        private void SpeechRecognitionEngine_SpeechRecognized(object? sender, SpeechRecognizedEventArgs e)
        {
			speechRecognized = true;
            recordingStarted = DateTime.Now;
        }

        private void waveSource_DataAvailable(object? sender, WaveInEventArgs e)
		{
			if ((DateTime.Now - lastUpdateTime).TotalSeconds > 3 && !started)
			{
				failed = true;
				waveSource.StopRecording();
			}

			int count = 0;
			double dbA = 0;
			for (int i = 0; i < e.Buffer.Length; i++)
			{
				double dB = 2000 * Math.Log10(Math.Abs(e.Buffer[i]));

				if (dB > -99999999999)
				{
					dbA += dB;
					count++;
				}
			}
			if ((dbA / count) > 3983)
				silence = false;
			else
				silence = true;

			if (!silence)
			{
				started = true;
				running = true;
				//recordingStarted = DateTime.Now;
			}
			else
			{
				if (started)
				{
					silenceCount++;
				}
			}

			buffer.AddRange(e.Buffer);
    

            if (silenceCount > 35 && speechRecognized)
			{
				if ((DateTime.Now - recordingStarted).TotalSeconds < 1.3)
				{
					failed = true;
				}
				else
				{
					running = false;
					waveSource.StopRecording();
					waveSource.Dispose();
					if (File.Exists("output.wav"))
						File.Delete("output.wav");
					WaveFileWriter waveFile = new WaveFileWriter(@"output.wav", waveSource.WaveFormat);
					waveFile.Write(buffer.ToArray(), 0, buffer.Count());

					waveFile.Close();
					finished = true;
				}
			}
			else if (silenceCount > 35 && !speechRecognized)
			{
				failed = true;
			}

		}
	}
}
