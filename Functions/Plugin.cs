using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WAIA_Plugin;

namespace Windows_AI_Assistant.Functions
{
	public static class Plugin
	{
		public static String RunPlugin(String text, String dll, String[] parameter)
		{
			var DLL = Assembly.LoadFile(Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location)+"\\"+dll);

			foreach (Type type in DLL.GetExportedTypes())
			{
				var c = Activator.CreateInstance(type);
				if(type.GetInterfaces().Contains(typeof(IWAIAPlugin)))
					return (String)type.InvokeMember("RunPlugin", BindingFlags.InvokeMethod, null, c, new object[] { text,parameter });				
			}
			return "";
		}
	}
}
