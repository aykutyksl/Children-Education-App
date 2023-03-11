using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class Form7 : Form
    {
        Random rand = new Random();
        int a, b, i, puan;

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            geri.Visible = true;
            bunifuImageButton1.Enabled = false;
            bunifuFlatButton1.Visible = true;
            bunifuFlatButton3.Visible = true;
            bunifuFlatButton4.Visible = true;
            bunifuFlatButton5.Visible = true;

            bunifuImageButton1.Location = new System.Drawing.Point(343, 178);

            puan = 0;
            label1.Text = "0";

        }

        

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            label3.Text = "Kolay";
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = false;
            bunifuFlatButton5.Visible = false;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 300;

            label3.Text = "Orta";
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = false;
            bunifuFlatButton5.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            label3.Text = "Zor";
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = false;
            bunifuFlatButton5.Visible = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i==2)
            {
                bunifuImageButton1.Location = new System.Drawing.Point(a,b);
                a = rand.Next(600);
                b = rand.Next(600);
                i = 0; 


            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            a = rand.Next(600);
            b = rand.Next(600);
            bunifuImageButton1.Location = new System.Drawing.Point(a, b);
            puan += 1;
            label1.Text = puan.ToString();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            bunifuImageButton1.Enabled = false;
            
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //label3.Text = "Kolay";

            geri.Visible = false;
            bunifuImageButton1.Enabled = true;
            bunifuFlatButton1.Visible = false;
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = false;
            bunifuFlatButton5.Visible = false;
           


            bunifuFlatButton2.Location = new System.Drawing.Point(639, 731); 
        }
    }
}
