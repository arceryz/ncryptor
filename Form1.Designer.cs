namespace Encryptor
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			loadButton = new System.Windows.Forms.Button();
			openFileDialog = new System.Windows.Forms.OpenFileDialog();
			textBox = new System.Windows.Forms.TextBox();
			saveButton = new System.Windows.Forms.Button();
			decryptButton = new System.Windows.Forms.Button();
			saveAsButton = new System.Windows.Forms.Button();
			encryptButton = new System.Windows.Forms.Button();
			keyTextBox = new System.Windows.Forms.MaskedTextBox();
			label1 = new System.Windows.Forms.Label();
			hideKeyCheckbox = new System.Windows.Forms.CheckBox();
			statusBox = new System.Windows.Forms.GroupBox();
			statusLabel = new System.Windows.Forms.Label();
			saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			logo = new System.Windows.Forms.PictureBox();
			statusBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logo).BeginInit();
			SuspendLayout();
			// 
			// loadButton
			// 
			loadButton.Location = new System.Drawing.Point(12, 12);
			loadButton.Name = "loadButton";
			loadButton.Size = new System.Drawing.Size(53, 29);
			loadButton.TabIndex = 1;
			loadButton.Text = "Load";
			loadButton.UseVisualStyleBackColor = true;
			loadButton.Click += loadButton_Click;
			// 
			// openFileDialog
			// 
			openFileDialog.DefaultExt = "aes";
			openFileDialog.FileName = "openFileDialog";
			openFileDialog.Filter = "AES files (*.aes)|*.aes";
			openFileDialog.Title = "Open File";
			// 
			// textBox
			// 
			textBox.Location = new System.Drawing.Point(12, 80);
			textBox.Multiline = true;
			textBox.Name = "textBox";
			textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			textBox.Size = new System.Drawing.Size(430, 378);
			textBox.TabIndex = 3;
			// 
			// saveButton
			// 
			saveButton.Location = new System.Drawing.Point(71, 12);
			saveButton.Name = "saveButton";
			saveButton.Size = new System.Drawing.Size(54, 29);
			saveButton.TabIndex = 2;
			saveButton.Text = "Save";
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// decryptButton
			// 
			decryptButton.BackColor = System.Drawing.Color.LightGreen;
			decryptButton.Location = new System.Drawing.Point(377, 8);
			decryptButton.Name = "decryptButton";
			decryptButton.Size = new System.Drawing.Size(69, 37);
			decryptButton.TabIndex = 4;
			decryptButton.Text = "Decrypt";
			decryptButton.UseVisualStyleBackColor = false;
			decryptButton.Click += decryptButton_Click;
			// 
			// saveAsButton
			// 
			saveAsButton.Location = new System.Drawing.Point(131, 12);
			saveAsButton.Name = "saveAsButton";
			saveAsButton.Size = new System.Drawing.Size(58, 29);
			saveAsButton.TabIndex = 5;
			saveAsButton.Text = "Save As";
			saveAsButton.UseVisualStyleBackColor = true;
			saveAsButton.Click += saveAsButton_Click;
			// 
			// encryptButton
			// 
			encryptButton.BackColor = System.Drawing.Color.IndianRed;
			encryptButton.Location = new System.Drawing.Point(302, 8);
			encryptButton.Name = "encryptButton";
			encryptButton.Size = new System.Drawing.Size(69, 37);
			encryptButton.TabIndex = 6;
			encryptButton.Text = "Encrypt";
			encryptButton.UseVisualStyleBackColor = false;
			encryptButton.Click += encryptButton_Click;
			// 
			// keyTextBox
			// 
			keyTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			keyTextBox.Location = new System.Drawing.Point(44, 51);
			keyTextBox.Name = "keyTextBox";
			keyTextBox.PasswordChar = '*';
			keyTextBox.Size = new System.Drawing.Size(327, 22);
			keyTextBox.TabIndex = 7;
			keyTextBox.Text = "encryption_key_here";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 54);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(26, 15);
			label1.TabIndex = 8;
			label1.Text = "Key";
			// 
			// hideKeyCheckbox
			// 
			hideKeyCheckbox.AutoSize = true;
			hideKeyCheckbox.Checked = true;
			hideKeyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			hideKeyCheckbox.Location = new System.Drawing.Point(377, 55);
			hideKeyCheckbox.Name = "hideKeyCheckbox";
			hideKeyCheckbox.Size = new System.Drawing.Size(65, 19);
			hideKeyCheckbox.TabIndex = 9;
			hideKeyCheckbox.Text = "Hidden";
			hideKeyCheckbox.UseVisualStyleBackColor = true;
			hideKeyCheckbox.Click += hideKeyCheckbox_Click;
			// 
			// statusBox
			// 
			statusBox.Controls.Add(statusLabel);
			statusBox.Location = new System.Drawing.Point(12, 464);
			statusBox.Name = "statusBox";
			statusBox.Size = new System.Drawing.Size(430, 33);
			statusBox.TabIndex = 11;
			statusBox.TabStop = false;
			statusBox.Text = "Status";
			// 
			// statusLabel
			// 
			statusLabel.AutoSize = true;
			statusLabel.ForeColor = System.Drawing.Color.Green;
			statusLabel.Location = new System.Drawing.Point(6, 15);
			statusLabel.Name = "statusLabel";
			statusLabel.Size = new System.Drawing.Size(39, 15);
			statusLabel.TabIndex = 0;
			statusLabel.Text = "Ready";
			statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// saveFileDialog
			// 
			saveFileDialog.DefaultExt = "aes";
			saveFileDialog.Filter = "AES files (*.aes)|*.aes";
			// 
			// logo
			// 
			logo.Image = (System.Drawing.Image)resources.GetObject("logo.Image");
			logo.Location = new System.Drawing.Point(197, 8);
			logo.Name = "logo";
			logo.Size = new System.Drawing.Size(99, 37);
			logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			logo.TabIndex = 12;
			logo.TabStop = false;
			logo.Click += logo_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(454, 509);
			Controls.Add(logo);
			Controls.Add(statusBox);
			Controls.Add(hideKeyCheckbox);
			Controls.Add(label1);
			Controls.Add(keyTextBox);
			Controls.Add(encryptButton);
			Controls.Add(saveAsButton);
			Controls.Add(decryptButton);
			Controls.Add(textBox);
			Controls.Add(saveButton);
			Controls.Add(loadButton);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "Form1";
			Text = "Ncryptor";
			Load += Form1_Load;
			statusBox.ResumeLayout(false);
			statusBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logo).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button saveAsButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.MaskedTextBox keyTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox hideKeyCheckbox;
		private System.Windows.Forms.GroupBox statusBox;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.PictureBox logo;
	}
}

