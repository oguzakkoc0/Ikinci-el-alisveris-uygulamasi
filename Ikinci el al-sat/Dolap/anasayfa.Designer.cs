namespace Dolap
{
    partial class AnaSayfa
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnYenile = new System.Windows.Forms.Button();
            this.hesabım = new System.Windows.Forms.LinkLabel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1451, 785);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(1297, 9);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click_1);
            // 
            // hesabım
            // 
            this.hesabım.AutoSize = true;
            this.hesabım.Location = new System.Drawing.Point(1378, 12);
            this.hesabım.Name = "hesabım";
            this.hesabım.Size = new System.Drawing.Size(59, 16);
            this.hesabım.TabIndex = 1;
            this.hesabım.TabStop = true;
            this.hesabım.Text = "hesabım";
            this.hesabım.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hesabım_LinkClicked);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(423, 6);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(478, 22);
            this.txtArama.TabIndex = 0;
            this.txtArama.Text = "Ara";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(922, 5);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(50, 23);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 817);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.hesabım);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.LinkLabel hesabım;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
    }
}