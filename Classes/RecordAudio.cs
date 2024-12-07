using NAudio.Wave.Compression;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		private void calculateImpedance()
		{
			while (true)
			{
				//initialize
				if (!listening_started) 
				{
					WaveInEvent waveSourceImpedance = new WaveInEvent();
					waveSourceImpedance.WaveFormat = new WaveFormat(16000, 1);

					waveSourceImpedance.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailableImpedance);
					listening_started = true;
					waveSourceImpedance.StartRecording();
				}
				else
				{
					//if recording has not started and is above threshhold
					//(check for start of recording
					if (impedance > impedance_prev * 1.3f && !recording_started)
					{
						//set impedance at recording start to current impedance and start recording
						impedance_at_recording = impedance;
						recording_started = true;
						recording = true;
					}
					//if previous impedance was more silent then at start and if is recording
					//(check for end of recording)
					else if (impedance_prev <= impedance_at_recording * 0.2f && recording_started)
					{
						recording = false;
						finished = true;
					}
					//currently recording
					if(listening_started) 
					{
						impedance_prev = impedance;
						lastUpdate = DateTime.Now;
					}
				}
				System.Threading.Thread.Sleep(1000);
			}
		}

		private void waveSource_DataAvailableImpedance(object? sender, WaveInEventArgs e)
		{
			int silenceCount = 0;
			for (int i = 0; i < e.Buffer.Length; i++)
			{
				if (e.Buffer[i] < 25 || e.Buffer[i] > 200)
				{
					silenceCount++;
				}
			}
			impedance_prev=impedance;
			impedance = silenceCount;

		}

		public void startRecording()
		{			
			waveSource.WaveFormat = new WaveFormat(16000, 1);

			waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
			new System.Threading.Thread(updateThread).Start();
			waveSource.StartRecording();
			new System.Threading.Thread(calculateImpedance).Start();
		}

		public IEnumerable<byte> buffer=new List<byte>();
		DateTime lastUpdate = DateTime.Now;
		bool started = false;
		private void waveSource_DataAvailable(object? sender, WaveInEventArgs e)
		{
			if (recording)
			{
				long silenceCount = 0;
				bool silence = false;

				for (int i = 0; i < e.Buffer.Length; i++)
				{
					if (e.Buffer[i] < 25 || e.Buffer[i] > 200)
					{
						silenceCount++;
					}
				}

				buffer = buffer.Concat(e.Buffer);
			}
		}

		private void updateThread()
		{
			while (!finished)
			{
				if ((DateTime.Now - lastUpdate).TotalSeconds >1 && started)
				{
					if (buffer.Count() > 30000)
					{
						waveSource.StopRecording();
						WaveFileWriter waveFile = new WaveFileWriter(@"output.wav", waveSource.WaveFormat);
						waveFile.Write(buffer.ToArray(), 0, buffer.Count());
						waveFile.Flush();
						waveFile.Close();
						finished = true;
					}
					else
					{
						//buffer = new List<byte>();
						lastUpdate = DateTime.Now;
					}
				}
				System.Threading.Thread.Sleep(100);
			}
		}
	}
}
