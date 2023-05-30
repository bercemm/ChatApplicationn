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
    public partial class kayitolform : Form
    {
        public kayitolform()
        {
            InitializeComponent();
        }

      

        private void kayitolbtn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kayitolepostalbl.Text) || string.IsNullOrEmpty(kayitolsifrelbl.Text))
            {
                MessageBox.Show("email ya da şifre boş olamaz!!", "HATA!");
            }
            if (kayitolsifrelbl.Text != sifretekrarlbl.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor");

            }
            else
                MessageBox.Show("Kayıt Başarılı"," ",MessageBoxButtons.OK);
        }

        private void btnformclosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            girisekraniform girisekran = new girisekraniform();
            girisekran.Show();

        }


    }
}


