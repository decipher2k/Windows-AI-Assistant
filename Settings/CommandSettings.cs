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
				if (program.Token != null && program.Token != "")
				{
					dgProgram.Rows.Add(new String[]
					{
					"Voice Recognition",
					program.Token.ToString(),
					program.Command.ToString(),
					program.Parameter.ToString()
					});
				};
			}


			foreach (Data.Webhook webhook in Globals.settings.webhooks)
			{
				if (webhook.Token != null && webhook.Token != "")
				{
					dgWebhook.Rows.Add(new String[]
					{
					"Voice Recognition",
					webhook.Token.ToString(),
					webhook.URl.ToString(),
					webhook.Getpost.ToString(),
					webhook.Parameter.ToString()
					});
				}
			}

			foreach (Data.Plugin plugin in Globals.settings.plugins)
			{
				if (plugin.Token != null && plugin.Token != "")
				{
					dgPlugins.Rows.Add(new String[]
					{
					"Voice Recognition",
					plugin.Token.ToString(),
					plugin.DLL.ToString(),
					plugin.Parameter[0].ToString(),
					plugin.Parameter[1].ToString(),
					plugin.Parameter[2].ToString()
					});
				}
			}
		}

		private void bnSave_Click(object sender, EventArgs e)
		{
			Globals.settings.programs.Clear();
			foreach (DataGridViewRow row in dgProgram.Rows)
			{
				for (int i = 0; i < row.Cells.Count; i++)
				{
					if (row.Cells[i].Value == null)
						row.Cells[i].Value = "";
				}

				try
				{
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
				catch (Exception ex) { }
			}

			Globals.settings.webhooks.Clear();
			foreach (DataGridViewRow row in dgWebhook.Rows)
			{
				for (int i = 0; i < row.Cells.Count; i++)
				{
					if (row.Cells[i].Value == null)
						row.Cells[i].Value = "";
				}

				try
				{
					if (row.Cells[1].Value != "" && row.Cells[2].Value != "")
					{
						Data.Webhook webhook = new Data.Webhook()
						{
							Token = row.Cells[1].Value.ToString(),
							URl = row.Cells[2].Value.ToString(),
							Getpost = Data.Webhook.GetPost.Parse<Data.Webhook.GetPost>(row.Cells[3].Value.ToString()),
							Parameter = row.Cells[4].Value.ToString()

						};
						Globals.settings.webhooks.Add(webhook);
					}
				}
				catch (Exception ex) { }
			}

			Globals.settings.plugins.Clear();
			foreach (DataGridViewRow row in dgPlugins.Rows)
			{
				for (int i = 0; i < row.Cells.Count; i++)
				{
					if (row.Cells[i].Value == null)
						row.Cells[i].Value = "";
				}
				try
				{
					if (row.Cells[1].Value != "" && row.Cells[2].Value != "")
					{
						Data.Plugin plugin = new Data.Plugin();						
						plugin.Token = row.Cells[1].Value.ToString();
						plugin.DLL = row.Cells[2].Value.ToString();
						plugin.Parameter[0] = row.Cells[3].Value.ToString();
						plugin.Parameter[1] = row.Cells[4].Value.ToString();
						plugin.Parameter[2] = row.Cells[5].Value.ToString();						
													
						Globals.settings.plugins.Add(plugin);
					}
				}
				catch (Exception ex) { }
			}
			this.Close();
		}

		private void bnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void CommandSettings_Load(object sender, EventArgs e)
		{

		}
	}
}
