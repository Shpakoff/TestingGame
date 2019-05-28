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
    public partial class Options : Form
    {
        private readonly OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|bin/Debug/Game.accdb");
        public Options()
        {
            
            InitializeComponent();
            textBox2.Text = Data.Name;
            textBox1.Text = Data2.Login;
            textBox3.Text = Data3.Password;
            trackBar1.Value = sound.player.settings.volume;
            trackBar3.Value = music.player.settings.volume; 
            label11.Text = Convert.ToString(trackBar1.Value);
            label12.Text = Convert.ToString(trackBar3.Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show(); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите имя!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Введите логин!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Введите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Подтвердите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (Data2.Login != "admin" && textBox2.Text == "admin") { MessageBox.Show("Этот логин использует админ, попробуйте другой.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (textBox3.Text == textBox4.Text)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Пользователи set Имя = '" + textBox1.Text + "', Логин = '" + textBox2.Text + "', Пароль = '" + textBox3.Text + "' Where Имя = '"+Data.Name+"'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Data.Name = textBox1.Text;
                    Data2.Login = textBox2.Text;
                    Data3.Password = textBox3.Text;
                    MessageBox.Show("Вы успешно изменили данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else { MessageBox.Show("Неверное подтверждение пароля!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (music.player.settings.volume != 0)
            {
                GC.Collect();
               button4.BackgroundImage = Image.FromFile("images/mute.png");
               music.player.settings.volume = 0;
               trackBar3.Value = 0;
                label12.Text = Convert.ToString(trackBar3.Value);
            }
            else
            {
                GC.Collect();
                button4.BackgroundImage = Image.FromFile("images/high-volume.png");
                music.player.settings.volume = 50;
                trackBar3.Value = 50;
                label12.Text = Convert.ToString(trackBar3.Value);
            }       
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        { label12.Text = Convert.ToString(trackBar3.Value);
          music.player.settings.volume = trackBar3.Value;
           if (music.player.settings.volume == 0)
            {
                GC.Collect();
                button4.BackgroundImage = Image.FromFile("images/mute.png");
                label12.Text = Convert.ToString(trackBar3.Value);
            }
            else
            {
                GC.Collect();
                button4.BackgroundImage = Image.FromFile("images/high-volume.png");
                label12.Text = Convert.ToString(trackBar3.Value);
            }
            
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label11.Text = Convert.ToString(trackBar1.Value);
            sound.player.settings.volume = trackBar1.Value;
            if (sound.player.settings.volume == 0)
            {
                GC.Collect();
                button1.BackgroundImage = Image.FromFile("images/mute.png");
                label11.Text = Convert.ToString(trackBar1.Value);
            }
            else
            {
                GC.Collect();
                button1.BackgroundImage = Image.FromFile("images/high-volume.png");
                label11.Text = Convert.ToString(trackBar1.Value);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (sound.player.settings.volume != 0)
            {
                button1.BackgroundImage = Image.FromFile("images/mute.png");
                sound.player.settings.volume = 0;
                trackBar1.Value = 0;
                label11.Text = Convert.ToString(trackBar1.Value);
            } 
            else {
                button1.BackgroundImage = Image.FromFile("images/high-volume.png");
                sound.player.settings.volume = 50;
                trackBar1.Value = 50;
                label11.Text = Convert.ToString(trackBar1.Value);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile1 = new OpenFileDialog())
            {
                openFile1.DefaultExt = "*.mp3";
                openFile1.Filter = "MP3 Files|*.mp3";
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   openFile1.FileName.Length > 0)
                {
                    music.player.URL = (openFile1.FileName);
                    music.player.controls.play();

                }
            }
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }
    }
}
