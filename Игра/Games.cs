using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
            sound.player.URL = "sounds/7.mp3";
            sound.player.controls.play();
        }

        private void Games_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Это игра на проверку\n знаний по дисциплине!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/8.mp3";
            sound.player.controls.play();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Выбери и нажми на игру!";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "В этой игре тебе надо\n будет найти ошибки!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/9.mp3";
            sound.player.controls.play();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Выбери и нажми на игру!";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Хочешь выйти в главное\nменю? Жми!";
            sound.player.controls.stop();
            sound.player.URL = "sounds/11.mp3";
            sound.player.controls.play();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Выбери и нажми на игру!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            Menu f = new Menu();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            Game1 f = new Game1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sound.player.controls.stop();
            Game2 f = new Game2();
            this.Hide();
            f.Show();
        }
    }
}
