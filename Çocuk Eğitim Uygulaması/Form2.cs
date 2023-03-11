using Çocuk_Eğitim_Uygulaması.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Çocuk_Eğitim_Uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SoundPlayer oynat = new SoundPlayer();
        private void biKedi_Click(object sender, EventArgs e)
        {
            
            oynat.Stream = Resources.ses_kedi;
            oynat.Play();
        }

        private void biKopek_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_kopek;
            oynat.Play();
        }

        private void biAt_Click(object sender, EventArgs e)
        {
           oynat.Stream = Resources.ses_at;
           oynat.Play();
        }

        private void biEsek_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_esek;
            oynat.Play();
        }

        private void biYilan_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_yilan;
            oynat.Play();
        }

        private void biKurb_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_kurb;
            oynat.Play();
        }

        private void biHoroz_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_horoz;
            oynat.Play();
        }

        private void biKus_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_kus;
            oynat.Play();
        }

        private void biKartal_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_kartal;
            oynat.Play();
        }

        private void biKoyun_Click(object sender, EventArgs e)
        {
            oynat.Stream = Resources.ses_koyun;
            oynat.Play();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
