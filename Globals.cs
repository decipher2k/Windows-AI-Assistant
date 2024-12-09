using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows_AI_Assistant.Classes;
using Windows_AI_Assistant.Data;

namespace Windows_AI_Assistant
{
	public class Globals
	{
		public static Data.Settings settings=new Data.Settings();
		public static void Save()
		{
			try
			{
				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIAssistant"))
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIAssistant");

				string jsonString = JsonSerializer.Serialize(settings);
				System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIAssistant\\settings.json", jsonString);
			}catch(Exception)
			{
				TextToSpeech.speakWindows("Error saving configuration.");
			}
		}

		public static void Load()
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIAssistant\\settings.json"))
			{
				try
				{
					String jsonString = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AIAssistant\\settings.json");
					settings = JsonSerializer.Deserialize<Data.Settings>(jsonString);
				}
				catch (Exception)
				{
					TextToSpeech.speakWindows("Error loading configuration.");
				}
			}
		}
	}
}
