namespace Windows_AI_Assistant.Settings
{
	partial class AzureSettings
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
			tbAPIKey = new TextBox();
			label2 = new Label();
			tbRegion = new TextBox();
			tbLanguage = new TextBox();
			label3 = new Label();
			bnSave = new Button();
			bnCancel = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 31);
			label1.Name = "label1";
			label1.Size = new Size(72, 25);
			label1.TabIndex = 0;
			label1.Text = "API Key";
			// 
			// tbAPIKey
			// 
			tbAPIKey.Location = new Point(30, 59);
			tbAPIKey.Name = "tbAPIKey";
			tbAPIKey.Size = new Size(441, 31);
			tbAPIKey.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(30, 114);
			label2.Name = "label2";
			label2.Size = new Size(67, 25);
			label2.TabIndex = 2;
			label2.Text = "Region";
			// 
			// tbRegion
			// 
			tbRegion.Location = new Point(30, 142);
			tbRegion.Name = "tbRegion";
			tbRegion.Size = new Size(441, 31);
			tbRegion.TabIndex = 3;
			// 
			// tbLanguage
			// 
			tbLanguage.Location = new Point(30, 247);
			tbLanguage.Name = "tbLanguage";
			tbLanguage.Size = new Size(441, 31);
			tbLanguage.TabIndex = 4;
			tbLanguage.Text = "en-US";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(30, 208);
			label3.Name = "label3";
			label3.Size = new Size(89, 25);
			label3.TabIndex = 5;
			label3.Text = "Language";
			// 
			// bnSave
			// 
			bnSave.Location = new Point(241, 321);
			bnSave.Name = "bnSave";
			bnSave.Size = new Size(112, 34);
			bnSave.TabIndex = 6;
			bnSave.Text = "Save";
			bnSave.UseVisualStyleBackColor = true;
			bnSave.Click += bnSave_Click;
			// 
			// bnCancel
			// 
			bnCancel.Location = new Point(359, 321);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new Size(112, 34);
			bnCancel.TabIndex = 7;
			bnCancel.Text = "Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			bnCancel.Click += bnCancel_Click;
			// 
			// AzureSettings
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(499, 381);
			Controls.Add(bnCancel);
			Controls.Add(bnSave);
			Controls.Add(label3);
			Controls.Add(tbLanguage);
			Controls.Add(tbRegion);
			Controls.Add(label2);
			Controls.Add(tbAPIKey);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "AzureSettings";
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Azure Settings";
			Load += AzureSettings_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbAPIKey;
		private Label label2;
		private TextBox tbRegion;
		private TextBox tbLanguage;
		private Label label3;
		private Button bnSave;
		private Button bnCancel;
	}
}