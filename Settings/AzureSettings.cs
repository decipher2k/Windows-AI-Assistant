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
	public partial class AzureSettings : Form
	{
		public AzureSettings()
		{
			InitializeComponent();
			tbAPIKey.Text=Globals.settings.azure.APIKey;
			tbLanguage.Text=Globals.settings.azure.Language;
			tbRegion.Text=Globals.settings.azure.Region;
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			if (tbAPIKey.Text != "" && tbLanguage.Text != "" && tbRegion.Text != "")
			{
				Globals.settings.azure.APIKey = tbAPIKey.Text;
				Globals.settings.azure.Language = tbLanguage.Text;
				Globals.settings.azure.Region = tbRegion.Text;
				this.Close();
			}
			
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AzureSettings_Load(object sender, EventArgs e)
		{

		}
	}
}
