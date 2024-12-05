using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows_AI_Assistant.Data;

namespace Windows_AI_Assistant.Classes
{
	public class Command
	{
		public void runProgram(String file, String parameter = "", String text = "")
		{
			try
			{
				ProcessStartInfo psi = new ProcessStartInfo()
				{
					UseShellExecute = true,
					CreateNoWindow = true,
					FileName = file,
					Arguments = parameter.Replace("[TEXT]", text)
				};
				Process.Start(psi);
			}
			catch (Exception ex) { new Classes.TextToSpeech().speakWindows("Error while starting the program."); }
		}

		public void openURL(String url, String GetPost, String parameter, String text)
		{
			if(GetPost=="GET")
			{
				new WebClient().DownloadString(url+parameter.Replace("[TEXT]",text));
			}
			else
			{
				parameter = parameter.Replace("[TEXT]", text);
				HttpClient client = new HttpClient();
				var values = new Dictionary<string, string>();
				String[] parameters = parameter.Split('&');
				foreach (String param in parameters) 
				{
					String[] keyValue= param.Split('=');
					values.Add(keyValue[0], keyValue[1]);
				}

				var content = new FormUrlEncodedContent(values);

				var response = client.PostAsync(url, content).Result;

				var responseString = response.Content.ReadAsStringAsync().Result;
			}
			
		}

	}
}
