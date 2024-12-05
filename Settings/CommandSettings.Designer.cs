namespace Windows_AI_Assistant.Settings
{
	partial class CommandSettings
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
			components = new System.ComponentModel.Container();
			dgProgram = new DataGridView();
			clmnType = new DataGridViewComboBoxColumn();
			clmnToken = new DataGridViewTextBoxColumn();
			clmnProgram = new DataGridViewTextBoxColumn();
			clmnParameter = new DataGridViewTextBoxColumn();
			settingsBindingSource = new BindingSource(components);
			label1 = new Label();
			label2 = new Label();
			dgWebhook = new DataGridView();
			dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			clmnGetPost = new DataGridViewComboBoxColumn();
			clmnHTTPParameter = new DataGridViewTextBoxColumn();
			bnSave = new Button();
			bnCancel = new Button();
			((System.ComponentModel.ISupportInitialize)dgProgram).BeginInit();
			((System.ComponentModel.ISupportInitialize)settingsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgWebhook).BeginInit();
			SuspendLayout();
			// 
			// dgProgram
			// 
			dgProgram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgProgram.Columns.AddRange(new DataGridViewColumn[] { clmnType, clmnToken, clmnProgram, clmnParameter });
			dgProgram.Location = new Point(55, 76);
			dgProgram.Name = "dgProgram";
			dgProgram.RowHeadersWidth = 62;
			dgProgram.Size = new Size(816, 225);
			dgProgram.TabIndex = 0;
			// 
			// clmnType
			// 
			clmnType.HeaderText = "Type";
			clmnType.Items.AddRange(new object[] { "Voice Recognition", "AI Chat" });
			clmnType.MinimumWidth = 8;
			clmnType.Name = "clmnType";
			clmnType.Width = 150;
			// 
			// clmnToken
			// 
			clmnToken.HeaderText = "Token to listen for";
			clmnToken.MinimumWidth = 8;
			clmnToken.Name = "clmnToken";
			clmnToken.Width = 150;
			// 
			// clmnProgram
			// 
			clmnProgram.HeaderText = "Program";
			clmnProgram.MinimumWidth = 8;
			clmnProgram.Name = "clmnProgram";
			clmnProgram.Width = 150;
			// 
			// clmnParameter
			// 
			clmnParameter.HeaderText = "Parameter";
			clmnParameter.MinimumWidth = 8;
			clmnParameter.Name = "clmnParameter";
			clmnParameter.Width = 150;
			// 
			// settingsBindingSource
			// 
			settingsBindingSource.DataSource = typeof(Data.Settings);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(55, 28);
			label1.Name = "label1";
			label1.Size = new Size(645, 25);
			label1.TabIndex = 1;
			label1.Text = "Start Program (use [TEXT] to define a variable for the said text in the parameters)";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(55, 371);
			label2.Name = "label2";
			label2.Size = new Size(612, 25);
			label2.TabIndex = 2;
			label2.Text = "Webhook (use [TEXT] to define a variable for the said text in the parameters)";
			// 
			// dgWebhook
			// 
			dgWebhook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgWebhook.Columns.AddRange(new DataGridViewColumn[] { dataGridViewComboBoxColumn1, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, clmnGetPost, clmnHTTPParameter });
			dgWebhook.Location = new Point(55, 419);
			dgWebhook.Name = "dgWebhook";
			dgWebhook.RowHeadersWidth = 62;
			dgWebhook.Size = new Size(816, 225);
			dgWebhook.TabIndex = 3;
			// 
			// dataGridViewComboBoxColumn1
			// 
			dataGridViewComboBoxColumn1.HeaderText = "Type";
			dataGridViewComboBoxColumn1.Items.AddRange(new object[] { "Voice Recognition", "AI Chat" });
			dataGridViewComboBoxColumn1.MinimumWidth = 8;
			dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
			dataGridViewComboBoxColumn1.Width = 150;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "Token to listen for";
			dataGridViewTextBoxColumn1.MinimumWidth = 8;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.Width = 150;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.HeaderText = "URL";
			dataGridViewTextBoxColumn2.MinimumWidth = 8;
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.Width = 150;
			// 
			// clmnGetPost
			// 
			clmnGetPost.HeaderText = "GET/POST";
			clmnGetPost.Items.AddRange(new object[] { "GET", "POST" });
			clmnGetPost.MinimumWidth = 8;
			clmnGetPost.Name = "clmnGetPost";
			clmnGetPost.Width = 150;
			// 
			// clmnHTTPParameter
			// 
			clmnHTTPParameter.HeaderText = "Parameter";
			clmnHTTPParameter.MinimumWidth = 8;
			clmnHTTPParameter.Name = "clmnHTTPParameter";
			clmnHTTPParameter.Width = 150;
			// 
			// bnSave
			// 
			bnSave.Location = new Point(627, 684);
			bnSave.Name = "bnSave";
			bnSave.Size = new Size(112, 34);
			bnSave.TabIndex = 4;
			bnSave.Text = "Save";
			bnSave.UseVisualStyleBackColor = true;
			bnSave.Click += bnSave_Click;
			// 
			// bnCancel
			// 
			bnCancel.Location = new Point(759, 684);
			bnCancel.Name = "bnCancel";
			bnCancel.Size = new Size(112, 34);
			bnCancel.TabIndex = 5;
			bnCancel.Text = "Cancel";
			bnCancel.UseVisualStyleBackColor = true;
			bnCancel.Click += bnCancel_Click;
			// 
			// CommandSettings
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(932, 762);
			Controls.Add(bnCancel);
			Controls.Add(bnSave);
			Controls.Add(dgWebhook);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgProgram);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "CommandSettings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Command Settings";
			((System.ComponentModel.ISupportInitialize)dgProgram).EndInit();
			((System.ComponentModel.ISupportInitialize)settingsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)dgWebhook).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgProgram;
		private BindingSource settingsBindingSource;
		private DataGridViewComboBoxColumn clmnType;
		private DataGridViewTextBoxColumn clmnToken;
		private DataGridViewTextBoxColumn clmnProgram;
		private DataGridViewTextBoxColumn clmnParameter;
		private Label label1;
		private Label label2;
		private DataGridView dgWebhook;
		private Button bnSave;
		private Button bnCancel;
		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewComboBoxColumn clmnGetPost;
		private DataGridViewTextBoxColumn clmnHTTPParameter;
	}
}