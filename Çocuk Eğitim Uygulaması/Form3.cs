using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        int yanlisHakki = 0;
        int dogruSayac = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            string[] isimler = { "Kırmızı", "Yeşil", "Sarı", "Mavi", "Beyaz", "Siyah", "Pembe", "Mor", "Turuncu", "Kahverengi" };
            Random rastgelesayi = new Random();  // Rastgele sayı üretmek için
            int no = rastgelesayi.Next(0, isimler.Length); //Dizinin kaçıncı elemanını yazdıracağımızı belirlemek için
            label1.Text = isimler[no];
        }

        public void dogruİse()
        {
            label4.Visible = false;

            int sonuc;
            sonuc = int.Parse(label2.Text) + 1;
            label2.Text = sonuc.ToString();

            string[] isimler = { "Kırmızı", "Yeşil", "Sarı", "Mavi", "Beyaz", "Siyah", "Pembe", "Mor", "Turuncu", "Kahverengi" };
            Random rastgelesayi = new Random();  // Rastgele sayı üretmek için
            int no = rastgelesayi.Next(0, isimler.Length); //Dizinin kaçıncı elemanını yazdıracağımızı belirlemek için
            label1.Text = isimler[no];

            label3.Text = "Doğru ! 1 puan aldın.";
            label3.ForeColor = Color.Blue;

            dogruSayac += 1;
            if (dogruSayac==10)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
                this.Close();
            }


        }
        public void yanlisİse()
        {
            label4.Visible = false;

            int sonuc;
            sonuc = int.Parse(label2.Text) - 1;
            label2.Text = sonuc.ToString();



            string[] isimler = { "Kırmızı", "Yeşil", "Sarı", "Mavi", "Beyaz", "Siyah", "Pembe", "Mor", "Turuncu", "Kahverengi" };
            Random rastgelesayi = new Random();  // Rastgele sayı üretmek için
            int no = rastgelesayi.Next(0, isimler.Length); //Dizinin kaçıncı elemanını yazdıracağımızı belirlemek için
            label1.Text = isimler[no];

            label3.Text = "Yanlış puanın 1 azaldı.";
            label3.ForeColor = Color.Red;

            yanlisHakki += 1;

            if (yanlisHakki == 5)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                this.Close();   
            }
                


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Kırmızı")
            dogruİse();
            else
            yanlisİse();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Mavi")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Sarı")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Pembe")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Turuncu")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Yeşil")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Siyah")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Beyaz")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Kahverengi")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Mor")
                dogruİse();
            else
                yanlisİse();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
