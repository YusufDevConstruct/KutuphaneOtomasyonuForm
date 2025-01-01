namespace KutuphaneOtomasyonuForm
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.personelGiristxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreGiris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cıkısYapBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personelGiristxt
            // 
            this.personelGiristxt.Location = new System.Drawing.Point(81, 158);
            this.personelGiristxt.Name = "personelGiristxt";
            this.personelGiristxt.Size = new System.Drawing.Size(182, 20);
            this.personelGiristxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 161);
            this.label1.MaximumSize = new System.Drawing.Size(80, 30);
            this.label1.MinimumSize = new System.Drawing.Size(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:";
            // 
            // sifreGiris
            // 
            this.sifreGiris.Location = new System.Drawing.Point(81, 184);
            this.sifreGiris.Name = "sifreGiris";
            this.sifreGiris.Size = new System.Drawing.Size(182, 20);
            this.sifreGiris.TabIndex = 2;
            this.sifreGiris.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GirisButton.Image = ((System.Drawing.Image)(resources.GetObject("GirisButton.Image")));
            this.GirisButton.Location = new System.Drawing.Point(81, 210);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(88, 29);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cıkısYapBtn
            // 
            this.cıkısYapBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cıkısYapBtn.Location = new System.Drawing.Point(175, 210);
            this.cıkısYapBtn.Name = "cıkısYapBtn";
            this.cıkısYapBtn.Size = new System.Drawing.Size(88, 29);
            this.cıkısYapBtn.TabIndex = 6;
            this.cıkısYapBtn.Text = "Çıkış Yap";
            this.cıkısYapBtn.UseVisualStyleBackColor = false;
            this.cıkısYapBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(310, 293);
            this.Controls.Add(this.cıkısYapBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelGiristxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personelGiristxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cıkısYapBtn;
    }
}

