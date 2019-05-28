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
            button7.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
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
            button7.Visible = false;
            WindowState = FormWindowState.Normal;
            menuSettings1.bunifuMaterialTextbox1.Text = Data2.Login;
            menuSettings1.bunifuMaterialTextbox2.Text = Data.Name;
            menuSettings1.bunifuMaterialTextbox3.Text = Data3.Password;
            menuSettings1.BringToFront();
        }      

        private void Button4_Click(object sender, EventArgs e)
        {
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
            if(WindowState != FormWindowState.Maximized)
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
    }
}
