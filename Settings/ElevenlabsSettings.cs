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
	public partial class ElevenlabsSettings : Form
	{
		public ElevenlabsSettings()
		{
			InitializeComponent();
			tbAPIKey.Text = Globals.settings.elevenlabs.APIKey;
			tbVoice.Text = Globals.settings.elevenlabs.Voice;
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			if (tbAPIKey.Text != "" && tbVoice.Text != "")
			{
				Globals.settings.elevenlabs.APIKey = tbAPIKey.Text;
				Globals.settings.elevenlabs.Voice = tbVoice.Text;
				this.Close();
			}
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
