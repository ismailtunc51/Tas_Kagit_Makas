using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagit_Makas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string OyuncuTercih;
        string PcTercih;
        int random;
        Random rnd = new Random();

        private void lbl_tas_Click(object sender, EventArgs e)
        {
            OyuncuTercih = "TAŞ";
            lbl_oyuncu.Text = OyuncuTercih;
        }

        private void lbl_kagit_Click(object sender, EventArgs e)
        {
            OyuncuTercih = "KAĞIT";
            lbl_oyuncu.Text = OyuncuTercih;
        }

        private void lbl_makas_Click(object sender, EventArgs e)
        {
            OyuncuTercih = "MAKAS";
            lbl_oyuncu.Text = OyuncuTercih;
        }
        private void BilgisayarTercih()
        {
            random = rnd.Next(1, 4);
            if (random == 1)
            {
                PcTercih = "TAŞ";
                lbl_bilgisayar.Text = PcTercih;
            }
            else if (random == 2)
            {
                PcTercih = "KAĞIT";
                lbl_bilgisayar.Text = PcTercih;
            }
            else if (random == 3)
            {
                PcTercih = "MAKAS";
                lbl_bilgisayar.Text = PcTercih;
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {

            if (OyuncuTercih == null)
            {
                MessageBox.Show("Hamle Şeçimi Yapmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BilgisayarTercih();
            }


            if (OyuncuTercih == "TAŞ" && PcTercih == "KAĞIT")
            {
                lbl_skor.Text = "BİLGİSAYAR KAZANDI";

            }
            else if (OyuncuTercih == "TAŞ" && PcTercih == "MAKAS")
            {
                lbl_skor.Text = "OYUNCU KAZANDI";
            }
            else if (OyuncuTercih == "KAĞIT" && PcTercih == "TAŞ")
            {
                lbl_skor.Text = "OYUNCU KAZANDI";
            }
            else if (OyuncuTercih == "KAĞIT" && PcTercih == "MAKAS")
            {
                lbl_skor.Text = "BİLGİSAYAR KAZANDI";

            }
            else if (OyuncuTercih == "MAKAS" && PcTercih == "TAŞ")
            {
                lbl_skor.Text = "BİLGİSAYAR KAZANDI";

            }
            else if (OyuncuTercih == "MAKAS" && PcTercih == "KAĞIT")
            {
                lbl_skor.Text = "OYUNCU KAZANDI";
            }
            else if (OyuncuTercih == PcTercih)
            {
                lbl_skor.Text = "KAZANAN YOK";
            }


        }

       
    }
}
