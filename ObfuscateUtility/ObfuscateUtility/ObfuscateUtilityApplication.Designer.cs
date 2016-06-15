namespace ObfuscateUtility
{
    partial class ObfuscateUtilityApplication
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
            this.btnAES = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncryptedStr = new System.Windows.Forms.TextBox();
            this.txtDecryptedStr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeTaken = new System.Windows.Forms.TextBox();
            this.btnCCASCII = new System.Windows.Forms.Button();
            this.btnCCUTF8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(87, 226);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(75, 23);
            this.btnAES.TabIndex = 0;
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original String";
            // 
            // txtOriginalStr
            // 
            this.txtOriginalStr.Location = new System.Drawing.Point(250, 62);
            this.txtOriginalStr.Name = "txtOriginalStr";
            this.txtOriginalStr.Size = new System.Drawing.Size(175, 20);
            this.txtOriginalStr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypted String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypted String";
            // 
            // txtEncryptedStr
            // 
            this.txtEncryptedStr.Location = new System.Drawing.Point(250, 100);
            this.txtEncryptedStr.Name = "txtEncryptedStr";
            this.txtEncryptedStr.Size = new System.Drawing.Size(175, 20);
            this.txtEncryptedStr.TabIndex = 5;
            // 
            // txtDecryptedStr
            // 
            this.txtDecryptedStr.Location = new System.Drawing.Point(250, 139);
            this.txtDecryptedStr.Name = "txtDecryptedStr";
            this.txtDecryptedStr.Size = new System.Drawing.Size(175, 20);
            this.txtDecryptedStr.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time Taken";
            // 
            // txtTimeTaken
            // 
            this.txtTimeTaken.Location = new System.Drawing.Point(250, 180);
            this.txtTimeTaken.Name = "txtTimeTaken";
            this.txtTimeTaken.Size = new System.Drawing.Size(174, 20);
            this.txtTimeTaken.TabIndex = 8;
            // 
            // btnCCASCII
            // 
            this.btnCCASCII.Location = new System.Drawing.Point(206, 226);
            this.btnCCASCII.Name = "btnCCASCII";
            this.btnCCASCII.Size = new System.Drawing.Size(171, 23);
            this.btnCCASCII.TabIndex = 9;
            this.btnCCASCII.Text = "Caesar Cipher ASCII";
            this.btnCCASCII.UseVisualStyleBackColor = true;
            this.btnCCASCII.Click += new System.EventHandler(this.btnCCASCII_Click);
            // 
            // btnCCUTF8
            // 
            this.btnCCUTF8.Location = new System.Drawing.Point(425, 226);
            this.btnCCUTF8.Name = "btnCCUTF8";
            this.btnCCUTF8.Size = new System.Drawing.Size(171, 23);
            this.btnCCUTF8.TabIndex = 10;
            this.btnCCUTF8.Text = "Caesar Cipher UTF8";
            this.btnCCUTF8.UseVisualStyleBackColor = true;
            this.btnCCUTF8.Click += new System.EventHandler(this.btnCCUTF8_Click);
            // 
            // ObfuscateUtilityApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 318);
            this.Controls.Add(this.btnCCUTF8);
            this.Controls.Add(this.btnCCASCII);
            this.Controls.Add(this.txtTimeTaken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDecryptedStr);
            this.Controls.Add(this.txtEncryptedStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOriginalStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAES);
            this.Name = "ObfuscateUtilityApplication";
            this.Text = "ObfuscateUtilityApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncryptedStr;
        private System.Windows.Forms.TextBox txtDecryptedStr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeTaken;
        private System.Windows.Forms.Button btnCCASCII;
        private System.Windows.Forms.Button btnCCUTF8;
    }
}

