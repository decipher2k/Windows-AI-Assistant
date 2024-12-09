
namespace Windows_AI_Assistant.Settings
{
	partial class AwanSettings
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
			tbAPIKey = new TextBox();
			label1 = new Label();
			cbModel = new ComboBox();
			label2 = new Label();
			SuspendLayout();
			// 
			// bnSave
			// 
			bnSave.Location = new Point(189, 215);
			bnSave.Name = "bnSave";
			bnSave.Size = new Size(112, 34);
			bnSave.TabIndex = 17;
			bnSave.Text = "Save";
			bnSave.UseVisualStyleBackColor = true;
			bnSave.Click += bnSave_Click;
			// 
			// bnCancel
			// 
			bnCancel.Location = new Point(325, 215);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new Size(112, 34);
			bnCancel.TabIndex = 16;
			bnCancel.Text = "Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			bnCancel.Click += bnCancel_Click;
			// 
			// tbAPIKey
			// 
			tbAPIKey.Location = new Point(31, 52);
			tbAPIKey.Name = "tbAPIKey";
			tbAPIKey.Size = new Size(406, 31);
			tbAPIKey.TabIndex = 13;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(31, 24);
			label1.Name = "label1";
			label1.Size = new Size(72, 25);
			label1.TabIndex = 12;
			label1.Text = "API Key";
			// 
			// cbModel
			// 
			cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
			cbModel.FormattingEnabled = true;
			cbModel.Items.AddRange(new object[] { "Meta-Llama-3.1-70B-Instruct", "Meta-Llama-3-8B-Instruct" });
			cbModel.Location = new Point(31, 127);
			cbModel.Name = "cbModel";
			cbModel.Size = new Size(406, 33);
			cbModel.TabIndex = 18;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(31, 99);
			label2.Name = "label2";
			label2.Size = new Size(261, 25);
			label2.TabIndex = 19;
			label2.Text = "AI Model (8B is faster than 70B)";
			// 
			// AwanSettings
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(478, 296);
			Controls.Add(label2);
			Controls.Add(cbModel);
			Controls.Add(bnSave);
			Controls.Add(bnCancel);
			Controls.Add(tbAPIKey);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "AwanSettings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Awan Settings";
			Load += OllamaSettings_Load;
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion

		private Button bnSave;
		private Button bnCancel;
		private TextBox tbAPIKey;
		private Label label1;
		private ComboBox cbModel;
		private Label label2;
	}
}