using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DilOgrenmeUygulamasi
{
    public partial class Form2 : Form
    {
        private int currentSoundIndex = 0;
        private readonly SoundPlayer[] soundPlayers;
        public Form2()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;

            soundPlayers = new SoundPlayer[]
           {
                new SoundPlayer(Resource1.Good_Morning),
                new SoundPlayer(Resource1.Good_Night),
                new SoundPlayer(Resource1.Goodbye),
                new SoundPlayer(Resource1.How_are_you),
                new SoundPlayer(Resource1.Where_are_you_from_),
                new SoundPlayer(Resource1.Hello),
                new SoundPlayer(Resource1.My_name_is____),
                new SoundPlayer(Resource1.Job),
                new SoundPlayer(Resource1.Welcome),
                new SoundPlayer(Resource1.Excuse_me_),


           };

        }

        private void AddImageToButton()
        {
            // Resmi yükle
            Image buttonImage = Image.FromFile("your_image.png");
            // Butona resmi ekle
            button1.Image = buttonImage;
            // Butonun boyutunu resme göre ayarla
            button1.Size = new Size(buttonImage.Width, buttonImage.Height);
            // Butonun text ve resim konumunu ayarla (isteğe bağlı)
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        int sayac = 0;
        void sorular()
        {
            if (sayac == 1)
            {
                label1.Text = " Good Morning ";
                label2.Text = " Günaydın ";
            }

            if (sayac == 2)
            {
                label1.Text = " Good Night ";
                label2.Text = " İyi geceler ";
            }

            if (sayac == 3)
            {
                label1.Text = " Goodbye ";
                label2.Text = " Güle güle ";
            }

            if (sayac == 4)
            {
                label1.Text = " How are you? ";
                label2.Text = " Nasılsın? ";
            }

            if (sayac == 5)
            {
                label1.Text = " Where are you from? ";
                label2.Text = " Nerelisin? ";
            }

            if (sayac == 6)
            {
                label1.Text = " Hello ";
                label2.Text = "Merhaba";
            }

            if (sayac == 7)
            {
                label1.Text = " My name is ... ";
                label2.Text = "Benim adım ...";
            }

            if (sayac == 8)
            {
                label1.Text = " Job ";
                label2.Text = "Meslek";
            }

            if (sayac == 9)
            {
                label1.Text = " Welcome ";
                label2.Text = "Hoşgeldiniz";
            }

            if (sayac == 10)
            {
                label1.Text = " Excuse me! ";
                label2.Text = "Affedersiniz";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            Form1 f1 = new Form1();
            f1.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
