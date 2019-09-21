using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToplamaIslemi
{
    public partial class ToplamaForm : Form
    {
        public ToplamaForm()
        {
            InitializeComponent();
        }

        private void LogYaz(string mesaj)
        {
            lvLog.Items.Add(mesaj);
        }

        int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        void EkranAyarla(bool toplamBasarili = false)
        {
            if (!toplamBasarili)
                txtBirinciSayi.Text = txtIkinciSayi.Text = txtSonuc.Text = "0";
            txtBirinciSayi.Focus();
        }

        bool DogruMu()
        {
            try
            {
                Convert.ToInt32(txtBirinciSayi.Text);
                Convert.ToInt32(txtIkinciSayi.Text);
                return true;
            }
            catch (Exception e)
            {
                LogYaz("Toplama İşlemi Başarısız: " + e.Message);
                return false;
            }
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            bool dogrulamaSonucu = DogruMu();
            if (dogrulamaSonucu)
            {
                int toplam = Topla(Convert.ToInt32(txtBirinciSayi.Text), Convert.ToInt32(txtIkinciSayi.Text));
                txtSonuc.Text = toplam.ToString();
                LogYaz("Toplama İşlemi Başarılı: " + txtSonuc.Text);

            }
            else
            {
                MessageBox.Show("Girdiğiniz değerler hatalı!");
            }
            EkranAyarla(dogrulamaSonucu);
        }

        private void ToplamaForm_Shown(object sender, EventArgs e)
        {
            EkranAyarla();
        }

        private void TxtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void TxtIkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            tabGenel.SelectedTab = tabLoglama;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            lvLog.Items.Clear();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            tabGenel.SelectedTab = tabToplama;
        }

        private void TxtBirinciSayi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
