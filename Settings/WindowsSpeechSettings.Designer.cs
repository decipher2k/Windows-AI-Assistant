namespace Windows_AI_Assistant.Settings
{
	partial class WindowsSpeechSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			cbVoice = new ComboBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(28, 20);
			label1.Name = "label1";
			label1.Size = new Size(54, 25);
			label1.TabIndex = 0;
			label1.Text = "Voice";
			// 
			// cbVoice
			// 
			cbVoice.DropDownStyle = ComboBoxStyle.DropDownList;
			cbVoice.FormattingEnabled = true;
			cbVoice.Location = new Point(28, 61);
			cbVoice.Name = "cbVoice";
			cbVoice.Size = new Size(522, 33);
			cbVoice.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(311, 128);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 2;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(438, 128);
			button2.Name = "button2";
			button2.Size = new Size(112, 34);
			button2.TabIndex = 3;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// WindowsSpeechSettings
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(592, 203);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(cbVoice);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "WindowsSpeechSettings";
			Text = "Windows Speech Settings";
			Load += WindowsSpeechSettings_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox cbVoice;
		private Button button1;
		private Button button2;
	}
}