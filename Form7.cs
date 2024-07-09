using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DilOgrenmeUygulamasi
{
    public partial class Form7 : Form
    {
        private int currentSoundIndex = 0;
        private readonly SoundPlayer[] soundPlayers;
        public Form7()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;


            soundPlayers = new SoundPlayer[]
           {
                new SoundPlayer(Resource3.Travel),
                new SoundPlayer(Resource3.Flight),
                new SoundPlayer(Resource3.Ticket),
                new SoundPlayer(Resource3.Suitcase),
                new SoundPlayer(Resource3.Map),
                new SoundPlayer(Resource3.Visa),
                new SoundPlayer(Resource3.Airport),
                new SoundPlayer(Resource3.Delay),
                new SoundPlayer(Resource3.Holiday),
                new SoundPlayer(Resource3.Reservation),


           };
        }

        int sayac = 0;
        void sorular()
        {
            if (sayac == 1)
            {
                label1.Text = " Travel ";
                label2.Text = " Seyahat ";
            }

            if (sayac == 2)
            {
                label1.Text = " Flight ";
                label2.Text = " Uçuş ";
            }

            if (sayac == 3)
            {
                label1.Text = " Ticket ";
                label2.Text = " Bilet ";
            }

            if (sayac == 4)
            {
                label1.Text = " Suitcase ";
                label2.Text = " Bavul ";
            }

            if (sayac == 5)
            {
                label1.Text = " Map ";
                label2.Text = " Harita ";
            }

            if (sayac == 6)
            {
                label1.Text = " Visa ";
                label2.Text = "Vize";
            }

            if (sayac == 7)
            {
                label1.Text = " Airport ";
                label2.Text = "Havalimanı";
            }

            if (sayac == 8)
            {
                label1.Text = " Delay ";
                label2.Text = " Rötar ";
            }

            if (sayac == 9)
            {
                label1.Text = " Holiday ";
                label2.Text = "Tatil";
            }

            if (sayac == 10)
            {
                label1.Text = " Reservation ";
                label2.Text = "Rezervasyon";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            button1.Text = "Sonraki Soru";
            sayac++;
            sorular();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer currentPlayer = soundPlayers[currentSoundIndex];

            // Sesi çal
            currentPlayer.Play();

            // Sonraki sese geçmek için indeksi artır
            currentSoundIndex++;

            // Eğer indeks son dosyanın ötesine geçtiyse, başa dön
            if (currentSoundIndex >= soundPlayers.Length)
            {
                currentSoundIndex = 0;
            }
        }
    }

}
