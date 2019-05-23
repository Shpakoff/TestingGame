using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class RegistrationForm : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var authorizationForm = new AuthorizationForm();
            Hide();
            authorizationForm.Show();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMaterialTextbox1.Text))
            {
                MessageBox.Show("Введите имя!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuMaterialTextbox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(bunifuMaterialTextbox2.Text))
            {
                MessageBox.Show("Введите логин!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuMaterialTextbox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(bunifuMaterialTextbox3.Text))
            {
                MessageBox.Show("Введите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuMaterialTextbox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(bunifuMaterialTextbox4.Text))
            {
                MessageBox.Show("Подтвердите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuMaterialTextbox4.Focus();
                return;
            }

            if (bunifuMaterialTextbox3.Text == bunifuMaterialTextbox4.Text)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Пользователи(Имя, Логин, Пароль) values('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Вы успешно зарегистрировались, добро пожаловать " + bunifuMaterialTextbox1.Text + "!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Aut f = new Aut();
                this.Hide();
                f.Show();
            }
            else { MessageBox.Show("Неверное подтверждение пароля!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
