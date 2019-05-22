using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Игра
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            label1.Text = "Привет, " + Data.Name + "!";
            Kol.n++;
            if (Kol.n == 1)
            {
                sound.player.URL = "sounds/1.mp3";
                sound.player.controls.play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            DialogResult rsl = MessageBox.Show("Вы хотите выйти?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes) { Application.Exit(); }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "Привет мой друг! Я рад\n тебя видеть здесь!";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "Привет мой друг! Я рад\n тебя видеть здесь!";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "Привет мой друг! Я рад\n тебя видеть здесь!";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "Привет мой друг! Я рад\n тебя видеть здесь!";
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "Привет мой друг! Я рад\n тебя видеть здесь!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            Options f = new Options();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            Theory f = new Theory();
            this.Hide();
            f.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Ты хочешь поиграть? \nНу давай поиграем!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/2.mp3";
            sound.player.controls.play();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Желаешь получить\n знания? Вперед!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/3.mp3";
            sound.player.controls.play();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Нужно настроить игру?\n Жми!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/4.mp3";
            sound.player.controls.play();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Хочешь выйти из игры?\n Жаль...";
            sound.player.controls.stop();
            sound.player.URL = "sounds/5.mp3";
            sound.player.controls.play();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Интересуют рекорды?\n Загляни!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/6.mp3";
            sound.player.controls.play();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            Games f = new Games();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            News f = new News();
            this.Hide();
            f.Show();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Нажми чтобы увидеть\n свежие новости!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/12.mp3";
            sound.player.controls.play();
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "Привет мой друг! Я рад\n тебя видеть здесь!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            Records f = new Records();
            this.Hide();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
