using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_AI_Assistant.Settings
{
	public partial class GroqSettings : Form
	{
		public GroqSettings()
		{
			InitializeComponent();
			tbAPIKey.Text=Globals.settings.groq.APIKey;
			tbLanguage.Text = Globals.settings.groq.Language == "" ? "en-US" : Globals.settings.groq.Language;
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			if (tbAPIKey.Text != "" && tbLanguage.Text != "")
			{
				Globals.settings.groq.APIKey = tbAPIKey.Text;
				Globals.settings.groq.Language = tbLanguage.Text;
				this.Close();
			}
			
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
