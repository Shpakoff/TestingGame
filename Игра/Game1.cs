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
    public partial class Game1 : Form
    {
        double ball = 0;  
        int kol = 0;
        int[] v;
        int i=0;
        string[] f = new string[4];
        int t;
        string curBall = "";
        int n = 0;
        int prov = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        public Game1()
        {
            
            InitializeComponent();
            label2.MaximumSize = new Size(600, 0);
            label1.AutoSize = true;
            Random rnd = new Random();
            con.Open();
            OleDbCommand thisCommand1 = con.CreateCommand();
            thisCommand1.CommandText = "SELECT COUNT(*) FROM Рекорды WHERE КодИгры = 1";
            prov = Convert.ToInt32(thisCommand1.ExecuteScalar());
            thisCommand1.CommandText = "SELECT COUNT(*) FROM Игра1";
            int id = Convert.ToInt32(thisCommand1.ExecuteScalar());
            kol = id;
            v = Enumerable.Range(1, kol).OrderBy(x => rnd.Next()).ToArray();
            thisCommand1.CommandText = "SELECT КоличествоБаллов FROM Рекорды WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 1";
            curBall = Convert.ToString(thisCommand1.ExecuteScalar());
            if (prov != 0)
            {
                thisCommand1.CommandText = "SELECT MAX(КоличествоБаллов) FROM Рекорды WHERE КодИгры = 1";
                Rec.rec = Convert.ToDouble(thisCommand1.ExecuteScalar());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "Выход";    
            switch (comboBox1.Text)
            {
                case "Без времени":     
                    break;
                case "1 мин":
                    t = 60;
                    timer1.Enabled = true;
                    label8.Visible = true;
                    label3.Visible = true;
                    label3.Text = t.ToString() + " сек";
                    break;
                case "5 мин":
                    t = 300;
                    timer1.Enabled = true;
                    label8.Visible = true;
                    label3.Visible = true;
                    label3.Text = t.ToString() + " сек";
                    break;
                case "10 мин":
                    t = 600;
                    timer1.Enabled = true;
                    label8.Visible = true;
                    label3.Visible = true;
                    label3.Text = t.ToString() + " сек";
                    break;
                case "15 мин":
                    t = 900;
                    timer1.Enabled = true;
                    label8.Visible = true;
                    label3.Visible = true;
                    label3.Text = t.ToString() + " сек";
                    break;
                case "20 мин":
                    t = 1200;
                    timer1.Enabled = true;
                    label8.Visible = true;
                    label3.Visible = true;
                    label3.Text = t.ToString() + " сек";
                    break;
                default:
                    MessageBox.Show("Выбирете временной режим");
                    return;
                    
            }
            Random rnd = new Random();
            
            label1.Visible = false;
            button1.Text = "Далее";
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            con.Open();
            OleDbCommand thisCommand = con.CreateCommand();
            thisCommand.CommandText = "SELECT Вопрос, Ответ1, Ответ2, Ответ3, Ответ4 FROM Игра1 WHERE Код = " + v[i] + "";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                 label2.Text = thisReader["Вопрос"].ToString();                
                 checkBox2.Text = thisReader["Ответ1"].ToString();
                 checkBox3.Text = thisReader["Ответ2"].ToString();
                 checkBox4.Text = thisReader["Ответ3"].ToString();
                 checkBox5.Text = thisReader["Ответ4"].ToString();
            }
        i++;
        thisReader.Close();
        con.Close();
        button1.Visible = false;
        button3.Visible = true;
        comboBox1.Visible = false;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Games f = new Games();
            this.Hide();
            timer1.Enabled = false;
            f.Show();
        }

        private void Game1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            label3.Text = t.ToString() + " сек";
            if (t == 0) 
            { 
                timer1.Stop();
                if (ball > Rec.rec) { Rec.rec = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec.rec + "", "Время вышло!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec.rec + "", "Время вышло!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                Games f = new Games();
                this.Hide();
                f.Show();
                if (curBall == "") 
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Рекорды(КодПользователя, КодИгры, КоличествоБаллов) values('" + Data4.Kod + "','" + 1 + "','" + ball + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                    else
                        {
                            if (ball > Convert.ToInt32(curBall)) 
                            {
                                n = Convert.ToInt32(ball);
                                con.Open();
                                OleDbCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = cmd.CommandText = "UPDATE Рекорды SET КоличествоБаллов = " + n + " WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 1";
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            if ((checkBox2.Checked && checkBox3.Checked && checkBox4.Checked == false && checkBox5.Checked == false) || (checkBox2.Checked && checkBox4.Checked && checkBox3.Checked == false && checkBox5.Checked == false) 
                || (checkBox2.Checked && checkBox5.Checked && checkBox3.Checked == false && checkBox4.Checked == false) || (checkBox3.Checked && checkBox4.Checked && checkBox2.Checked == false && checkBox5.Checked == false)
                || (checkBox3.Checked && checkBox5.Checked && checkBox2.Checked == false && checkBox4.Checked == false) || (checkBox4.Checked && checkBox5.Checked && checkBox2.Checked == false && checkBox3.Checked == false) 
                || (checkBox2.Checked && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
                || (checkBox3.Checked && checkBox2.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false) 
                || (checkBox4.Checked && checkBox2.Checked == false && checkBox3.Checked == false && checkBox5.Checked == false)
                || (checkBox5.Checked && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false))
            {
                if (checkBox2.Checked && (label4.Text != "")) { ball = ball + Convert.ToInt32(label4.Text); }
                if (checkBox3.Checked && (label5.Text != "")) { ball = ball + Convert.ToInt32(label5.Text); }
                if (checkBox4.Checked && (label6.Text != "")) { ball = ball + Convert.ToInt32(label6.Text); }
                if (checkBox5.Checked && (label7.Text != "")) { ball = ball + Convert.ToInt32(label7.Text); }
                checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox5.Checked = false;
                if (i != kol)
                {
                    con.Open();
                    OleDbCommand thisCommand = con.CreateCommand();
                    thisCommand.CommandText = "SELECT Вопрос, Ответ1, Ответ2, Ответ3, Ответ4, Балл1, Балл2, Балл3, Балл4 FROM Игра1 WHERE Код = " + v[i] + "";
                    OleDbDataReader thisReader = thisCommand.ExecuteReader();
                    while (thisReader.Read())
                    {
                        label2.Text = thisReader["Вопрос"].ToString();
                        checkBox2.Text = thisReader["Ответ1"].ToString();
                        checkBox3.Text = thisReader["Ответ2"].ToString();
                        checkBox4.Text = thisReader["Ответ3"].ToString();
                        checkBox5.Text = thisReader["Ответ4"].ToString();
                        label4.Text = thisReader["Балл1"].ToString();
                        label5.Text = thisReader["Балл2"].ToString();
                        label6.Text = thisReader["Балл3"].ToString();
                        label7.Text = thisReader["Балл4"].ToString();                   
                    }

                    i++;
                    thisReader.Close();
                    con.Close();
                }
                else
                {
                    timer1.Stop();
                    if (ball > Rec.rec) { Rec.rec = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec.rec + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec.rec + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    Games f = new Games();
                    this.Hide();
                    f.Show();
                    if (curBall == "")
                    {
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Рекорды(КодПользователя, КодИгры, КоличествоБаллов) values('" + Data4.Kod + "','" + 1 + "','" + ball + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        if (ball > Convert.ToInt32(curBall))
                        {
                            n = Convert.ToInt32(ball);
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE Рекорды SET КоличествоБаллов = " + n + " WHERE КодПользователя = " + Data4.Kod + " AND КодИгры = 1";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                }
            else { MessageBox.Show("Выберите один или два варианта ответа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);  }
           
        }

        private void Game1_Load(object sender, EventArgs e)
        {

        }
    }
}
