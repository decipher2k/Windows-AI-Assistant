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
            label1.Location = new Point(36, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 0;
            label1.Text = "API Key";
            // 
            // tbAPIKey
            // 
            tbAPIKey.Location = new Point(36, 71);
            tbAPIKey.Margin = new Padding(4);
            tbAPIKey.Name = "tbAPIKey";
            tbAPIKey.Size = new Size(528, 35);
            tbAPIKey.TabIndex = 1;
            // 
            // tbLanguage
            // 
            tbLanguage.Location = new Point(36, 176);
            tbLanguage.Margin = new Padding(4);
            tbLanguage.Name = "tbLanguage";
            tbLanguage.Size = new Size(528, 35);
            tbLanguage.TabIndex = 4;
            tbLanguage.Text = "en-US";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 5;
            label3.Text = "Language";
            // 
            // bnSave
            // 
            bnSave.Location = new Point(288, 375);
            bnSave.Margin = new Padding(4);
            bnSave.Name = "bnSave";
            bnSave.Size = new Size(134, 41);
            bnSave.TabIndex = 6;
            bnSave.Text = "Save";
            bnSave.UseVisualStyleBackColor = true;
            bnSave.Click += bnSave_Click;
            // 
            // bnCancel
            // 
            bnCancel.Location = new Point(430, 375);
            bnCancel.Margin = new Padding(4);
            bnCancel.Name = "bnCancel";
            bnCancel.Size = new Size(134, 41);
            bnCancel.TabIndex = 7;
            bnCancel.Text = "Cancel";
            bnCancel.UseVisualStyleBackColor = true;
            bnCancel.Click += bnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 248);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 8;
            label2.Text = "Model";
            // 
            // tbModel
            // 
            tbModel.Location = new Point(36, 299);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(528, 35);
            tbModel.TabIndex = 9;
            tbModel.TextChanged += tbModel_TextChanged;
            // 
            // GroqSettings
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 448);
            Controls.Add(tbModel);
            Controls.Add(label2);
            Controls.Add(bnCancel);
            Controls.Add(bnSave);
            Controls.Add(label3);
            Controls.Add(tbLanguage);
            Controls.Add(tbAPIKey);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
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