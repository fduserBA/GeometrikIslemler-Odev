using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometrikIslemler_Odev.AlanCevreHesapları;

namespace GeometrikIslemler_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bDaire_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbYariCap.Text))
            {
                MessageBox.Show("Yarı çap alanı boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DaireHesapla daireHesapla = new DaireHesapla();
            lDaire.Text = "Dairenin Alanı: " + daireHesapla.AlanHesapla(Convert.ToDouble(tbYariCap.Text)) + "\n" + "Dairenin Çevresi: " + daireHesapla.CevreHesapla(Convert.ToDouble(tbYariCap.Text));
        }

        private void bKare_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbUzunKenar.Text))
            {
                MessageBox.Show("Kenar uzunluğu alanı boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KareHesap kareHesap = new KareHesap();
            lKare.Text = "Karenin Alanı: " + kareHesap.AlanHesapla(Convert.ToDouble(tbUzunKenar.Text)) + "\n" + "Karenin Çevresi: " + kareHesap.CevreHesapla(Convert.ToDouble(tbUzunKenar.Text));
        }

        private void bDikDortgen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbDUzunKenar.Text))
            {
                MessageBox.Show("Uzun kenar alanı boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(tbDKisaKenar.Text))
            {
                MessageBox.Show("Kısa kenar alanı boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DikDortgenHesap dikDortgenHesap = new DikDortgenHesap();
            lDikDortgen.Text = "Dikdörtgenin Alanı: " + dikDortgenHesap.AlanHesapla(Convert.ToDouble(tbDUzunKenar.Text), Convert.ToDouble(tbDKisaKenar.Text)) + "\n";
            lDikDortgen.Text += "Dikdörtgenin Çevresi: " + dikDortgenHesap.CevreHesapla(Convert.ToDouble(tbDUzunKenar.Text), Convert.ToDouble(tbDKisaKenar.Text));
        }

        private void bEskenarUcgen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbKenar.Text))
            {
                MessageBox.Show("Kenar Uzunluğu alanı boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EsKenarUcgenHesap esKenarUcgenHesap = new EsKenarUcgenHesap();
            lEskenarUcgen.Text = "Eşkenar Üçkenin Alanı: " + esKenarUcgenHesap.AlanHesapla(Convert.ToDouble(tbKenar)) + "\n" + "Eşkenar Üçkenin Çevresi: " + esKenarUcgenHesap.CevreHesapla(Convert.ToDouble(tbKenar));
        }

        private void bDikUcgen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbDDKenar.Text))
            {
                MessageBox.Show("Dik kenar Uzunluğu alanı boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(tbDUKenar.Text))
            {
                MessageBox.Show("Taban kenar Uzunluğu alanı boş bırakılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DikUcgenHesap dikUcgenHesap = new DikUcgenHesap();
            lDikUcgen.Text = "Dik Üçkenin Alanı: " + dikUcgenHesap.AlanHesapla(Convert.ToDouble(tbDDKenar.Text), Convert.ToDouble(tbDUKenar.Text)) + "\n";
            lDikUcgen.Text += "Dik Üçkenin Çevresi: " + dikUcgenHesap.CevreHesapla(Convert.ToDouble(tbDDKenar.Text), Convert.ToDouble(tbDUKenar.Text));
        }
    }
}
