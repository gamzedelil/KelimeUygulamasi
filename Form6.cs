using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Seyahat için
namespace DilOgrenmeUygulamasi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        int sayac = 0;
        double dogru = 0, yanlis = 0;

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
            lblDogru.Text = "Doğru Sayısı = " + dogru;
            lblYanlis.Text = "Yanlış Sayısı = " + yanlis;

        }
        string dogrucevap = "";

        private void button5_Click(object sender, EventArgs e)
        {

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Text = "Sonraki Soru";
            sayac++;
            label1.Text = " Soru " + sayac + ":";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
            sorular();
        }

        void sorular()
        {
            if (sayac == 1)
            {
                label2.Text = " Travel ";
                button1.Text = " Bagaj ";
                button2.Text = " Uçuş ";
                button3.Text = " Seyahat ";
                button4.Text = " Rezervasyon ";
                dogrucevap = button3.Text;
            }

            if (sayac == 2)
            {
                label2.Text = " Flight ";
                button1.Text = " Uçuş ";
                button2.Text = " Uçak ";
                button3.Text = " Otel ";
                button4.Text = " Gezmek ";
                dogrucevap = button1.Text;
            }

            if (sayac == 3)
            {
                label2.Text = " Ticket ";
                button1.Text = " Gezi ";
                button2.Text = " Pasaport ";
                button3.Text = " Vize ";
                button4.Text = " Bilet ";
                dogrucevap = button4.Text;
            }

            if (sayac == 4)
            {
                label2.Text = " Suitcase ";
                button1.Text = " Bavul ";
                button2.Text = " Rötar ";
                button3.Text = " Otel ";
                button4.Text = " Vize ";
                dogrucevap = button1.Text;
            }

            if (sayac == 5)
            {
                label2.Text = " Map ";
                button1.Text = " Bavul ";
                button2.Text = " Bilet ";
                button3.Text = " Harita ";
                button4.Text = " Seyahat ";
                dogrucevap = button3.Text;
            }

            if (sayac == 6)
            {
                label2.Text = " Visa ";
                button1.Text = " Vize ";
                button2.Text = " Rötar ";
                button3.Text = " Havaalanı ";
                button4.Text = " Rezervasyon ";
                dogrucevap = button1.Text;
            }

            if (sayac == 7)
            {
                label2.Text = " Airport ";
                button1.Text = " Tatil ";
                button2.Text = " Rezervasyon ";
                button3.Text = " Bavul ";
                button4.Text = " Havaalanı ";
                dogrucevap = button4.Text;
            }

            if (sayac == 8)
            {
                label2.Text = " Delay ";
                button1.Text = " Sabah ";
                button2.Text = " Rötar ";
                button3.Text = " Bilet ";
                button4.Text = " Havaalanı ";
                dogrucevap = button2.Text;
            }

            if (sayac == 9)
            {
                label2.Text = " Holiday ";
                button1.Text = " Tatil ";
                button2.Text = " Bavul ";
                button3.Text = " Uçak ";
                button4.Text = " Rezervasyon ";
                dogrucevap = button1.Text;
            }

            if (sayac == 10)
            {
                label2.Text = " Reservation ";
                button1.Text = " Rezervasyon ";
                button2.Text = " Vize ";
                button3.Text = " Pasaport ";
                button4.Text = " Bagaj ";
                dogrucevap = button1.Text;
            }
        }
    }
}
