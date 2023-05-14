namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtSHA256Hash = new System.Windows.Forms.TextBox();
            this.btnVerifyHash = new System.Windows.Forms.Button();
            this.txtUserHash = new System.Windows.Forms.TextBox();
            this.lblVerificationResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(82, 112);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(197, 88);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Dosya Seç";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(121, 232);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(539, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // txtSHA256Hash
            // 
            this.txtSHA256Hash.Location = new System.Drawing.Point(22, 296);
            this.txtSHA256Hash.Multiline = true;
            this.txtSHA256Hash.Name = "txtSHA256Hash";
            this.txtSHA256Hash.Size = new System.Drawing.Size(755, 30);
            this.txtSHA256Hash.TabIndex = 2;
            // 
            // btnVerifyHash
            // 
            this.btnVerifyHash.Location = new System.Drawing.Point(528, 112);
            this.btnVerifyHash.Name = "btnVerifyHash";
            this.btnVerifyHash.Size = new System.Drawing.Size(179, 88);
            this.btnVerifyHash.TabIndex = 3;
            this.btnVerifyHash.Text = "Hash Doğrulama";
            this.btnVerifyHash.UseVisualStyleBackColor = true;
            this.btnVerifyHash.Click += new System.EventHandler(this.btnVerifyHash_Click);
            // 
            // txtUserHash
            // 
            this.txtUserHash.Location = new System.Drawing.Point(22, 375);
            this.txtUserHash.Multiline = true;
            this.txtUserHash.Name = "txtUserHash";
            this.txtUserHash.Size = new System.Drawing.Size(755, 29);
            this.txtUserHash.TabIndex = 4;
            // 
            // lblVerificationResult
            // 
            this.lblVerificationResult.AutoSize = true;
            this.lblVerificationResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVerificationResult.Location = new System.Drawing.Point(339, 62);
            this.lblVerificationResult.Name = "lblVerificationResult";
            this.lblVerificationResult.Size = new System.Drawing.Size(133, 13);
            this.lblVerificationResult.TabIndex = 5;
            this.lblVerificationResult.Text = "Hash Karşılaştırma Sonucu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVerificationResult);
            this.Controls.Add(this.txtUserHash);
            this.Controls.Add(this.btnVerifyHash);
            this.Controls.Add(this.txtSHA256Hash);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtSHA256Hash;
        private System.Windows.Forms.Button btnVerifyHash;
        private System.Windows.Forms.TextBox txtUserHash;
        private System.Windows.Forms.Label lblVerificationResult;
    }
}

