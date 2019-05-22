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
    public partial class Reg : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        public Reg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aut f = new Aut();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

            if (textBox3.Text == textBox4.Text)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Пользователи(Имя, Логин, Пароль) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Вы успешно зарегистрировались, добро пожаловать " + textBox1.Text + "!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
