namespace ChatApplicationn
{
    partial class kayitolform
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
            this.kayitolbtn2 = new System.Windows.Forms.Button();
            this.kullaniciadilbl = new System.Windows.Forms.Label();
            this.kayitolepostalbl = new System.Windows.Forms.Label();
            this.kayitolsifrelbl = new System.Windows.Forms.Label();
            this.sifretekrarlbl = new System.Windows.Forms.Label();
            this.kullaniciaditxtbox = new System.Windows.Forms.TextBox();
            this.kayitolepostatxtbx = new System.Windows.Forms.TextBox();
            this.kytolsifretxtbox = new System.Windows.Forms.TextBox();
            this.sifretekrartxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kayitolbtn2
            // 
            this.kayitolbtn2.Location = new System.Drawing.Point(175, 339);
            this.kayitolbtn2.Name = "kayitolbtn2";
            this.kayitolbtn2.Size = new System.Drawing.Size(147, 39);
            this.kayitolbtn2.TabIndex = 3;
            this.kayitolbtn2.Text = "Kayıt Ol";
            this.kayitolbtn2.UseVisualStyleBackColor = true;
            this.kayitolbtn2.Click += new System.EventHandler(this.kayitolbtn2_Click);
            // 
            // kullaniciadilbl
            // 
            this.kullaniciadilbl.AutoSize = true;
            this.kullaniciadilbl.Location = new System.Drawing.Point(67, 53);
            this.kullaniciadilbl.Name = "kullaniciadilbl";
            this.kullaniciadilbl.Size = new System.Drawing.Size(79, 16);
            this.kullaniciadilbl.TabIndex = 4;
            this.kullaniciadilbl.Text = "Kullanıcı Adı";
            // 
            // kayitolepostalbl
            // 
            this.kayitolepostalbl.AutoSize = true;
            this.kayitolepostalbl.Location = new System.Drawing.Point(69, 115);
            this.kayitolepostalbl.Name = "kayitolepostalbl";
            this.kayitolepostalbl.Size = new System.Drawing.Size(54, 16);
            this.kayitolepostalbl.TabIndex = 5;
            this.kayitolepostalbl.Text = "E-posta";
            // 
            // kayitolsifrelbl
            // 
            this.kayitolsifrelbl.AutoSize = true;
            this.kayitolsifrelbl.Location = new System.Drawing.Point(69, 181);
            this.kayitolsifrelbl.Name = "kayitolsifrelbl";
            this.kayitolsifrelbl.Size = new System.Drawing.Size(34, 16);
            this.kayitolsifrelbl.TabIndex = 6;
            this.kayitolsifrelbl.Text = "Şifre";
            // 
            // sifretekrarlbl
            // 
            this.sifretekrarlbl.AutoSize = true;
            this.sifretekrarlbl.Location = new System.Drawing.Point(67, 253);
            this.sifretekrarlbl.Name = "sifretekrarlbl";
            this.sifretekrarlbl.Size = new System.Drawing.Size(77, 16);
            this.sifretekrarlbl.TabIndex = 7;
            this.sifretekrarlbl.Text = "Şifre Tekrar";
            // 
            // kullaniciaditxtbox
            // 
            this.kullaniciaditxtbox.Location = new System.Drawing.Point(70, 72);
            this.kullaniciaditxtbox.Name = "kullaniciaditxtbox";
            this.kullaniciaditxtbox.Size = new System.Drawing.Size(343, 22);
            this.kullaniciaditxtbox.TabIndex = 8;
            // 
            // kayitolepostatxtbx
            // 
            this.kayitolepostatxtbx.Location = new System.Drawing.Point(72, 134);
            this.kayitolepostatxtbx.Name = "kayitolepostatxtbx";
            this.kayitolepostatxtbx.Size = new System.Drawing.Size(341, 22);
            this.kayitolepostatxtbx.TabIndex = 9;
            // 
            // kytolsifretxtbox
            // 
            this.kytolsifretxtbox.Location = new System.Drawing.Point(72, 200);
            this.kytolsifretxtbox.Name = "kytolsifretxtbox";
            this.kytolsifretxtbox.Size = new System.Drawing.Size(341, 22);
            this.kytolsifretxtbox.TabIndex = 10;
            // 
            // sifretekrartxtbx
            // 
            this.sifretekrartxtbx.Location = new System.Drawing.Point(70, 272);
            this.sifretekrartxtbx.Name = "sifretekrartxtbx";
            this.sifretekrartxtbx.Size = new System.Drawing.Size(343, 22);
            this.sifretekrartxtbx.TabIndex = 11;
            // 
            // kayitolform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(498, 463);
            this.Controls.Add(this.sifretekrartxtbx);
            this.Controls.Add(this.kytolsifretxtbox);
            this.Controls.Add(this.kayitolepostatxtbx);
            this.Controls.Add(this.kullaniciaditxtbox);
            this.Controls.Add(this.sifretekrarlbl);
            this.Controls.Add(this.kayitolsifrelbl);
            this.Controls.Add(this.kayitolepostalbl);
            this.Controls.Add(this.kullaniciadilbl);
            this.Controls.Add(this.kayitolbtn2);
            this.Name = "kayitolform";
            this.Text = "Kayıt Ol Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitolbtn2;
        private System.Windows.Forms.Label kullaniciadilbl;
        private System.Windows.Forms.Label kayitolepostalbl;
        private System.Windows.Forms.Label kayitolsifrelbl;
        private System.Windows.Forms.Label sifretekrarlbl;
        private System.Windows.Forms.TextBox kullaniciaditxtbox;
        private System.Windows.Forms.TextBox kayitolepostatxtbx;
        private System.Windows.Forms.TextBox kytolsifretxtbox;
        private System.Windows.Forms.TextBox sifretekrartxtbx;
    }
}