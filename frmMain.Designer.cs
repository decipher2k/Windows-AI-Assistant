namespace Windows_AI_Assistant
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            cbVoiceRecognition = new ComboBox();
            label2 = new Label();
            cbChatAI = new ComboBox();
            label3 = new Label();
            cbSpeechSynthesis = new ComboBox();
            bnSettingsVoiceRecognition = new Button();
            bnSettingsChatAI = new Button();
            bnSettingsSpeechSynthesis = new Button();
            label4 = new Label();
            tbKeyword = new TextBox();
            button1 = new Button();
            cbAutostart = new CheckBox();
            label5 = new Label();
            cbKeywordDetection = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 114);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 30);
            label1.TabIndex = 1;
            label1.Text = "Voice Recognition:";
            // 
            // cbVoiceRecognition
            // 
            cbVoiceRecognition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVoiceRecognition.FormattingEnabled = true;
            cbVoiceRecognition.Items.AddRange(new object[] { "Microsoft Azure", "Groq", "Windows Speech Recognition" });
            cbVoiceRecognition.Location = new Point(32, 148);
            cbVoiceRecognition.Margin = new Padding(4);
            cbVoiceRecognition.Name = "cbVoiceRecognition";
            cbVoiceRecognition.Size = new Size(425, 38);
            cbVoiceRecognition.TabIndex = 2;
            cbVoiceRecognition.SelectedIndexChanged += cbVoiceRecognition_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 3;
            label2.Text = "Chat AI:";
            // 
            // cbChatAI
            // 
            cbChatAI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChatAI.FormattingEnabled = true;
            cbChatAI.Items.AddRange(new object[] { "ChatGPT", "Groq", "Ollama", "Awan" });
            cbChatAI.Location = new Point(32, 248);
            cbChatAI.Margin = new Padding(4);
            cbChatAI.Name = "cbChatAI";
            cbChatAI.Size = new Size(425, 38);
            cbChatAI.TabIndex = 4;
            cbChatAI.SelectedIndexChanged += cbChatAI_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 326);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(176, 30);
            label3.TabIndex = 5;
            label3.Text = "Speech Synthesis:";
            // 
            // cbSpeechSynthesis
            // 
            cbSpeechSynthesis.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpeechSynthesis.FormattingEnabled = true;
            cbSpeechSynthesis.Items.AddRange(new object[] { "Elevenlabs", "Microsoft Windows Speech" });
            cbSpeechSynthesis.Location = new Point(32, 360);
            cbSpeechSynthesis.Margin = new Padding(4);
            cbSpeechSynthesis.Name = "cbSpeechSynthesis";
            cbSpeechSynthesis.Size = new Size(425, 38);
            cbSpeechSynthesis.TabIndex = 6;
            cbSpeechSynthesis.SelectedIndexChanged += cbSpeechSynthesis_SelectedIndexChanged;
            // 
            // bnSettingsVoiceRecognition
            // 
            bnSettingsVoiceRecognition.Location = new Point(466, 148);
            bnSettingsVoiceRecognition.Margin = new Padding(4);
            bnSettingsVoiceRecognition.Name = "bnSettingsVoiceRecognition";
            bnSettingsVoiceRecognition.Size = new Size(134, 41);
            bnSettingsVoiceRecognition.TabIndex = 7;
            bnSettingsVoiceRecognition.Text = "Settings";
            bnSettingsVoiceRecognition.UseVisualStyleBackColor = true;
            bnSettingsVoiceRecognition.Click += bnSettingsVoiceRecognition_Click;
            // 
            // bnSettingsChatAI
            // 
            bnSettingsChatAI.Location = new Point(466, 248);
            bnSettingsChatAI.Margin = new Padding(4);
            bnSettingsChatAI.Name = "bnSettingsChatAI";
            bnSettingsChatAI.Size = new Size(134, 41);
            bnSettingsChatAI.TabIndex = 8;
            bnSettingsChatAI.Text = "Settings";
            bnSettingsChatAI.UseVisualStyleBackColor = true;
            bnSettingsChatAI.Click += bnSettingsChatAI_Click;
            // 
            // bnSettingsSpeechSynthesis
            // 
            bnSettingsSpeechSynthesis.Location = new Point(466, 360);
            bnSettingsSpeechSynthesis.Margin = new Padding(4);
            bnSettingsSpeechSynthesis.Name = "bnSettingsSpeechSynthesis";
            bnSettingsSpeechSynthesis.Size = new Size(134, 41);
            bnSettingsSpeechSynthesis.TabIndex = 9;
            bnSettingsSpeechSynthesis.Text = "Settings";
            bnSettingsSpeechSynthesis.UseVisualStyleBackColor = true;
            bnSettingsSpeechSynthesis.Click += bnSettingsSpeechSynthesis_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 10;
            label4.Text = "Keyword:";
            // 
            // tbKeyword
            // 
            tbKeyword.Location = new Point(32, 61);
            tbKeyword.Margin = new Padding(4);
            tbKeyword.Name = "tbKeyword";
            tbKeyword.Size = new Size(567, 35);
            tbKeyword.TabIndex = 11;
            tbKeyword.TextChanged += tbKeyword_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(32, 564);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(568, 41);
            button1.TabIndex = 12;
            button1.Text = "Commands";
            button1.UseVisualStyleBackColor = true;
            button1.Click += bnSettingsCommands_Click;
            // 
            // cbAutostart
            // 
            cbAutostart.AutoSize = true;
            cbAutostart.Location = new Point(32, 427);
            cbAutostart.Margin = new Padding(4);
            cbAutostart.Name = "cbAutostart";
            cbAutostart.Size = new Size(217, 34);
            cbAutostart.TabIndex = 13;
            cbAutostart.Text = "Start with Windows";
            cbAutostart.UseVisualStyleBackColor = true;
            cbAutostart.CheckedChanged += cbAutostart_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(59, 498);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(529, 30);
            label5.TabIndex = 15;
            label5.Text = "(The keyword to start recognition is allways \"Windows\").";
            // 
            // cbKeywordDetection
            // 
            cbKeywordDetection.AutoSize = true;
            cbKeywordDetection.Location = new Point(32, 469);
            cbKeywordDetection.Margin = new Padding(4);
            cbKeywordDetection.Name = "cbKeywordDetection";
            cbKeywordDetection.Size = new Size(561, 34);
            cbKeywordDetection.TabIndex = 14;
            cbKeywordDetection.Text = "Use Windows Speech Recognition for keyword detection";
            cbKeywordDetection.UseVisualStyleBackColor = true;
            cbKeywordDetection.CheckedChanged += cbKeywordDetection_CheckedChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 619);
            Controls.Add(label5);
            Controls.Add(cbKeywordDetection);
            Controls.Add(cbAutostart);
            Controls.Add(button1);
            Controls.Add(tbKeyword);
            Controls.Add(label4);
            Controls.Add(bnSettingsSpeechSynthesis);
            Controls.Add(bnSettingsChatAI);
            Controls.Add(bnSettingsVoiceRecognition);
            Controls.Add(cbSpeechSynthesis);
            Controls.Add(label3);
            Controls.Add(cbChatAI);
            Controls.Add(label2);
            Controls.Add(cbVoiceRecognition);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows AI Assistant";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
		private ComboBox cbVoiceRecognition;
		private Label label2;
		private ComboBox cbChatAI;
		private Label label3;
		private ComboBox cbSpeechSynthesis;
		private Button bnSettingsVoiceRecognition;
		private Button bnSettingsChatAI;
		private Button bnSettingsSpeechSynthesis;
		private Label label4;
		private TextBox tbKeyword;
		private Button button1;
		private CheckBox cbAutostart;
        private Label label5;
        private CheckBox cbKeywordDetection;
    }
}
