namespace ChatApplicationn
{
    partial class girisekraniform
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
            this.girisyapbtn = new System.Windows.Forms.Button();
            this.kayitolbtn = new System.Windows.Forms.Button();
            this.epostalbl = new System.Windows.Forms.Label();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.epostatextbox = new System.Windows.Forms.TextBox();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girisyapbtn
            // 
            this.girisyapbtn.Location = new System.Drawing.Point(168, 218);
            this.girisyapbtn.Name = "girisyapbtn";
            this.girisyapbtn.Size = new System.Drawing.Size(147, 39);
            this.girisyapbtn.TabIndex = 0;
            this.girisyapbtn.Text = "Giriş Yap";
            this.girisyapbtn.UseVisualStyleBackColor = true;
            this.girisyapbtn.Click += new System.EventHandler(this.girisyapbtn_Click);
            // 
            // kayitolbtn
            // 
            this.kayitolbtn.Location = new System.Drawing.Point(168, 292);
            this.kayitolbtn.Name = "kayitolbtn";
            this.kayitolbtn.Size = new System.Drawing.Size(147, 39);
            this.kayitolbtn.TabIndex = 1;
            this.kayitolbtn.Text = "Kayıt Ol";
            this.kayitolbtn.UseVisualStyleBackColor = true;
            this.kayitolbtn.Click += new System.EventHandler(this.kayitolbtn_Click);
            // 
            // epostalbl
            // 
            this.epostalbl.AutoSize = true;
            this.epostalbl.Location = new System.Drawing.Point(138, 55);
            this.epostalbl.Name = "epostalbl";
            this.epostalbl.Size = new System.Drawing.Size(54, 16);
            this.epostalbl.TabIndex = 2;
            this.epostalbl.Text = "E-posta";
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.Location = new System.Drawing.Point(138, 123);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(34, 16);
            this.sifrelbl.TabIndex = 3;
            this.sifrelbl.Text = "Şifre";
            // 
            // epostatextbox
            // 
            this.epostatextbox.Location = new System.Drawing.Point(141, 84);
            this.epostatextbox.Name = "epostatextbox";
            this.epostatextbox.Size = new System.Drawing.Size(199, 22);
            this.epostatextbox.TabIndex = 4;
            // 
            // sifretextbox
            // 
            this.sifretextbox.Location = new System.Drawing.Point(141, 155);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.Size = new System.Drawing.Size(199, 22);
            this.sifretextbox.TabIndex = 5;
            // 
            // girisekraniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(485, 437);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.epostatextbox);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.epostalbl);
            this.Controls.Add(this.kayitolbtn);
            this.Controls.Add(this.girisyapbtn);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "girisekraniform";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisyapbtn;
        private System.Windows.Forms.Button kayitolbtn;
        private System.Windows.Forms.Label epostalbl;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.TextBox epostatextbox;
        private System.Windows.Forms.TextBox sifretextbox;
    }
}

