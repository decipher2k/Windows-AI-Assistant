using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Classes
{
	public class Pocketsphinx
	{
		public static bool keywordDetected = false;
		public Pocketsphinx()
		{
			new System.Threading.Thread(mainThread).Start();
		}

		public void mainThread()
		{
			Process process = new Process();
			while (true)
			{
				while (Globals.settings.useWindowsSpeech)
				{
					try
					{
						//sloppy process detection
						bool started = false;
						try
						{
							if(!process.HasExited)
							{
								started = true;
							}
						}catch (Exception e) 
						{
						}

						if (!started)
						{
							process = new Process();
							ProcessStartInfo startInfo = new ProcessStartInfo()
							{
								CreateNoWindow = true,
								FileName = ".\\pocketsphinx\\live_win32.exe",
								RedirectStandardOutput = true,
								RedirectStandardError = true,
								WorkingDirectory = ".\\pocketsphinx"
							};
							startInfo.EnvironmentVariables.Add("POCKETSPHINX_PATH", ".\\model");
							process = Process.Start(startInfo);
							String ret = "";
							while (Globals.settings.useWindowsSpeech)
							{	
								if (keywordDetected == false)
								{
									ret = process.StandardOutput.ReadLine();
									if (ret.ToLower().Contains("windows"))
									{
										keywordDetected = true;
										process.Kill();
										process = Process.Start(startInfo);

									}
								}
							}
							try
							{
								process.Kill();
							}
							catch (Exception ex) 
							{ 
							}
						}
					}
					catch (Exception ex) 
					{ 
					};
					System.Threading.Thread.Sleep(500);
				}
				try
				{
					if (!process.HasExited)
						process.Kill();
				}
				catch (Exception ex)
				{
				}
				System.Threading.Thread.Sleep(500);
			}
		}
	}
}
