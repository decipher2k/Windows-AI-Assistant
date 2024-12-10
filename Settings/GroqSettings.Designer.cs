namespace Windows_AI_Assistant.Settings
{
	partial class GroqSettings
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
            tbLanguage = new TextBox();
            label3 = new Label();
            bnSave = new Button();
            bnCancel = new Button();
            label2 = new Label();
            tbModel = new TextBox();
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
            // tbLanguage
            // 
            tbLanguage.Location = new Point(30, 147);
            tbLanguage.Name = "tbLanguage";
            tbLanguage.Size = new Size(441, 31);
            tbLanguage.TabIndex = 4;
            tbLanguage.Text = "en-US";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 108);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 5;
            label3.Text = "Language";
            // 
            // bnSave
            // 
            bnSave.Location = new Point(240, 312);
            bnSave.Name = "bnSave";
            bnSave.Size = new Size(112, 34);
            bnSave.TabIndex = 6;
            bnSave.Text = "Save";
            bnSave.UseVisualStyleBackColor = true;
            bnSave.Click += bnSave_Click;
            // 
            // bnCancel
            // 
            bnCancel.Location = new Point(358, 312);
            bnCancel.Name = "bnCancel";
            bnCancel.Size = new Size(112, 34);
            bnCancel.TabIndex = 7;
            bnCancel.Text = "Cancel";
            bnCancel.UseVisualStyleBackColor = true;
            bnCancel.Click += bnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 207);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 8;
            label2.Text = "Model";
            // 
            // tbModel
            // 
            tbModel.Location = new Point(30, 235);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(441, 31);
            tbModel.TabIndex = 9;
            // 
            // GroqSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 373);
            Controls.Add(tbModel);
            Controls.Add(label2);
            Controls.Add(bnCancel);
            Controls.Add(bnSave);
            Controls.Add(label3);
            Controls.Add(tbLanguage);
            Controls.Add(tbAPIKey);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GroqSettings";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Groq Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TextBox tbAPIKey;
		private TextBox tbLanguage;
		private Label label3;
		private Button bnSave;
		private Button bnCancel;
        private Label label2;
        private TextBox tbModel;
    }
}