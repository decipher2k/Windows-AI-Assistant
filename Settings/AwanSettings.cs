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
	public partial class AwanSettings : Form
	{
		public AwanSettings()
		{
			InitializeComponent();
			tbAPIKey.Text = Globals.settings.awan.APIKey;
			cbModel.SelectedItem=Globals.settings.awan.Model;
		}

		private void OllamaSettings_Load(object sender, EventArgs e)
		{
			
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			if (tbAPIKey.Text != "")
			{
				Globals.settings.awan.APIKey = tbAPIKey.Text;
				Globals.settings.awan.Model=cbModel.Text;
				this.Close();
			}
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
