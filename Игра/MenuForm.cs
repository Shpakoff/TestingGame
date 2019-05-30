using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Игра
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            menuWeb1.Dock = DockStyle.Fill;

            menuWeb1.BringToFront();

        }
        readonly Image image1 = Image.FromFile("images/icons8-уменьшить-64.png");
        readonly Image image2 = Image.FromFile("images/icons8-расширить-64.png");
        readonly Image image3 = Image.FromFile("images/icons8-средняя-громкость-64.png");
        readonly Image image4 = Image.FromFile("images/icons8-выключить-звук-64.png");
        readonly OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        TreeNode nod;
        readonly OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Info.accdb");
        private void Button1_Click(object sender, EventArgs e)
        {
            if (idGame == 1)
            {
                menuGame11.bunifuThinButton22.Visible = true;
                menuGame11.bunifuThinButton21.Visible = false;
                menuGame11.comboBox1.Visible = true;
                menuGame11.label1.Visible = true;
                menuGame11.bunifuCheckbox1.Visible = false;
                menuGame11.bunifuCheckbox2.Visible = false;
                menuGame11.bunifuCheckbox3.Visible = false;
                menuGame11.bunifuCheckbox4.Visible = false;
                menuGame11.label4.Visible = false;
                menuGame11.label5.Visible = false;
                menuGame11.label6.Visible = false;
                menuGame11.label7.Visible = false;
                timer1.Enabled = false;
                menuGame11.label3.Visible = false;
                pictureBox3.Visible = false;
            }

            button7.Visible = false;
            WindowState = FormWindowState.Normal;
            menuChangeGames1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (idGame == 1)
            {
                menuGame11.bunifuThinButton22.Visible = true;
                menuGame11.bunifuThinButton21.Visible = false;
                menuGame11.comboBox1.Visible = true;
                menuGame11.label1.Visible = true;
                menuGame11.bunifuCheckbox1.Visible = false;
                menuGame11.bunifuCheckbox2.Visible = false;
                menuGame11.bunifuCheckbox3.Visible = false;
                menuGame11.bunifuCheckbox4.Visible = false;
                menuGame11.label4.Visible = false;
                menuGame11.label5.Visible = false;
                menuGame11.label6.Visible = false;
                menuGame11.label7.Visible = false;
                timer1.Enabled = false;
                menuGame11.label3.Visible = false;
                pictureBox3.Visible = false;
            }

            button7.Visible = false;
            WindowState = FormWindowState.Normal;
            menuTheory1.treeView1.Nodes.Clear();
            con1.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Раздел,Главы WHERE Код = КодРаздела", con1);
            da.Fill(dt);
            string ssss = "";
            int n = 1;
            foreach (DataRow dr in dt.Rows)
            {

                if (ssss != dr["НазваниеРаздела"].ToString())
                {
                    nod = new TreeNode(dr["НазваниеРаздела"].ToString());
                    ssss = dr["НазваниеРаздела"].ToString();
                    menuTheory1.treeView1.Nodes.Add(nod);
                }
                nod.Nodes.Add(dr["Название"].ToString()).Tag = n;
                n++;
            }
            con1.Close();
            menuTheory1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (idGame == 1)
            {
                menuGame11.bunifuThinButton22.Visible = true;
                menuGame11.bunifuThinButton21.Visible = false;
                menuGame11.comboBox1.Visible = true;
                menuGame11.label1.Visible = true;
                menuGame11.bunifuCheckbox1.Visible = false;
                menuGame11.bunifuCheckbox2.Visible = false;
                menuGame11.bunifuCheckbox3.Visible = false;
                menuGame11.bunifuCheckbox4.Visible = false;
                menuGame11.label4.Visible = false;
                menuGame11.label5.Visible = false;
                menuGame11.label6.Visible = false;
                menuGame11.label7.Visible = false;
                timer1.Enabled = false;
                menuGame11.label3.Visible = false;
                pictureBox3.Visible = false;
            }

            button7.Visible = false;
            WindowState = FormWindowState.Normal;
            menuSettings1.bunifuMaterialTextbox1.Text = Data2.Login;
            menuSettings1.bunifuMaterialTextbox2.Text = Data.Name;
            menuSettings1.bunifuMaterialTextbox3.Text = Data3.Password;
            menuSettings1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (idGame == 1)
            {
                menuGame11.bunifuThinButton22.Visible = true;
                menuGame11.bunifuThinButton21.Visible = false;
                menuGame11.comboBox1.Visible = true;
                menuGame11.label1.Visible = true;
                menuGame11.bunifuCheckbox1.Visible = false;
                menuGame11.bunifuCheckbox2.Visible = false;
                menuGame11.bunifuCheckbox3.Visible = false;
                menuGame11.bunifuCheckbox4.Visible = false;
                menuGame11.label4.Visible = false;
                menuGame11.label5.Visible = false;
                menuGame11.label6.Visible = false;
                menuGame11.label7.Visible = false;
                timer1.Enabled = false;
                menuGame11.label3.Visible = false;
                pictureBox3.Visible = false;
            }

            button7.Visible = false;
            WindowState = FormWindowState.Normal;
            menuRecords1.bunifuCustomDataGrid1.Rows.Clear();
            menuRecords1.bunifuCustomDataGrid2.Rows.Clear();
            con.Open();
            OleDbCommand thisCommand1 = con.CreateCommand();
            {
                thisCommand1.CommandText = "SELECT * FROM Рекорды,Пользователи WHERE КодПользователя = Код AND КодИгры = 1";
                OleDbDataReader thisReader = thisCommand1.ExecuteReader();
                while (thisReader.Read())
                {
                    menuRecords1.bunifuCustomDataGrid1.Rows.Add(thisReader["Имя"].ToString(), thisReader["КоличествоБаллов"]);
                }
                thisReader.Close();
            }

            OleDbCommand thisCommand2 = con.CreateCommand();

            {
                thisCommand2.CommandText = "SELECT * FROM Рекорды,Пользователи WHERE КодПользователя = Код AND КодИгры = 2";
                OleDbDataReader thisReader1 = thisCommand2.ExecuteReader();
                while (thisReader1.Read())
                {
                    menuRecords1.bunifuCustomDataGrid2.Rows.Add(thisReader1["Имя"].ToString(), thisReader1["КоличествоБаллов"]);
                }
                thisReader1.Close();
            }
            con.Close();
            menuRecords1.bunifuCustomDataGrid1.Sort(menuRecords1.bunifuCustomDataGrid1.Columns[1], ListSortDirection.Descending);
            menuRecords1.bunifuCustomDataGrid2.Sort(menuRecords1.bunifuCustomDataGrid2.Columns[1], ListSortDirection.Descending);
            menuRecords1.BringToFront();
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (idGame == 1)
            {
                menuGame11.bunifuThinButton22.Visible = true;
                menuGame11.bunifuThinButton21.Visible = false;
                menuGame11.comboBox1.Visible = true;
                menuGame11.label1.Visible = true;
                menuGame11.bunifuCheckbox1.Visible = false;
                menuGame11.bunifuCheckbox2.Visible = false;
                menuGame11.bunifuCheckbox3.Visible = false;
                menuGame11.bunifuCheckbox4.Visible = false;
                menuGame11.label4.Visible = false;
                menuGame11.label5.Visible = false;
                menuGame11.label6.Visible = false;
                menuGame11.label7.Visible = false;
                timer1.Enabled = false;
                menuGame11.label3.Visible = false;
                pictureBox3.Visible = false;
            }

            button7.Visible = true;
            if (WindowState == FormWindowState.Maximized)
            {
                button7.BackgroundImage = image1;
            }
            else
            {
                button7.BackgroundImage = image2;
            }
            menuWeb1.BringToFront();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                button7.BackgroundImage = image1;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                button7.BackgroundImage = image2;
                WindowState = FormWindowState.Normal;
            }
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void MenuSettings1_ClickDownload(object sender, EventArgs e)
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

        private void MenuSettings1_ClickToChange(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(menuSettings1.bunifuMaterialTextbox2.Text))
            {
                MessageBox.Show("Введите имя!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menuSettings1.bunifuMaterialTextbox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(menuSettings1.bunifuMaterialTextbox1.Text))
            {
                MessageBox.Show("Введите логин!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menuSettings1.bunifuMaterialTextbox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(menuSettings1.bunifuMaterialTextbox3.Text))
            {
                MessageBox.Show("Введите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menuSettings1.bunifuMaterialTextbox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(menuSettings1.bunifuMaterialTextbox4.Text))
            {
                MessageBox.Show("Подтвердите пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menuSettings1.bunifuMaterialTextbox4.Focus();
                return;
            }

            if (Data2.Login != "admin" && menuSettings1.bunifuMaterialTextbox1.Text == "admin") { MessageBox.Show("Этот логин использует админ, попробуйте другой.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (menuSettings1.bunifuMaterialTextbox3.Text == menuSettings1.bunifuMaterialTextbox4.Text)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Пользователи set Имя = '" + menuSettings1.bunifuMaterialTextbox2.Text + "', Логин = '" + menuSettings1.bunifuMaterialTextbox1.Text + "', Пароль = '" + menuSettings1.bunifuMaterialTextbox3.Text + "' Where Имя = '" + Data.Name + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Data.Name = menuSettings1.bunifuMaterialTextbox2.Text;
                    Data2.Login = menuSettings1.bunifuMaterialTextbox1.Text;
                    Data3.Password = menuSettings1.bunifuMaterialTextbox3.Text;
                    MessageBox.Show("Вы успешно изменили данные!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else { MessageBox.Show("Неверное подтверждение пароля!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (music.player.settings.volume != 0)
            {
                pictureBox2.BackgroundImage = image4;
                music.player.settings.volume = 0;
            }
            else
            {
                pictureBox2.BackgroundImage = image3;
                music.player.settings.volume = 50;
            }
        }

        private void MenuTheory1_TreeViewAfterSelect(object sender, EventArgs e)
        {
            int NumberI = 0;
            con1.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select КодГлавы,Путь From Главы ", con1);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["КодГлавы"]) == Convert.ToInt32(sender)) { menuTheory1.richTextBox1.LoadFile("docs/" + dr["Путь"].ToString() + ""); }
                NumberI++;
            }
            con1.Close();
        }
        double ball = 0;
        int kol = 0;
        int[] v;
        int i = 0;
        int t = 0;
        string curBall = "";
        int n = 0;
        int prov = 0;

        private void MenuChangeGames1_ClickFirstGame(object sender, EventArgs e)
        {

            menuGame11.BringToFront();

            menuGame11.label2.MaximumSize = new Size(600, 0);
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

        private void MenuChangeGames1_ClickSecondGame(object sender, EventArgs e)
        {
            menuChangeGame21.BringToFront();
        }

        private void MenuGame11_CLickNext(object sender, EventArgs e)
        {
            menuGame11.label8.Visible = false;
            menuGame11.label9.Visible = false;
            menuGame11.label10.Visible = false;
            menuGame11.label11.Visible = false;
            if ((menuGame11.bunifuCheckbox1.Checked && menuGame11.bunifuCheckbox2.Checked && menuGame11.bunifuCheckbox3.Checked == false && menuGame11.bunifuCheckbox4.Checked == false) || (menuGame11.bunifuCheckbox1.Checked && menuGame11.bunifuCheckbox3.Checked && menuGame11.bunifuCheckbox2.Checked == false && menuGame11.bunifuCheckbox4.Checked == false)
                || (menuGame11.bunifuCheckbox1.Checked && menuGame11.bunifuCheckbox4.Checked && menuGame11.bunifuCheckbox2.Checked == false && menuGame11.bunifuCheckbox3.Checked == false) || (menuGame11.bunifuCheckbox2.Checked && menuGame11.bunifuCheckbox3.Checked && menuGame11.bunifuCheckbox1.Checked == false && menuGame11.bunifuCheckbox4.Checked == false)
                || (menuGame11.bunifuCheckbox2.Checked && menuGame11.bunifuCheckbox4.Checked && menuGame11.bunifuCheckbox1.Checked == false && menuGame11.bunifuCheckbox3.Checked == false) || (menuGame11.bunifuCheckbox3.Checked && menuGame11.bunifuCheckbox4.Checked && menuGame11.bunifuCheckbox1.Checked == false && menuGame11.bunifuCheckbox2.Checked == false)
                || (menuGame11.bunifuCheckbox1.Checked && menuGame11.bunifuCheckbox2.Checked == false && menuGame11.bunifuCheckbox3.Checked == false && menuGame11.bunifuCheckbox4.Checked == false)
                || (menuGame11.bunifuCheckbox2.Checked && menuGame11.bunifuCheckbox1.Checked == false && menuGame11.bunifuCheckbox3.Checked == false && menuGame11.bunifuCheckbox4.Checked == false)
                || (menuGame11.bunifuCheckbox3.Checked && menuGame11.bunifuCheckbox1.Checked == false && menuGame11.bunifuCheckbox2.Checked == false && menuGame11.bunifuCheckbox4.Checked == false)
                || (menuGame11.bunifuCheckbox4.Checked && menuGame11.bunifuCheckbox1.Checked == false && menuGame11.bunifuCheckbox2.Checked == false && menuGame11.bunifuCheckbox3.Checked == false))
            {
                if (menuGame11.bunifuCheckbox1.Checked && (menuGame11.label8.Text != "")) { ball += Convert.ToInt32(menuGame11.label8.Text); }
                if (menuGame11.bunifuCheckbox2.Checked && (menuGame11.label9.Text != "")) { ball += Convert.ToInt32(menuGame11.label9.Text); }
                if (menuGame11.bunifuCheckbox3.Checked && (menuGame11.label10.Text != "")) { ball += Convert.ToInt32(menuGame11.label10.Text); }
                if (menuGame11.bunifuCheckbox4.Checked && (menuGame11.label11.Text != "")) { ball += Convert.ToInt32(menuGame11.label11.Text); }
                menuGame11.bunifuCheckbox1.Checked = false; menuGame11.bunifuCheckbox2.Checked = false; menuGame11.bunifuCheckbox3.Checked = false; menuGame11.bunifuCheckbox4.Checked = false;
                if (i != kol)
                {
                    con.Open();
                    OleDbCommand thisCommand = con.CreateCommand();
                    thisCommand.CommandText = "SELECT Вопрос, Ответ1, Ответ2, Ответ3, Ответ4, Балл1, Балл2, Балл3, Балл4 FROM Игра1 WHERE Код = " + v[i] + "";
                    OleDbDataReader thisReader = thisCommand.ExecuteReader();
                    while (thisReader.Read())
                    {
                        menuGame11.label2.Text = thisReader["Вопрос"].ToString();
                        menuGame11.label4.Text = thisReader["Ответ1"].ToString();
                        menuGame11.label5.Text = thisReader["Ответ2"].ToString();
                        menuGame11.label6.Text = thisReader["Ответ3"].ToString();
                        menuGame11.label7.Text = thisReader["Ответ4"].ToString();
                        menuGame11.label8.Text = thisReader["Балл1"].ToString();
                        menuGame11.label9.Text = thisReader["Балл2"].ToString();
                        menuGame11.label10.Text = thisReader["Балл3"].ToString();
                        menuGame11.label11.Text = thisReader["Балл4"].ToString();
                    }

                    i++;
                    thisReader.Close();
                    con.Close();
                }
                else
                {
                    menuGame11.bunifuThinButton22.Visible = true;
                    menuGame11.bunifuThinButton21.Visible = false;
                    menuGame11.comboBox1.Visible = true;
                    menuGame11.label1.Visible = true;
                    menuGame11.bunifuCheckbox1.Visible = false;
                    menuGame11.bunifuCheckbox2.Visible = false;
                    menuGame11.bunifuCheckbox3.Visible = false;
                    menuGame11.bunifuCheckbox4.Visible = false;
                    menuGame11.label4.Visible = false;
                    menuGame11.label5.Visible = false;
                    menuGame11.label6.Visible = false;
                    menuGame11.label7.Visible = false;
                    timer1.Enabled = false;
                    menuGame11.label3.Visible = false;
                    menuChangeGames1.BringToFront();
                    pictureBox3.Visible = false;
                    if (ball > Rec.rec) { Rec.rec = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec.rec + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec.rec + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
            else { MessageBox.Show("Выберите один или два варианта ответа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void MenuGame11_CLickOk(object sender, EventArgs e)
        {
            idGame = 1;
            pictureBox3.Visible = true;
            switch (menuGame11.comboBox1.Text)
            {
                case "Без времени":
                    break;
                case "1 мин":
                    t = 60;
                    timer1.Enabled = true;
                    menuGame11.label3.Visible = true;
                    menuGame11.label3.Text = t.ToString() + " сек";
                    break;
                case "5 мин":
                    t = 300;
                    timer1.Enabled = true;
                    menuGame11.label3.Visible = true;
                    menuGame11.label3.Text = t.ToString() + " сек";
                    break;
                case "10 мин":
                    t = 600;
                    timer1.Enabled = true;
                    menuGame11.label3.Visible = true;
                    menuGame11.label3.Text = t.ToString() + " сек";
                    break;
                case "15 мин":
                    t = 900;
                    timer1.Enabled = true;
                    menuGame11.label3.Visible = true;
                    menuGame11.label3.Text = t.ToString() + " сек";
                    break;
                case "20 мин":
                    t = 1200;
                    timer1.Enabled = true;
                    menuGame11.label3.Visible = true;
                    menuGame11.label3.Text = t.ToString() + " сек";
                    break;
                default:
                    MessageBox.Show("Выбирете временной режим");
                    return;

            }

            menuGame11.label1.Visible = false;
            menuGame11.bunifuCheckbox1.Visible = true;
            menuGame11.bunifuCheckbox2.Visible = true;
            menuGame11.bunifuCheckbox3.Visible = true;
            menuGame11.bunifuCheckbox4.Visible = true;
            menuGame11.label4.Visible = true;
            menuGame11.label5.Visible = true;
            menuGame11.label6.Visible = true;
            menuGame11.label7.Visible = true;
            con.Open();
            OleDbCommand thisCommand = con.CreateCommand();
            thisCommand.CommandText = "SELECT Вопрос, Ответ1, Ответ2, Ответ3, Ответ4 FROM Игра1 WHERE Код = " + v[i] + "";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                menuGame11.label2.Text = thisReader["Вопрос"].ToString();
                menuGame11.label4.Text = thisReader["Ответ1"].ToString();
                menuGame11.label5.Text = thisReader["Ответ2"].ToString();
                menuGame11.label6.Text = thisReader["Ответ3"].ToString();
                menuGame11.label7.Text = thisReader["Ответ4"].ToString();
            }
            i++;
            thisReader.Close();
            con.Close();
            menuGame11.bunifuThinButton22.Visible = false;
            menuGame11.bunifuThinButton21.Visible = true;
            menuGame11.comboBox1.Visible = false;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (idGame == 1)
            {
                menuGame11.bunifuThinButton22.Visible = true;
                menuGame11.bunifuThinButton21.Visible = false;
                menuGame11.comboBox1.Visible = true;
                menuGame11.label1.Visible = true;
                menuGame11.bunifuCheckbox1.Visible = false;
                menuGame11.bunifuCheckbox2.Visible = false;
                menuGame11.bunifuCheckbox3.Visible = false;
                menuGame11.bunifuCheckbox4.Visible = false;
                menuGame11.label4.Visible = false;
                menuGame11.label5.Visible = false;
                menuGame11.label6.Visible = false;
                menuGame11.label7.Visible = false;
                timer1.Enabled = false;
                menuGame11.label3.Visible = false;
                pictureBox3.Visible = false;
                menuChangeGames1.BringToFront();
            }
            if (idGame == 2)
            {
                menuChangeGame21.BringToFront();
                timer1.Enabled = false;
                pictureBox3.Visible = false;
            }

        }
        int idGame = -1;
        int idGame2 = -1;
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            t--;
            if (idGame == 1)
            {
                menuGame11.label3.Text = t.ToString() + " сек";
            }
            if (idGame == 2)
            {
                menuGame21.label3.Text = t.ToString() + " сек";
            }
            if (t == 0 && idGame == 1)
            {
                menuGame11.bunifuThinButton22.Visible = true;
                menuGame11.bunifuThinButton21.Visible = false;
                menuGame11.comboBox1.Visible = true;
                menuGame11.label1.Visible = true;
                menuGame11.bunifuCheckbox1.Visible = false;
                menuGame11.bunifuCheckbox2.Visible = false;
                menuGame11.bunifuCheckbox3.Visible = false;
                menuGame11.bunifuCheckbox4.Visible = false;
                menuGame11.label4.Visible = false;
                menuGame11.label5.Visible = false;
                menuGame11.label6.Visible = false;
                menuGame11.label7.Visible = false;
                timer1.Enabled = false;
                menuGame11.label3.Visible = false;
                menuChangeGames1.BringToFront();
                pictureBox3.Visible = false;
                if (ball > Rec.rec) { Rec.rec = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec.rec + "", "Время вышло!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec.rec + "", "Время вышло!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
            if (t == 0 && idGame == 2)
            {
                timer1.Stop();
                if (menuChangeGame21.bunifuiOSSwitch3.Value == true)
                {
                    if (ball > Rec2.rec2) { Rec2.rec2 = ball; MessageBox.Show("Счет игры \nВы побили рекорд набрав " + ball + " баллов!\nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else { MessageBox.Show("Счет игры \nВы набрали " + ball + " баллов \nРекорд: " + Rec2.rec2 + "", "Игра окончена!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    menuChangeGame21.BringToFront();
                    pictureBox3.Visible = false;
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
                    menuChangeGame21.BringToFront();
                    pictureBox3.Visible = false;
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

        private void MenuChangeGame21_Click_Ok_ChangeGame2(object sender, EventArgs e)
        {

            ball = 0;
            kol = 0;
            i = 0;
            t = 0;
            curBall = "";
            n = 0;
            prov = 0;
            string query = "";
            idGame = 2;
            pictureBox3.Visible = true;
            if ((menuChangeGame21.bunifuiOSSwitch1.Value == true || menuChangeGame21.bunifuiOSSwitch2.Value == true) && (menuChangeGame21.bunifuiOSSwitch3.Value == true || menuChangeGame21.bunifuiOSSwitch4.Value == true))
            {

                if (menuChangeGame21.bunifuiOSSwitch3.Value == true)
                {
                    idGame2 = 1;
                    switch (menuChangeGame21.comboBox1.Text)
                    {
                        case "Без времени":
                            menuGame21.bunifuCustomTextbox1.ReadOnly = true; menuGame21.label3.Visible = false; menuGame21.bunifuMaterialTextbox1.Visible = true;
                            break;
                        case "1 мин":
                            t = 60;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = true; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = true; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "5 мин":
                            t = 300;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = true; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = true; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "10 мин":
                            t = 600;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = true; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = true; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "15 мин":
                            t = 900;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = true; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = true; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "20 мин":
                            t = 1200;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = true; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = true; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        default:
                            MessageBox.Show("Выбирете временной режим");
                            return;
                    }
                }
                if (menuChangeGame21.bunifuiOSSwitch4.Value == true)
                {
                    idGame2 = 2;
                    switch (menuChangeGame21.comboBox1.Text)
                    {
                        case "Без времени":
                            menuGame21.bunifuCustomTextbox1.ReadOnly = false; menuGame21.label3.Visible = false; menuGame21.bunifuMaterialTextbox1.Visible = false;
                            break;
                        case "1 мин":
                            t = 60;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = false; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = false; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "5 мин":
                            t = 300;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = false; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = false; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "10 мин":
                            t = 600;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = false; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = false; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "15 мин":
                            t = 900;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = false; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = false; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        case "20 мин":
                            t = 1200;
                            menuGame21.bunifuCustomTextbox1.ReadOnly = false; menuGame21.label3.Visible = true; menuGame21.bunifuMaterialTextbox1.Visible = false; timer1.Enabled = true; timer1.Start(); menuGame21.label3.Text = t.ToString() + " сек";
                            break;
                        default:
                            MessageBox.Show("Выбирете временной режим");
                            return;
                    }
                }
                con.Open();
                OleDbCommand command = new OleDbCommand
                {
                    Connection = con
                };
                if (menuChangeGame21.bunifuiOSSwitch1.Value == true)
                {
                    Random rnd = new Random();
                    OleDbCommand thisCommand1 = con.CreateCommand();
                    thisCommand1.CommandText = "SELECT COUNT(*) FROM Игра2_Паск";
                    int id = Convert.ToInt32(thisCommand1.ExecuteScalar());
                    kol = id;
                    v = Enumerable.Range(1, kol).OrderBy(x => rnd.Next()).ToArray();
                    query = "SELECT * FROM Игра2_Паск WHERE Код = " + v[i] + "";
                }
                if (menuChangeGame21.bunifuiOSSwitch2.Value == true)
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
                    if (reader["Код_с_ошибкой"].ToString() != "") { menuGame21.bunifuCustomTextbox1.Text = (reader["Код_с_ошибкой"].ToString()); }

                    menuGame21.label2.Text = reader["Задание"].ToString();
                    menuGame21.label4.Text = reader["Номер_строки"].ToString();
                    menuGame21.label5.Text = reader["Код_с_ошибкой"].ToString();
                    menuGame21.label6.Text = reader["Код_без_ошибки"].ToString();
                }
                i++;
                reader.Close();
                con.Close();
            }
            else { MessageBox.Show("Выберите язык программирования и сложность!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            menuGame21.BringToFront();
        }
        int number;
        private void MenuGame21_Click_Next_Game2(object sender, EventArgs e)
        {
            if (idGame2 == 2)
            {
                if (menuGame21.bunifuCustomTextbox1.Text != menuGame21.label5.Text)
                {
                    if (menuGame21.bunifuCustomTextbox1.Text == menuGame21.label6.Text)
                    {
                        ball++;

                    }
                    if (i != kol)
                    {

                        menuGame21.bunifuCustomTextbox1.Clear();
                        con.Open();
                        OleDbCommand command = new OleDbCommand
                        {
                            Connection = con
                        };
                        if (menuChangeGame21.bunifuiOSSwitch1.Value == true) { command.CommandText = "SELECT * FROM Игра2_Паск WHERE Код = " + v[i] + ""; }
                        if (menuChangeGame21.bunifuiOSSwitch2.Value == true) { command.CommandText = "SELECT * FROM Игра2_Си WHERE Код = " + v[i] + ""; }

                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            menuGame21.bunifuCustomTextbox1.Text = (reader["Код_с_ошибкой"].ToString());
                            menuGame21.label2.Text = reader["Задание"].ToString();
                            menuGame21.label4.Text = reader["Номер_строки"].ToString();
                            menuGame21.label5.Text = reader["Код_с_ошибкой"].ToString();
                            menuGame21.label6.Text = reader["Код_без_ошибки"].ToString();
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
                        menuChangeGame21.BringToFront();
                        pictureBox3.Visible = false;
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

            if (idGame2 == 1)
            {
                if (menuGame21.bunifuMaterialTextbox1.Text != "")
                {
                    bool res = Int32.TryParse(menuGame21.bunifuMaterialTextbox1.Text, out number);
                    if (res)
                    {
                        if (Int32.Parse(menuGame21.bunifuMaterialTextbox1.Text) == Int32.Parse(menuGame21.label4.Text)) { ball++; }
                        if (i != kol)
                        {

                            menuGame21.bunifuCustomTextbox1.Clear();
                            con.Open();
                            OleDbCommand command = new OleDbCommand
                            {
                                Connection = con
                            };
                            if (menuChangeGame21.bunifuiOSSwitch1.Value == true) { command.CommandText = "SELECT * FROM Игра2_Паск WHERE Код = " + v[i] + ""; }
                            if (menuChangeGame21.bunifuiOSSwitch2.Value == true) { command.CommandText = "SELECT * FROM Игра2_Си WHERE Код = " + v[i] + ""; }

                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                if (reader["Код_с_ошибкой"].ToString() != "") { menuGame21.bunifuCustomTextbox1.Text = (reader["Код_с_ошибкой"].ToString()); }
                                menuGame21.label2.Text = reader["Задание"].ToString();
                                menuGame21.label4.Text = reader["Номер_строки"].ToString();

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
                            menuChangeGame21.BringToFront();
                            pictureBox3.Visible = false;
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
        }
    }
}
