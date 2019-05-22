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
using System.IO;

namespace Игра
{
    public partial class AddTheory : Form
    {
        
        int id;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Info.accdb");
        public AddTheory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {  
            if ((string.IsNullOrEmpty(textBox2.Text)) && (textBox2.Visible == true)) { MessageBox.Show("Введите главы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((string.IsNullOrEmpty(textBox3.Text)) && (textBox3.Visible == true)) { MessageBox.Show("Введите главы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((string.IsNullOrEmpty(textBox4.Text)) && (textBox4.Visible == true)) { MessageBox.Show("Введите главы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((string.IsNullOrEmpty(textBox5.Text)) && (textBox5.Visible == true)) { MessageBox.Show("Введите главы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((string.IsNullOrEmpty(textBox6.Text)) && (textBox6.Visible == true)) { MessageBox.Show("Введите главы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if ((files.openFile1.FileName == "") && (button2.Visible == true)) { MessageBox.Show("Загрузите файлы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((files.openFile2.FileName == "") && (button4.Visible == true)) { MessageBox.Show("Загрузите файлы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((files.openFile3.FileName == "") && (button5.Visible == true)) { MessageBox.Show("Загрузите файлы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((files.openFile4.FileName == "") && (button6.Visible == true)) { MessageBox.Show("Загрузите файлы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if ((files.openFile5.FileName == "") && (button7.Visible == true)) { MessageBox.Show("Загрузите файлы!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }       
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Сначало введите главу!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                files.openFile1.DefaultExt = "*.rtf";
                files.openFile1.Filter = "RTF Files|*.rtf";
                if (files.openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                            files.openFile1.FileName.Length > 0)
                {
                    string s = files.openFile1.SafeFileName;
                    if (files.openFile1.FileName.Contains(@"\docs")) { }
                    else
                    {
                        var str = files.openFile1.FileName.Split(new[] { '\\' }).Last();
                        File.Copy(files.openFile1.FileName, Application.StartupPath +@"\docs\" + str + "");
                    }
                    con.Open();
                    string query = "insert into Главы(Название,Путь,КодРаздела) values( '" + textBox2.Text + "', '" + s + "', '" + id + "' )";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                textBox2.ReadOnly = true;
                button2.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Сначало введите главу!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                files.openFile2.DefaultExt = "*.rtf";
                files.openFile2.Filter = "RTF Files|*.rtf";
                if (files.openFile2.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                            files.openFile2.FileName.Length > 0)
                {
                    string s = files.openFile2.SafeFileName;
                    if (files.openFile2.FileName.Contains(@"\docs")) { }
                    else
                    {
                        var str = files.openFile2.FileName.Split(new[] { '\\' }).Last();
                        File.Copy(files.openFile2.FileName, Application.StartupPath + @"\docs\" + str + "");
                    }
                    con.Open();
                    string query = "insert into Главы(Название,Путь,КодРаздела) values( '" + textBox3.Text + "', '" + s + "', '" + id + "' )";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                textBox3.ReadOnly = true;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Сначало введите главу!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                files.openFile3.DefaultExt = "*.rtf";
                files.openFile3.Filter = "RTF Files|*.rtf";
                if (files.openFile3.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                            files.openFile3.FileName.Length > 0)
                {
                    string s = files.openFile3.SafeFileName;
                    if (files.openFile3.FileName.Contains(@"\docs")) { }
                    else
                    {
                        var str = files.openFile3.FileName.Split(new[] { '\\' }).Last();
                        File.Copy(files.openFile3.FileName, AppDomain.CurrentDomain.BaseDirectory + "/docs" + str);
                    }
                    con.Open();
                    string query = "insert into Главы(Название,Путь,КодРаздела) values( '" + textBox4.Text + "', '" + s + "', '" + id + "' )";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                textBox4.ReadOnly = true;
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Сначало введите главу!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                files.openFile4.DefaultExt = "*.rtf";
                files.openFile4.Filter = "RTF Files|*.rtf";
                if (files.openFile4.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                            files.openFile4.FileName.Length > 0)
                {
                    string s = files.openFile4.SafeFileName;
                    if (files.openFile4.FileName.Contains(@"\docs")) { }
                    else
                    {
                        var str = files.openFile4.FileName.Split(new[] { '\\' }).Last();
                        File.Copy(files.openFile4.FileName, AppDomain.CurrentDomain.BaseDirectory + "/docs" + str);
                    }
                    con.Open();
                    string query = "insert into Главы(Название,Путь,КодРаздела) values( '" + textBox5.Text + "', '" + s + "', '" + id + "' )";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                textBox5.ReadOnly = true;
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Сначало введите главу!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                files.openFile5.DefaultExt = "*.rtf";
                files.openFile5.Filter = "RTF Files|*.rtf";
                if (files.openFile5.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                            files.openFile5.FileName.Length > 0)
                {
                    string s = files.openFile5.SafeFileName;
                    if (files.openFile5.FileName.Contains(@"\docs")) { }
                    else
                    {
                        var str = files.openFile5.FileName.Split(new[] { '\\' }).Last();
                        File.Copy(files.openFile5.FileName, AppDomain.CurrentDomain.BaseDirectory + "/docs" +str);
                    }
                    con.Open();
                    string query = "insert into Главы(Название,Путь,КодРаздела) values( '" + textBox6.Text + "', '" + s + "', '" + id + "' )";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                textBox6.ReadOnly = true;
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите раздел!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Выберите количество глав!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Раздел(НазваниеРаздела) values('" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select Код From Раздел Where НазваниеРаздела = '" + textBox1.Text + "'";
            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.ReadOnly = true;
            button3.Visible = true;
            label2.Visible = true;
                if (comboBox1.SelectedIndex == 4) { button2.Visible = true; button4.Visible = true; button5.Visible = true; button6.Visible = true; button7.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; label3.Visible = false; comboBox1.Visible = false; button8.Visible = false;  }
                if (comboBox1.SelectedIndex == 3) { button2.Visible = true; button4.Visible = true; button5.Visible = true; button6.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; label3.Visible = false; comboBox1.Visible = false; button8.Visible = false;   }
                if (comboBox1.SelectedIndex == 2) { button2.Visible = true; button4.Visible = true; button5.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; label3.Visible = false; comboBox1.Visible = false; button8.Visible = false;   }
                if (comboBox1.SelectedIndex == 1) { button2.Visible = true; button4.Visible = true; textBox2.Visible = true; textBox3.Visible = true; label3.Visible = false; comboBox1.Visible = false; button8.Visible = false;   }
                if (comboBox1.SelectedIndex == 0) { button2.Visible = true; textBox2.Visible = true; label3.Visible = false; comboBox1.Visible = false; button8.Visible = false;   }
            
        }

    }
}

 