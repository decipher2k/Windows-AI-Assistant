using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Classes
{
	public class Command
	{
		public void runProgram(String file, String parameter = "")
		{
			ProcessStartInfo psi = new ProcessStartInfo()
			{
				UseShellExecute = true,
				FileName = file,
				Arguments = parameter,
				CreateNoWindow = true
			};
			Process.Start(psi);
		}



	}
}
