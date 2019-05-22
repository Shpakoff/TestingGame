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
    public partial class Game2 : Form
    {
        double ball = 0;
        int kol = 0;
        int[] v;
        int i = 0;
        string query = "";
        int number;
        string curBall = "";
        int prov = 0;
        int t = 60;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        public Game2()
        {
            InitializeComponent();

            label6.MaximumSize = new Size(220, 0);
            label6.AutoSize = true;
            con.Open();
            OleDbCommand thisCommand1 = con.CreateCommand();
            thisCommand1.CommandText = "SELECT COUNT(*) FROM Рекорды WHERE КодИгры = 2";
            prov = Convert.ToInt32(thisCommand1.ExecuteScalar());
            thisCommand1.CommandText = "SELECT КоличествоБаллов FROM Рекорды WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 2";
            curBall = Convert.ToString(thisCommand1.ExecuteScalar());
            if (prov != 0)
            {
                thisCommand1.CommandText = "SELECT MAX(КоличествоБаллов) FROM Рекорды WHERE КодИгры = 2";
                Rec2.rec2 = Convert.ToDouble(thisCommand1.ExecuteScalar());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Games f = new Games();
            this.Hide();
            f.Show();
            timer1.Enabled = false;
        }

        private void Game2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked || checkBox2.Checked) && (checkBox3.Checked || checkBox4.Checked))
            {
                button1.Text = "Выход";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                button2.Visible = false;
                textBox2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                comboBox1.Visible = false;
                textBox2.Clear();
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                if (checkBox3.Checked) {
                    switch (comboBox1.Text)
                    {
                        case "Без времени":
                            button3.Visible = true; textBox1.Visible = true; label8.Visible = true;
                            break;
                        case "1 мин":
                            t = 60;
                            button3.Visible = true; textBox1.Visible = true; label8.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "5 мин":
                            t = 300;
                            button3.Visible = true; textBox1.Visible = true; label8.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "10 мин":
                            t = 600;
                            button3.Visible = true; textBox1.Visible = true; label8.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "15 мин":
                            t = 900;
                            button3.Visible = true; textBox1.Visible = true; label8.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "20 мин":
                            t = 1200;
                            button3.Visible = true; textBox1.Visible = true; label8.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        default:
                            MessageBox.Show("Выбирете временной режим");
                            return;
                    }}
                if (checkBox4.Checked) {
                    switch (comboBox1.Text)
                    {
                        case "Без времени":
                            button4.Visible = true; textBox2.ReadOnly = false; label9.Visible = true;
                            break;
                        case "1 мин":
                            t = 60;
                            button4.Visible = true; textBox2.ReadOnly = false; label9.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "5 мин":
                            t = 300;
                            button4.Visible = true; textBox2.ReadOnly = false; label9.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "10 мин":
                            t = 600;
                            button4.Visible = true; textBox2.ReadOnly = false; label9.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "15 мин":
                            t = 900;
                            button4.Visible = true; textBox2.ReadOnly = false; label9.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        case "20 мин":
                            t = 1200;
                            button4.Visible = true; textBox2.ReadOnly = false; label9.Visible = true; label12.Visible = true; label13.Visible = true; timer1.Enabled = true; timer1.Start(); label13.Text = t.ToString() + " сек";
                            break;
                        default:
                            MessageBox.Show("Выбирете временной режим");
                            return;
                    }
               }
                if (checkBox1.Checked) 
                {
                    Random rnd = new Random();
                    OleDbCommand thisCommand1 = con.CreateCommand();
                    thisCommand1.CommandText = "SELECT COUNT(*) FROM Игра2_Паск";
                    int id = Convert.ToInt32(thisCommand1.ExecuteScalar());
                    kol = id;
                    v = Enumerable.Range(1, kol).OrderBy(x => rnd.Next()).ToArray();
                    query = "SELECT * FROM Игра2_Паск WHERE Код = " + v[i] + ""; 
                }
                if (checkBox2.Checked) 
                {
                    Random rnd = new Random();
                    OleDbCommand thisCommand1 = con.CreateCommand();
                    thisCommand1.CommandText = "SELECT COUNT(*) FROM Игра2_Си";
                    int id = Convert.ToInt32(thisCommand1.ExecuteScalar());
                    kol = id;
                    v = Enumerable.Range(1, kol).OrderBy(x => rnd.Next()).ToArray();
                    query = "SELECT * FROM Игра2_Си WHERE Код = " + v[i] + ""; 
                }
                
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Код_с_ошибкой"].ToString() != "") { textBox2.Text =(reader["Код_с_ошибкой"].ToString()); }
                    label6.Text = reader["Задание"].ToString();
                    label7.Text = reader["Номер_строки"].ToString();
                    label10.Text = reader["Код_с_ошибкой"].ToString();
                    label11.Text = reader["Код_без_ошибки"].ToString();
                }
                i++;
                reader.Close();
                con.Close();
            }
            else { MessageBox.Show("Выберите язык программирования и сложность!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;}
        }       
        private void button3_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "")
                {
                    bool res = Int32.TryParse(textBox1.Text, out number);
                    if (res)
                    {
                    if (Int32.Parse(textBox1.Text) == Int32.Parse(label7.Text)) { ball++; }
                         if (i != kol)
                         {
                        
                            textBox1.Clear();
                            con.Open();
                            OleDbCommand command = new OleDbCommand();
                            command.Connection = con;
                            if (checkBox1.Checked) { command.CommandText = "SELECT * FROM Игра2_Паск WHERE Код = " + v[i] + "";  }
                            if (checkBox2.Checked) { command.CommandText = "SELECT * FROM Игра2_Си WHERE Код = " + v[i] + ""; }
                            
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                if (reader["Код_с_ошибкой"].ToString() != "") { textBox2.Text = (reader["Код_с_ошибкой"].ToString()); }
                                label6.Text = reader["Задание"].ToString();
                                label7.Text = reader["Номер_строки"].ToString();
                                
                            }
                            
                            i++;
                            reader.Close();
                            con.Close();
                         }

                        else
                        {
                        timer1.Stop();
                        if (ball > Rec2.rec2) { Rec2.rec2 = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                            else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                            Games f = new Games();
                            this.Hide();
                            f.Show();
                            if (curBall == "")
                            {
                                con.Open();
                                OleDbCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "insert into Рекорды(КодПользователя, КодИгры, КоличествоБаллов) values('" + Data4.Kod + "','" + 2 + "','" + ball + "')";
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                            {
                                if (ball > Convert.ToInt32(curBall))
                                {
                                    int n = Convert.ToInt32(ball);
                                    con.Open();
                                    OleDbCommand cmd = con.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "UPDATE Рекорды SET КоличествоБаллов = " + n + " WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 2";
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите число!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; 
                    }
                    
            }
             else 
             {
                 MessageBox.Show("Введите номер строки!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
             }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != label10.Text)
            {
                if (textBox2.Text == label11.Text) {
                    ball++; 
                  
                }
                if (i != kol)
                {
                  
                    textBox1.Clear();
                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = con;
                    if (checkBox1.Checked) { command.CommandText = "SELECT * FROM Игра2_Паск WHERE Код = " + v[i] + ""; }
                    if (checkBox2.Checked) { command.CommandText = "SELECT * FROM Игра2_Си WHERE Код = " + v[i] + ""; }

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox2.Text = (reader["Код_с_ошибкой"].ToString());
                        label6.Text = reader["Задание"].ToString();
                        label7.Text = reader["Номер_строки"].ToString();
                        label10.Text = reader["Код_с_ошибкой"].ToString();
                        label11.Text = reader["Код_без_ошибки"].ToString();
                    }
                    i++;
                    reader.Close();
                    con.Close();
                }
                else
                {
                    timer1.Stop();
                    if (ball > Rec2.rec2) { Rec2.rec2 = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    Games f = new Games();
                    this.Hide();
                    f.Show();
                    if (curBall == "")
                    {
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Рекорды(КодПользователя, КодИгры, КоличествоБаллов) values('" + Data4.Kod + "','" + 2 + "','" + ball + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        if (ball > Convert.ToInt32(curBall))
                        {
                            int n = Convert.ToInt32(ball);
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE Рекорды SET КоличествоБаллов = " + n + " WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 2";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Исправте код!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
        }
        
            private void Game2_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (t > 0)
            {
                t--;
                label13.Text = t.ToString() + " сек";
            }
            else
            {
                timer1.Stop();
                if (checkBox3.Checked)
                {
                    if (ball > Rec2.rec2) { Rec2.rec2 = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    Games f = new Games();
                    this.Hide();
                    f.Show();
                    if (curBall == "")
                    {
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Рекорды(КодПользователя, КодИгры, КоличествоБаллов) values('" + Data4.Kod + "','" + 2 + "','" + ball + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        if (ball > Convert.ToInt32(curBall))
                        {
                            int n = Convert.ToInt32(ball);
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE Рекорды SET КоличествоБаллов = " + n + " WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 2";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                else
                {
                    if (ball > Rec2.rec2) { Rec2.rec2 = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    Games f = new Games();
                    this.Hide();
                    f.Show();
                    if (curBall == "")
                    {
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Рекорды(КодПользователя, КодИгры, КоличествоБаллов) values('" + Data4.Kod + "','" + 2 + "','" + ball + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        if (ball > Convert.ToInt32(curBall))
                        {
                            int n = Convert.ToInt32(ball);
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE Рекорды SET КоличествоБаллов = " + n + " WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 2";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
        }
    }
}

