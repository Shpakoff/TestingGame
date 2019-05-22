using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Игра
{
    public partial class Aut : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");

        public Aut()
        {
            InitializeComponent();
            Kol.n++;
            if (Kol.n == 1)
            {
                music.player.URL = "music/music1.mp3";
                music.player.settings.setMode("loop", true);﻿
                music.player.controls.play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите логин!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Введите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            try
            {
                GameDataSetTableAdapters.ПользователиTableAdapter user = new GameDataSetTableAdapters.ПользователиTableAdapter();
                GameDataSet.ПользователиDataTable dt = user.GetDataBy(textBox1.Text, textBox2.Text);

                if (dt.Rows.Count > 0)
                {                  
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Имя From Пользователи where Логин = '"+textBox1.Text+"'";
                    Data.Name = Convert.ToString(cmd.ExecuteScalar());
                    cmd.CommandText = "Select Код From Пользователи where Логин = '" + textBox1.Text + "'";
                    Data4.Kod = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    Data2.Login = textBox1.Text;
                    Data3.Password = textBox2.Text;
                    Menu f = new Menu();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg f = new Reg();
            this.Hide();
            f.Show();

        }

        private void Aut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Aut_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (music.player.settings.volume != 0)
            {
                GC.Collect();
                button3.BackgroundImage = Image.FromFile("images/mute.png");
                music.player.settings.volume = 0;
       
            }
            else
            {
                GC.Collect();
                button3.BackgroundImage = Image.FromFile("images/high-volume.png");
                music.player.settings.volume = 50;
              
            }
        }
    }
}
