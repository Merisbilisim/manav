namespace ornek1
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
            this.btnSebeteEkle = new System.Windows.Forms.Button();
            this.txturunler = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstMeyveler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSebeteEkle
            // 
            this.btnSebeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSebeteEkle.Location = new System.Drawing.Point(36, 112);
            this.btnSebeteEkle.Name = "btnSebeteEkle";
            this.btnSebeteEkle.Size = new System.Drawing.Size(133, 27);
            this.btnSebeteEkle.TabIndex = 0;
            this.btnSebeteEkle.Text = "Sepete Ekle";
            this.btnSebeteEkle.UseVisualStyleBackColor = true;
            this.btnSebeteEkle.Click += new System.EventHandler(this.btnSebeteEkle_Click);
            // 
            // txturunler
            // 
            this.txturunler.Location = new System.Drawing.Point(27, 65);
            this.txturunler.Name = "txturunler";
            this.txturunler.Size = new System.Drawing.Size(164, 20);
            this.txturunler.TabIndex = 1;
            this.txturunler.TextChanged += new System.EventHandler(this.txturunler_TextChanged);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(224, 32);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(179, 290);
            this.lstSepet.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(63, 171);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 35);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstMeyveler
            // 
            this.lstMeyveler.FormattingEnabled = true;
            this.lstMeyveler.Location = new System.Drawing.Point(224, 32);
            this.lstMeyveler.Name = "lstMeyveler";
            this.lstMeyveler.Size = new System.Drawing.Size(179, 290);
            this.lstMeyveler.TabIndex = 2;
            this.lstMeyveler.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(495, 374);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstMeyveler);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.txturunler);
            this.Controls.Add(this.btnSebeteEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSebeteEkle;
        private System.Windows.Forms.TextBox txturunler;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstMeyveler;
    }
}

