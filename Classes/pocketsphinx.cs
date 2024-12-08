using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using Microsoft.PhoneticMatching.Matchers.FuzzyMatcher.Normalized;
using Microsoft.PhoneticMatching.Matchers;

namespace Windows_AI_Assistant.Classes
{
	public class Pocketsphinx
	{
		public static bool keywordDetected = false;
		public static Process process = new Process();
        public Pocketsphinx()
		{
			new System.Threading.Thread(mainThread).Start();
        }
        public void mainThread()
		{
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = ".\\pocketsphinx\\live_win32.exe",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = ".\\pocketsphinx"
            };

            var matcher = new EnPhoneticFuzzyMatcher<string>(new string[] {"windows"});
            while (AppContext.running)
			{
				while (Globals.settings.useWindowsSpeech && AppContext.running)
				{
					try
					{
						process.Kill();
					}
					catch(Exception ex)
					{
					}

					try
					{
						//sloppy process detection
						bool started = false;


						if (!started)
						{
							started = true;
							process = new Process();
							
							startInfo.EnvironmentVariables.Add("POCKETSPHINX_PATH", ".\\model");
							process = Process.Start(startInfo);
						}
							String ret = "";
							while (Globals.settings.useWindowsSpeech)
							{	
								if (keywordDetected == false)
								{
									ret = process.StandardOutput.ReadLine();

                                    if (matcher.FindNearest(ret).Distance<0.1)
									{
										keywordDetected = true;
									}
									process.Kill();
									process = Process.Start(startInfo);

                            }
							}
							try
							{
								started=false;
								process.Kill();
							}
							catch (Exception ex) 
							{ 
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
