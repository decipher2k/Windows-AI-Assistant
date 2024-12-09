namespace Windows_AI_Assistant.Settings
{
	partial class OllamaSettings
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
			tbModel = new TextBox();
			label2 = new Label();
			tbSystemPrompt = new TextBox();
			bnCancel = new Button();
			bnSave = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(25, 31);
			label1.Name = "label1";
			label1.Size = new Size(63, 25);
			label1.TabIndex = 0;
			label1.Text = "Model";
			// 
			// tbModel
			// 
			tbModel.Location = new Point(25, 59);
			tbModel.Name = "tbModel";
			tbModel.Size = new Size(406, 31);
			tbModel.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(25, 119);
			label2.Name = "label2";
			label2.Size = new Size(134, 25);
			label2.TabIndex = 2;
			label2.Text = "System Prompt";
			// 
			// tbSystemPrompt
			// 
			tbSystemPrompt.Location = new Point(25, 147);
			tbSystemPrompt.Name = "tbSystemPrompt";
			tbSystemPrompt.Size = new Size(406, 31);
			tbSystemPrompt.TabIndex = 3;
			// 
			// bnCancel
			// 
			bnCancel.Location = new Point(319, 231);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new Size(112, 34);
			bnCancel.TabIndex = 4;
			bnCancel.Text = "Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			bnCancel.Click += bnCancel_Click;
			// 
			// bnSave
			// 
			bnSave.Location = new Point(183, 231);
			bnSave.Name = "bnSave";
			bnSave.Size = new Size(112, 34);
			bnSave.TabIndex = 5;
			bnSave.Text = "Save";
			bnSave.UseVisualStyleBackColor = true;
			bnSave.Click += bnSave_Click;
			// 
			// OllamaSettings
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(476, 301);
			Controls.Add(bnSave);
			Controls.Add(bnCancel);
			Controls.Add(tbSystemPrompt);
			Controls.Add(label2);
			Controls.Add(tbModel);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "OllamaSettings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Ollama Settings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbModel;
		private Label label2;
		private TextBox tbSystemPrompt;
		private Button bnCancel;
		private Button bnSave;
	}
}