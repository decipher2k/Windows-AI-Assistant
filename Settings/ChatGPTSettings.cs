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
	public partial class ChatGPTSettings : Form
	{
		public ChatGPTSettings()
		{
			InitializeComponent();
			tbAPIKey.Text = Globals.settings.chatGPT.APIKey;
		}

		private void OllamaSettings_Load(object sender, EventArgs e)
		{
			
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			if (tbAPIKey.Text != "")
			{
				Globals.settings.chatGPT.APIKey = tbAPIKey.Text;
			}
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
