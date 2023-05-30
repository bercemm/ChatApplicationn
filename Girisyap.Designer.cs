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
            this.girisepostalbl = new System.Windows.Forms.Label();
            this.girissifrelbl = new System.Windows.Forms.Label();
            this.girisepostatextbox = new System.Windows.Forms.TextBox();
            this.girissifretextbox = new System.Windows.Forms.TextBox();
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
            // girisepostalbl
            // 
            this.girisepostalbl.AutoSize = true;
            this.girisepostalbl.Location = new System.Drawing.Point(138, 55);
            this.girisepostalbl.Name = "girisepostalbl";
            this.girisepostalbl.Size = new System.Drawing.Size(54, 16);
            this.girisepostalbl.TabIndex = 2;
            this.girisepostalbl.Text = "E-posta";
            // 
            // girissifrelbl
            // 
            this.girissifrelbl.AutoSize = true;
            this.girissifrelbl.Location = new System.Drawing.Point(138, 123);
            this.girissifrelbl.Name = "girissifrelbl";
            this.girissifrelbl.Size = new System.Drawing.Size(34, 16);
            this.girissifrelbl.TabIndex = 3;
            this.girissifrelbl.Text = "Şifre";
            // 
            // girisepostatextbox
            // 
            this.girisepostatextbox.Location = new System.Drawing.Point(141, 84);
            this.girisepostatextbox.Name = "girisepostatextbox";
            this.girisepostatextbox.Size = new System.Drawing.Size(199, 22);
            this.girisepostatextbox.TabIndex = 4;
            // 
            // girissifretextbox
            // 
            this.girissifretextbox.Location = new System.Drawing.Point(141, 155);
            this.girissifretextbox.Name = "girissifretextbox";
            this.girissifretextbox.Size = new System.Drawing.Size(199, 22);
            this.girissifretextbox.TabIndex = 5;
            // 
            // girisekraniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(485, 437);
            this.Controls.Add(this.girissifretextbox);
            this.Controls.Add(this.girisepostatextbox);
            this.Controls.Add(this.girissifrelbl);
            this.Controls.Add(this.girisepostalbl);
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
        private System.Windows.Forms.Label girisepostalbl;
        private System.Windows.Forms.Label girissifrelbl;
        private System.Windows.Forms.TextBox girisepostatextbox;
        private System.Windows.Forms.TextBox girissifretextbox;
    }
}

