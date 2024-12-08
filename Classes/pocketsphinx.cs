using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using Microsoft.PhoneticMatching.Matchers.FuzzyMatcher.Normalized;
using Microsoft.PhoneticMatching.Matchers;
using Microsoft.CognitiveServices.Speech.Speaker;
using NAudio.Wave;

namespace Windows_AI_Assistant.Classes
{
    public class Pocketsphinx
    {
        public static bool keywordDetected = false;
        public static Process iconProcess = new Process();
        public static Process process = new Process();

        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            CreateNoWindow = true,
            FileName = ".\\pocketsphinx\\live_win32.exe",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            WorkingDirectory = ".\\pocketsphinx"
        };

        public Pocketsphinx()
        {
            new System.Threading.Thread(mainThread).Start();
        }

        public void restart()
        {
            try
            {
                process.Kill();
                keywordDetected = false;
            }
            catch (Exception ex)
            {
            }
               
            process = Process.Start(startInfo);
            
        }


        public void mainThread()
        {
            var matcher = new EnPhoneticFuzzyMatcher<string>(new string[] { "windows" });
            while (true)
            {
                while (Globals.settings.useWindowsSpeech && AppContext.running)
                {
                    try
                    {
                        //sloppy process detection
                        bool started = false;
                        try
                        {
                            if (!process.HasExited)
                            {
                                started = true;
                            }
                        }
                        catch (Exception e)
                        {
                        }

                        if (!started)
                        {
                            process = new Process();
                           
                            startInfo.EnvironmentVariables.Add("POCKETSPHINX_PATH", ".\\model");
                            process = Process.Start(startInfo);
                            iconProcess = Process.Start(startInfo);
                            //iconProcess = Process.Start(startInfo);
                            String ret = "";
                            while (Globals.settings.useWindowsSpeech && AppContext.running)
                            {
                                

                                try
                                {
                                    do
                                    {
                                        if(ret==null)
                                        {
                                            restart();
                                        }
                                        while ((ret!=null && !(matcher.FindNearest(ret).Distance < 0.1))||ret==null)
                                        {
                                            if (ret == null)
                                            {
                                                restart();
                                            }
                                            if (process.HasExited)
                                                process = Process.Start(startInfo);
                                            ret = process.StandardOutput.ReadLine();
                                        }
                                    } while (ret == null);
                                }
                                catch (Exception ex) {
                                    MessageBox.Show(ex.Message + ex.StackTrace);
                                }
                                if (ret!=null && matcher.FindNearest(ret).Distance < 0.1)
                                {
                                    keywordDetected = true;
                                    ret = "";
                                }
                                if (ret == null)
                                {
                                    restart();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
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