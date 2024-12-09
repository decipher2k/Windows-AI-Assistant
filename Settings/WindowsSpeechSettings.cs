using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Windows_AI_Assistant.Settings
{
	public partial class WindowsSpeechSettings : Form
	{
		public WindowsSpeechSettings()
		{
			InitializeComponent();
		}

		private void WindowsSpeechSettings_Load(object sender, EventArgs e)
		{
			var synthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
			foreach (var voice in synthesizer.GetInstalledVoices())
			{
				cbVoice.Items.Add(voice.VoiceInfo.Name);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cbVoice.SelectedItem != null)
			{
				Globals.settings.windowsSpeech.Voice = cbVoice.SelectedItem.ToString();
				this.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
