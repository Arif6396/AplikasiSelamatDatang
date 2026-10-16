namespace AplikasiSelamatDatang
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
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.btnKeterangan1 = new System.Windows.Forms.Button();
            this.btnKeterangan2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.ForeColor = System.Drawing.Color.Red;
            this.lblKeterangan.Location = new System.Drawing.Point(90, 67);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(300, 20);
            this.lblKeterangan.TabIndex = 0;
            this.lblKeterangan.Text = "Selamat Datang di pemrograman C#";
            this.lblKeterangan.Click += new System.EventHandler(this.lblKeterangan_Click);
            // 
            // btnKeterangan1
            // 
            this.btnKeterangan1.Location = new System.Drawing.Point(114, 126);
            this.btnKeterangan1.Name = "btnKeterangan1";
            this.btnKeterangan1.Size = new System.Drawing.Size(89, 23);
            this.btnKeterangan1.TabIndex = 1;
            this.btnKeterangan1.Text = "Keterangan 1";
            this.btnKeterangan1.UseVisualStyleBackColor = true;
            this.btnKeterangan1.Click += new System.EventHandler(this.btnKeterangan1_Click);
            // 
            // btnKeterangan2
            // 
            this.btnKeterangan2.Location = new System.Drawing.Point(274, 126);
            this.btnKeterangan2.Name = "btnKeterangan2";
            this.btnKeterangan2.Size = new System.Drawing.Size(90, 23);
            this.btnKeterangan2.TabIndex = 2;
            this.btnKeterangan2.Text = "Keterangan 2";
            this.btnKeterangan2.UseVisualStyleBackColor = true;
            this.btnKeterangan2.Click += new System.EventHandler(this.btnKeterangan2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 452);
            this.Controls.Add(this.btnKeterangan2);
            this.Controls.Add(this.btnKeterangan1);
            this.Controls.Add(this.lblKeterangan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Button btnKeterangan1;
        private System.Windows.Forms.Button btnKeterangan2;
    }
}

