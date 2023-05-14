using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Title = "Dosya Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;

                    byte[] hashValue = ComputeSHA256Checksum(openFileDialog.FileName);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        sb.Append(hashValue[i].ToString("X2")); // hexadecimal format
                    }

                    txtSHA256Hash.Text = sb.ToString();
                }
            }
        }

        private byte[] ComputeSHA256Checksum(string fileName)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(fileName))
                {
                    return SHA256.ComputeHash(fileStream);
                }
            }
        }

        private void btnVerifyHash_Click(object sender, EventArgs e)
        {
            if (txtSHA256Hash.Text == txtUserHash.Text)
            {
                lblVerificationResult.Text = "Hash doğrulandı!";
            }
            else
            {
                lblVerificationResult.Text = "Hash doğrulanamadı!";
            }
        }
    }
}
