﻿namespace Windows_AI_Assistant
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            label6 = new Label();
            tbLanguage = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 105);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "Voice Recognition:";
            // 
            // cbVoiceRecognition
            // 
            cbVoiceRecognition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVoiceRecognition.FormattingEnabled = true;
            cbVoiceRecognition.Items.AddRange(new object[] { "Microsoft Azure", "Groq", "Windows Speech Recognition" });
            cbVoiceRecognition.Location = new Point(27, 133);
            cbVoiceRecognition.Name = "cbVoiceRecognition";
            cbVoiceRecognition.Size = new Size(355, 33);
            cbVoiceRecognition.TabIndex = 2;
            cbVoiceRecognition.SelectedIndexChanged += cbVoiceRecognition_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 189);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 3;
            label2.Text = "Chat AI:";
            // 
            // cbChatAI
            // 
            cbChatAI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChatAI.FormattingEnabled = true;
            cbChatAI.Items.AddRange(new object[] { "ChatGPT", "Groq", "Ollama", "Awan" });
            cbChatAI.Location = new Point(27, 217);
            cbChatAI.Name = "cbChatAI";
            cbChatAI.Size = new Size(355, 33);
            cbChatAI.TabIndex = 4;
            cbChatAI.SelectedIndexChanged += cbChatAI_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 282);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 5;
            label3.Text = "Speech Synthesis:";
            // 
            // cbSpeechSynthesis
            // 
            cbSpeechSynthesis.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpeechSynthesis.FormattingEnabled = true;
            cbSpeechSynthesis.Items.AddRange(new object[] { "Elevenlabs", "Microsoft Windows Speech" });
            cbSpeechSynthesis.Location = new Point(27, 310);
            cbSpeechSynthesis.Name = "cbSpeechSynthesis";
            cbSpeechSynthesis.Size = new Size(355, 33);
            cbSpeechSynthesis.TabIndex = 6;
            cbSpeechSynthesis.SelectedIndexChanged += cbSpeechSynthesis_SelectedIndexChanged;
            // 
            // bnSettingsVoiceRecognition
            // 
            bnSettingsVoiceRecognition.Location = new Point(388, 133);
            bnSettingsVoiceRecognition.Name = "bnSettingsVoiceRecognition";
            bnSettingsVoiceRecognition.Size = new Size(112, 34);
            bnSettingsVoiceRecognition.TabIndex = 7;
            bnSettingsVoiceRecognition.Text = "Settings";
            bnSettingsVoiceRecognition.UseVisualStyleBackColor = true;
            bnSettingsVoiceRecognition.Click += bnSettingsVoiceRecognition_Click;
            // 
            // bnSettingsChatAI
            // 
            bnSettingsChatAI.Location = new Point(388, 217);
            bnSettingsChatAI.Name = "bnSettingsChatAI";
            bnSettingsChatAI.Size = new Size(112, 34);
            bnSettingsChatAI.TabIndex = 8;
            bnSettingsChatAI.Text = "Settings";
            bnSettingsChatAI.UseVisualStyleBackColor = true;
            bnSettingsChatAI.Click += bnSettingsChatAI_Click;
            // 
            // bnSettingsSpeechSynthesis
            // 
            bnSettingsSpeechSynthesis.Location = new Point(388, 310);
            bnSettingsSpeechSynthesis.Name = "bnSettingsSpeechSynthesis";
            bnSettingsSpeechSynthesis.Size = new Size(112, 34);
            bnSettingsSpeechSynthesis.TabIndex = 9;
            bnSettingsSpeechSynthesis.Text = "Settings";
            bnSettingsSpeechSynthesis.UseVisualStyleBackColor = true;
            bnSettingsSpeechSynthesis.Click += bnSettingsSpeechSynthesis_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 23);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 10;
            label4.Text = "Keyword:";
            // 
            // tbKeyword
            // 
            tbKeyword.Location = new Point(27, 51);
            tbKeyword.Name = "tbKeyword";
            tbKeyword.Size = new Size(473, 31);
            tbKeyword.TabIndex = 11;
            tbKeyword.TextChanged += tbKeyword_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(27, 575);
            button1.Name = "button1";
            button1.Size = new Size(473, 34);
            button1.TabIndex = 12;
            button1.Text = "Commands";
            button1.UseVisualStyleBackColor = true;
            button1.Click += bnSettingsCommands_Click;
            // 
            // cbAutostart
            // 
            cbAutostart.AutoSize = true;
            cbAutostart.Location = new Point(27, 461);
            cbAutostart.Name = "cbAutostart";
            cbAutostart.Size = new Size(191, 29);
            cbAutostart.TabIndex = 13;
            cbAutostart.Text = "Start with Windows";
            cbAutostart.UseVisualStyleBackColor = true;
            cbAutostart.CheckedChanged += cbAutostart_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(49, 520);
            label5.Name = "label5";
            label5.Size = new Size(461, 25);
            label5.TabIndex = 15;
            label5.Text = "(The keyword to start recognition is allways \"Computer\").";
            // 
            // cbKeywordDetection
            // 
            cbKeywordDetection.AutoSize = true;
            cbKeywordDetection.Location = new Point(27, 496);
            cbKeywordDetection.Name = "cbKeywordDetection";
            cbKeywordDetection.Size = new Size(487, 29);
            cbKeywordDetection.TabIndex = 14;
            cbKeywordDetection.Text = "Use Windows Speech Recognition for keyword detection";
            cbKeywordDetection.UseVisualStyleBackColor = true;
            cbKeywordDetection.CheckedChanged += cbKeywordDetection_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 376);
            label6.Name = "label6";
            label6.Size = new Size(179, 25);
            label6.TabIndex = 16;
            label6.Text = "Language (in English)";
            // 
            // tbLanguage
            // 
            tbLanguage.Location = new Point(28, 406);
            tbLanguage.Name = "tbLanguage";
            tbLanguage.Size = new Size(472, 31);
            tbLanguage.TabIndex = 17;
            tbLanguage.TextChanged += tbLanguage_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 631);
            Controls.Add(tbLanguage);
            Controls.Add(label6);
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
            Name = "MainForm";
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
        private Label label6;
        private TextBox tbLanguage;
    }
}
