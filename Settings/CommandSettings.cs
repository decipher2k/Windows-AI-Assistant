using ElevenLabs.Voices;
using OllamaSharp;
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
	public partial class CommandSettings : Form
	{
		public CommandSettings()
		{
			InitializeComponent();

			foreach (Data.Program program in Globals.settings.programs)
			{
				dgProgram.Rows.Add(new String[]
				{
					"Voice Recognition",
					program.Token.ToString(),
					program.Command.ToString(),
					program.Parameter.ToString()
				});
			}


			foreach (Data.Webhook webhook in Globals.settings.webhooks)
			{				
				dgWebhook.Rows.Add(new String[]
				{
					"Voice Recognition",
					webhook.Token.ToString(),
					webhook.URl.ToString()
				});
			}
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			Globals.settings.programs.Clear();
			foreach (DataGridViewRow row in dgProgram.Rows)
			{
				for(int i=0;i<row.Cells.Count;i++)
				{
					if (row.Cells[i].Value == null)
						row.Cells[i].Value = "";
				}

				if (row.Cells[1].Value != "" && row.Cells[2].Value != "")
				{
					Data.Program program = new Data.Program()
					{
						Token = row.Cells[1].Value.ToString(),
						Command = row.Cells[2].Value.ToString(),
						Parameter = row.Cells[3].Value.ToString()
					};

					Globals.settings.programs.Add(program);
				}
			}

			Globals.settings.webhooks.Clear();
			foreach (DataGridViewRow row in dgWebhook.Rows)
			{
				for (int i = 0; i < row.Cells.Count; i++)
				{
					if (row.Cells[i].Value == null)
						row.Cells[i].Value = "";
				}

				if (row.Cells[1].Value != "" && row.Cells[2].Value != "")
				{
					Data.Webhook webhook = new Data.Webhook()
					{
						Token = row.Cells[1].Value.ToString(),
						URl = row.Cells[2].Value.ToString()
					};
					Globals.settings.webhooks.Add(webhook);
				}
			}
			this.Close();
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
