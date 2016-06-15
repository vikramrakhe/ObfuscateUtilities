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
            this.btnGenHandles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enStringHandlePB = new System.Windows.Forms.ProgressBar();
            this.deStringHandlePB = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(10, 134);
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
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Taken to Generate String Handles";
            // 
            // txtOriginalStr
            // 
            this.txtOriginalStr.Location = new System.Drawing.Point(206, 14);
            this.txtOriginalStr.Name = "txtOriginalStr";
            this.txtOriginalStr.Size = new System.Drawing.Size(84, 20);
            this.txtOriginalStr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time to Encrypt String Handles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time to Decrypt String Handles";
            // 
            // txtEncryptedStr
            // 
            this.txtEncryptedStr.Location = new System.Drawing.Point(204, 6);
            this.txtEncryptedStr.Name = "txtEncryptedStr";
            this.txtEncryptedStr.Size = new System.Drawing.Size(84, 20);
            this.txtEncryptedStr.TabIndex = 5;
            // 
            // txtDecryptedStr
            // 
            this.txtDecryptedStr.Location = new System.Drawing.Point(204, 46);
            this.txtDecryptedStr.Name = "txtDecryptedStr";
            this.txtDecryptedStr.Size = new System.Drawing.Size(84, 20);
            this.txtDecryptedStr.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encrypted String Handle Size";
            // 
            // txtTimeTaken
            // 
            this.txtTimeTaken.Location = new System.Drawing.Point(204, 88);
            this.txtTimeTaken.Name = "txtTimeTaken";
            this.txtTimeTaken.Size = new System.Drawing.Size(84, 20);
            this.txtTimeTaken.TabIndex = 8;
            // 
            // btnCCASCII
            // 
            this.btnCCASCII.Location = new System.Drawing.Point(114, 133);
            this.btnCCASCII.Name = "btnCCASCII";
            this.btnCCASCII.Size = new System.Drawing.Size(171, 23);
            this.btnCCASCII.TabIndex = 9;
            this.btnCCASCII.Text = "Caesar Cipher ASCII";
            this.btnCCASCII.UseVisualStyleBackColor = true;
            this.btnCCASCII.Click += new System.EventHandler(this.btnCCASCII_Click);
            // 
            // btnCCUTF8
            // 
            this.btnCCUTF8.Location = new System.Drawing.Point(291, 134);
            this.btnCCUTF8.Name = "btnCCUTF8";
            this.btnCCUTF8.Size = new System.Drawing.Size(171, 23);
            this.btnCCUTF8.TabIndex = 10;
            this.btnCCUTF8.Text = "Caesar Cipher UTF8";
            this.btnCCUTF8.UseVisualStyleBackColor = true;
            this.btnCCUTF8.Click += new System.EventHandler(this.btnCCUTF8_Click);
            // 
            // btnGenHandles
            // 
            this.btnGenHandles.Location = new System.Drawing.Point(328, 11);
            this.btnGenHandles.Name = "btnGenHandles";
            this.btnGenHandles.Size = new System.Drawing.Size(135, 38);
            this.btnGenHandles.TabIndex = 11;
            this.btnGenHandles.Text = "Generate String Handles";
            this.btnGenHandles.UseVisualStyleBackColor = true;
            this.btnGenHandles.Click += new System.EventHandler(this.btnGenHandles_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenHandles);
            this.panel1.Controls.Add(this.txtOriginalStr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 60);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.deStringHandlePB);
            this.panel2.Controls.Add(this.enStringHandlePB);
            this.panel2.Controls.Add(this.btnCCUTF8);
            this.panel2.Controls.Add(this.btnCCASCII);
            this.panel2.Controls.Add(this.txtTimeTaken);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDecryptedStr);
            this.panel2.Controls.Add(this.txtEncryptedStr);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAES);
            this.panel2.Location = new System.Drawing.Point(13, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 168);
            this.panel2.TabIndex = 13;
            // 
            // enStringHandlePB
            // 
            this.enStringHandlePB.Location = new System.Drawing.Point(303, 13);
            this.enStringHandlePB.Maximum = 10000000;
            this.enStringHandlePB.Name = "enStringHandlePB";
            this.enStringHandlePB.Size = new System.Drawing.Size(159, 19);
            this.enStringHandlePB.Step = 1;
            this.enStringHandlePB.TabIndex = 11;
            // 
            // deStringHandlePB
            // 
            this.deStringHandlePB.Location = new System.Drawing.Point(303, 47);
            this.deStringHandlePB.Maximum = 10000000;
            this.deStringHandlePB.Name = "deStringHandlePB";
            this.deStringHandlePB.Size = new System.Drawing.Size(159, 19);
            this.deStringHandlePB.Step = 1;
            this.deStringHandlePB.TabIndex = 12;
            // 
            // ObfuscateUtilityApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 270);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ObfuscateUtilityApplication";
            this.Text = "ObfuscateUtilityApplication";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnGenHandles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar deStringHandlePB;
        private System.Windows.Forms.ProgressBar enStringHandlePB;
    }
}

