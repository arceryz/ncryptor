using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Encryptor
{
	public partial class Form1 : Form
	{
		string activeFile = string.Empty;

		public Form1()
		{
			InitializeComponent();
			string[] args = Environment.GetCommandLineArgs();
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i].EndsWith(".aes"))
				{
					LoadFile(args[i]);
					break;
				}
			}
		}

		private void SetTitle()
		{
			Text = "Ncryptor - " + Path.GetFileName(activeFile);
		}

		private void SetStatus(string message)
		{
			statusLabel.Text = message;
			statusLabel.ForeColor = Color.Green;
		}

		private void SetError(string message)
		{
			statusLabel.Text = "ERR " + message;
			statusLabel.ForeColor = Color.Red;
		}

		// Saving and Loading files
		private void LoadFile(string file)
		{
			if (!File.Exists(file))
			{
				SetError("File does not exist: " + Path.GetFileName(file));
				return;
			}
			if (!file.EndsWith(".aes"))
			{
				SetError("Not an AES file: " + Path.GetFileName(file));
				return;
			}
			activeFile = file;
			StreamReader reader = new StreamReader(activeFile);
			textBox.Text = reader.ReadToEnd();
			reader.Close();
			SetTitle();
			SetStatus("Loaded " + Path.GetFileName(activeFile));
		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				LoadFile(openFileDialog.FileName);
			}
		}

		private void SaveFile()
		{
			StreamWriter writer = new StreamWriter(activeFile);
			writer.Write(textBox.Text);
			writer.Close();
			SetStatus("Saved to " + Path.GetFileName(activeFile));
			SetTitle();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (!File.Exists(activeFile))
			{
				if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
				activeFile = saveFileDialog.FileName;
			}
			SaveFile();
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
			activeFile = saveFileDialog.FileName;
			SaveFile();
		}

		// Other UI interactions
		private void hideKeyCheckbox_Click(object sender, EventArgs e)
		{
			keyTextBox.PasswordChar = hideKeyCheckbox.Checked ? '*' : '\0';
		}

		// Encryption and Decryption
		private void decryptButton_Click(object sender, EventArgs e)
		{
			SHA256 sha = SHA256.Create();
			Aes aes = Aes.Create();
			aes.Key = sha.ComputeHash(Encoding.UTF8.GetBytes(keyTextBox.Text));

			byte[] combined;
			try
			{
				combined = Convert.FromBase64String(textBox.Text);
			}
			catch (FormatException)
			{
				SetError("Invalid Base64 string");
				return;
			}
			if (combined.Length < 16)
			{
				SetError("Not a valid encrypted message");
				return;
			}

			byte[] iv = new byte[16];
			byte[] data = new byte[combined.Length - 16];
			Buffer.BlockCopy(combined, 0, iv, 0, 16);
			Buffer.BlockCopy(combined, 16, data, 0, data.Length);

			byte[] decrypted;
			try
			{
				decrypted = aes.DecryptCbc(data, iv);
			}
			catch (CryptographicException)
			{
				SetError("Data/key mismatch");
				return;
			}

			textBox.Text = Encoding.UTF8.GetString(decrypted);
			SetStatus($"Decrypted {decrypted.Length} bytes");
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			SHA256 sha = SHA256.Create();
			Aes aes = Aes.Create();
			aes.Key = sha.ComputeHash(Encoding.UTF8.GetBytes(keyTextBox.Text));
			aes.GenerateIV();

			byte[] data = Encoding.UTF8.GetBytes(textBox.Text);
			byte[] encrypted = aes.EncryptCbc(data, aes.IV);

			byte[] combined = new byte[16 + encrypted.Length];
			Buffer.BlockCopy(aes.IV, 0, combined, 0, 16);
			Buffer.BlockCopy(encrypted, 0, combined, 16, encrypted.Length);

			textBox.Text = Convert.ToBase64String(combined);
			SetStatus($"Encrypted {data.Length} bytes");
		}

		private void logo_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
