namespace Windows_AI_Assistant.Settings
{
	partial class ElevenlabsSettings
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
			bnSave = new Button();
			bnCancel = new Button();
			tbVoice = new TextBox();
			label2 = new Label();
			tbAPIKey = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// bnSave
			// 
			bnSave.Location = new Point(170, 210);
			bnSave.Name = "bnSave";
			bnSave.Size = new Size(112, 34);
			bnSave.TabIndex = 11;
			bnSave.Text = "Save";
			bnSave.UseVisualStyleBackColor = true;
			bnSave.Click += bnSave_Click;
			// 
			// bnCancel
			// 
			bnCancel.Location = new Point(306, 210);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new Size(112, 34);
			bnCancel.TabIndex = 10;
			bnCancel.Text = "Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			bnCancel.Click += bnCancel_Click;
			// 
			// tbVoice
			// 
			tbVoice.Location = new Point(12, 126);
			tbVoice.Name = "tbVoice";
			tbVoice.Size = new Size(406, 31);
			tbVoice.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 98);
			label2.Name = "label2";
			label2.Size = new Size(54, 25);
			label2.TabIndex = 8;
			label2.Text = "Voice";
			// 
			// tbAPIKey
			// 
			tbAPIKey.Location = new Point(12, 38);
			tbAPIKey.Name = "tbAPIKey";
			tbAPIKey.Size = new Size(406, 31);
			tbAPIKey.TabIndex = 7;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 10);
			label1.Name = "label1";
			label1.Size = new Size(72, 25);
			label1.TabIndex = 6;
			label1.Text = "API Key";
			// 
			// ElevenlabsSettings
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(440, 272);
			Controls.Add(bnSave);
			Controls.Add(bnCancel);
			Controls.Add(tbVoice);
			Controls.Add(label2);
			Controls.Add(tbAPIKey);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "ElevenlabsSettings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ElevenlabsSettings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button bnSave;
		private Button bnCancel;
		private TextBox tbVoice;
		private Label label2;
		private TextBox tbAPIKey;
		private Label label1;
	}
}