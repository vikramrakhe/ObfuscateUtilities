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
            this.btnCCASCII = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SourceHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncryptedHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enHandleBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecryptedHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeHandleBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCCASCII
            // 
            this.btnCCASCII.Location = new System.Drawing.Point(692, 305);
            this.btnCCASCII.Name = "btnCCASCII";
            this.btnCCASCII.Size = new System.Drawing.Size(171, 23);
            this.btnCCASCII.TabIndex = 9;
            this.btnCCASCII.Text = "Caesar Cipher ByteBased";
            this.btnCCASCII.UseVisualStyleBackColor = true;
            this.btnCCASCII.Click += new System.EventHandler(this.btnCCASCII_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnCCASCII);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1455, 337);
            this.panel2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SourceHandle,
            this.SourceBytes,
            this.EncryptedHandle,
            this.enHandleBytes,
            this.DecryptedHandle,
            this.DeHandleBytes});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1447, 283);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SourceHandle
            // 
            this.SourceHandle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SourceHandle.HeaderText = "SourceHandle";
            this.SourceHandle.Name = "SourceHandle";
            // 
            // SourceBytes
            // 
            this.SourceBytes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SourceBytes.HeaderText = "SourceBytes";
            this.SourceBytes.Name = "SourceBytes";
            this.SourceBytes.Width = 92;
            // 
            // EncryptedHandle
            // 
            this.EncryptedHandle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EncryptedHandle.HeaderText = "EncryptedHandle";
            this.EncryptedHandle.Name = "EncryptedHandle";
            this.EncryptedHandle.Width = 114;
            // 
            // enHandleBytes
            // 
            this.enHandleBytes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.enHandleBytes.HeaderText = "enHandleBytes";
            this.enHandleBytes.Name = "enHandleBytes";
            this.enHandleBytes.Width = 104;
            // 
            // DecryptedHandle
            // 
            this.DecryptedHandle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DecryptedHandle.HeaderText = "DecryptedHandle";
            this.DecryptedHandle.Name = "DecryptedHandle";
            this.DecryptedHandle.Width = 115;
            // 
            // DeHandleBytes
            // 
            this.DeHandleBytes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DeHandleBytes.HeaderText = "DeHandleBytes";
            this.DeHandleBytes.Name = "DeHandleBytes";
            this.DeHandleBytes.Width = 106;
            // 
            // ObfuscateUtilityApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 353);
            this.Controls.Add(this.panel2);
            this.Name = "ObfuscateUtilityApplication";
            this.Text = "ObfuscateUtilityApplication";
            this.Load += new System.EventHandler(this.ObfuscateUtilityApplication_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCCASCII;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncryptedHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn enHandleBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecryptedHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeHandleBytes;
    }
}

