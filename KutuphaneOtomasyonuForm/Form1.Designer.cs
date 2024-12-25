namespace KutuphaneOtomasyonuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personelGiristxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreGiris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personelGiristxt
            // 
            this.personelGiristxt.Location = new System.Drawing.Point(77, 158);
            this.personelGiristxt.Name = "personelGiristxt";
            this.personelGiristxt.Size = new System.Drawing.Size(165, 20);
            this.personelGiristxt.TabIndex = 0;
            this.personelGiristxt.TextChanged += new System.EventHandler(this.personelGiristxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 161);
            this.label1.MaximumSize = new System.Drawing.Size(80, 30);
            this.label1.MinimumSize = new System.Drawing.Size(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:";
            
            // 
            // sifreGiris
            // 
            this.sifreGiris.Location = new System.Drawing.Point(77, 184);
            this.sifreGiris.Name = "sifreGiris";
            this.sifreGiris.Size = new System.Drawing.Size(165, 20);
            this.sifreGiris.TabIndex = 2;
            this.sifreGiris.UseSystemPasswordChar = true;
            this.sifreGiris.TextChanged += new System.EventHandler(this.sifreGiris_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GirisButton.Location = new System.Drawing.Point(77, 210);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(165, 29);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(310, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelGiristxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
           
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
    }
}

