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
	public partial class OllamaSettings : Form
	{
		public OllamaSettings()
		{
			InitializeComponent();
			tbModel.Text = Globals.settings.ollama.Model;
			tbSystemPrompt.Text=Globals.settings.ollama.SystemPrompt;
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			if(tbModel.Text != "" && tbSystemPrompt.Text != "")
			{
				Globals.settings.ollama.Model = tbModel.Text;
				Globals.settings.ollama.SystemPrompt = tbSystemPrompt.Text;
				this.Close();
			}				
		}
	}
}
