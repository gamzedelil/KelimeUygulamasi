using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilOgrenmeUygulamasi
{
    public partial class Form1 : Form
    {
        // Günlük Hayat Kategorisi İçin Test
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

        }
        int sayac = 0;
        double dogru = 0, yanlis = 0;
        void sorular ()
        {
            if(sayac == 1) {
                label2.Text = " Good Morning ";
                button1.Text = " Merhaba ";
                button2.Text = " İyi Geceler ";
                button3.Text = " Günaydın ";
                button4.Text = " Nasılsın ";
                dogrucevap = button3.Text;
            }

            if (sayac == 2)
            {
                label2.Text = " Good Night ";
                button1.Text = " İyi Geceler ";
                button2.Text = " Hoşçakal ";
                button3.Text = " Görüşürüz ";
                button4.Text = " Günaydın ";
                dogrucevap = button1.Text;
            }

            if (sayac == 3)
            { 
                label2.Text = " Goodbye ";
                button1.Text = " İyi günler ";
                button2.Text = " Nasılsın ";
                button3.Text = " Merhaba ";
                button4.Text = " Güle Güle ";
                dogrucevap = button4.Text;
            }

            if (sayac == 4)
            {
                label2.Text = " How are you? ";
                button1.Text = " Nasılsın? ";
                button2.Text = " Nerelisin? ";
                button3.Text = " Adın ne? ";
                button4.Text = " Mesleğin ne? ";
                dogrucevap = button1.Text;
            }

            if (sayac == 5)
            {
                label2.Text = " Where are you from? ";
                button1.Text = " Mesleğin ne? ";
                button2.Text = " Adın ne? ";
                button3.Text = " Nerelisin? ";
                button4.Text = " Nasılsın? ";
                dogrucevap = button3.Text;
            }

            if (sayac == 6)
            {
                label2.Text = " Hello ";
                button1.Text = " Merhaba ";
                button2.Text = " Günaydın ";
                button3.Text = " İyi geceler ";
                button4.Text = " Hoşgeldin ";
                dogrucevap = button1.Text;
            }

            if (sayac == 7)
            {
                label2.Text = " My name is ... ";
                button1.Text = " Benim uyruğum ... ";
                button2.Text = " Benim yaşım ...";
                button3.Text = " Benim yaşadığım yer ... ";
                button4.Text = " Benim adım ... ";
                dogrucevap = button4.Text;
            }

            if (sayac == 8)
            {
                label2.Text = " Job ";
                button1.Text = " Sabah ";
                button2.Text = " Meslek ";
                button3.Text = " Yemek ";
                button4.Text = " Hoşçakal ";
                dogrucevap = button2.Text;
            }

            if (sayac == 9)
            {
                label2.Text = " Welcome ";
                button1.Text = " Hoşgeldiniz ";
                button2.Text = " Görüşürüz ";
                button3.Text = " İyi geceler ";
                button4.Text = " Günaydın ";
                dogrucevap = button1.Text;
            }

            if (sayac == 10)
            {
                label2.Text = " Excuse me! ";
                button1.Text = " Affedersiniz ";
                button2.Text = " Nasılsınız ";
                button3.Text = " Merhaba ";
                button4.Text = " Görüşürüz ";
                dogrucevap = button1.Text;
            }

         


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DortButon(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
            }
            if ((sender as Button).Text == dogrucevap)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            lblDogru.Text = "Doğru Sayısı = " +dogru;
            lblYanlis.Text = "Yanlış Sayısı = " +yanlis;
            
        }
        string dogrucevap = "";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            button5.Text = "Sonraki Soru";
            sayac++;
            label1.Text = " Soru " + sayac + ":" ;
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
            sorular();
        
        }


    }
    }

