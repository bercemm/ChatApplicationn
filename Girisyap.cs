using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplicationn
{
    public partial class girisekraniform : Form
    {
        public girisekraniform()
        {
            InitializeComponent();
        }

        private void girisyapbtn_Click(object sender, EventArgs e)
        {
            string kullaniciadi = girisepostatextbox.Text;
            string sifre = girissifretextbox.Text;


            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Giris yapilamadi", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Giriş Başarılı", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();

            }


        }

        private void kayitolbtn_Click(object sender, EventArgs e)
        {
            kayitolform kayitolsayfasi = new kayitolform();
            kayitolsayfasi.Show(); //kayıt ol butonuna tıklandıgında kayıt ol ekranını açar.
            this.Hide(); //kayıt ekranı çıktığında logini gizler.this=logini temsil eder
        }
    }
    }

