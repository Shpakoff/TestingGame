using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;

namespace Игра
{
    public partial class AuthorizationForm : Form
    {
        readonly OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        public AuthorizationForm()
        {
            Kol.n++;
            if (Kol.n == 1)
            {
                music.player.URL = "music/music1.mp3";
                music.player.settings.setMode("loop", true);
                music.player.controls.play();
            }
            InitializeComponent();
        }   
        //Закрытие формы
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Скрыть форму
        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }            

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMetroTextbox1.Text))
            {
                MessageBox.Show("Введите логин!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuMetroTextbox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(bunifuMetroTextbox2.Text))
            {
                MessageBox.Show("Введите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuMetroTextbox2.Focus();
                return;
            }
            try
            {
                GameDataSetTableAdapters.ПользователиTableAdapter user = new GameDataSetTableAdapters.ПользователиTableAdapter();
                GameDataSet.ПользователиDataTable dt = user.GetDataBy(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text);

                if (dt.Rows.Count > 0)
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Имя From Пользователи where Логин = '" + bunifuMetroTextbox1.Text + "'";
                    Data.Name = Convert.ToString(cmd.ExecuteScalar());
                    cmd.CommandText = "Select Код From Пользователи where Логин = '" + bunifuMetroTextbox1.Text + "'";
                    Data4.Kod = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    Data2.Login = bunifuMetroTextbox1.Text;
                    Data3.Password = bunifuMetroTextbox2.Text;
                    var menuForm = new MenuForm();
                    Hide();
                    menuForm.Show();
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

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            label2.ForeColor = Color.FromArgb(104, 78, 222);
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            label2.ForeColor = Color.FromArgb(74, 20, 140);
        }
        private void Label2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            Hide();
            registrationForm.Show();
        }
    }
}
