using NAudio.Wave.Compression;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Windows_AI_Assistant.Classes
{
	public class RecordAudio
	{
		WaveInEvent waveSource = new WaveInEvent();
		WaveInEvent waveSourceImpedance = new WaveInEvent();
		private float impedance = 0;
		private float impedance_prev = 0;

		public bool finished=false;
		bool listening_started = false;
		bool recording_started = false;
		bool recording = false;
		float impedance_at_recording = 0;
		bool just_started = false;
		bool louder = false;
		bool done = false;
		private void calculateImpedance()
		{
			
			
					waveSourceImpedance.WaveFormat = new WaveFormat(16000, 1);

					waveSourceImpedance.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailableImpedance);
					listening_started = true;
					waveSourceImpedance.StartRecording();
			
			
		}
		int step = 0;
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
			new System.Threading.Thread(updateThread).Start();
			waveSource.StartRecording();
		}

		public List<byte> buffer = new List<byte>();
		DateTime lastUpdate = DateTime.Now;
		bool started = false;
		private void waveSource_DataAvailable(object? sender, WaveInEventArgs e)
		{
			
			{
				long silenceCount = 0;
				bool silence = false;

				for (int i = 0; i < e.Buffer.Length; i++)
				{
					if (e.Buffer[i] < 50)
					{
						silenceCount++;
					}
				}
				if (impedance_at_recording == 0)
					impedance_at_recording = e.Buffer.Length - silenceCount;

				impedance = e.Buffer.Length - silenceCount;

				if (impedance > impedance_at_recording * 1.01)
				{
					louder = true;
					started = true;
					lastUpdate = DateTime.Now;
				}

				if ((DateTime.Now - lastUpdate).TotalSeconds > 2 && louder)
				{
					done = true;
				}
				byte[] ebuffer = new byte[e.BytesRecorded];
				for (int n = 0; n < ebuffer.Length; n++)
				{
					ebuffer[n] = e.Buffer[n];
				}
				buffer.AddRange(ebuffer);
			}
		}

		private void updateThread()
		{
			while (!done)
			{
				System.Threading.Thread.Sleep(100);
			}
			//	if (buffer.Count() > 30000)
			{
				waveSource.StopRecording();
				if (File.Exists("output.wav"))
					File.Delete("output.wav");
				WaveFileWriter waveFile = new WaveFileWriter(@"output.wav", waveSource.WaveFormat);
				waveFile.Write(buffer.ToArray(), 0, buffer.Count());

				waveFile.Close();
				finished = true;
			}
		}
	}
}
