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
    public partial class Theory : Form
    {
        int i = 0;

        TreeNode nod;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Info.accdb");
        public Theory()
        {

            InitializeComponent();
            if (Data2.Login == "admin") { button3.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show();
        }

        private void Theory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select КодГлавы,Путь From Главы ", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["КодГлавы"]) == Convert.ToInt32(e.Node.Tag)) { richTextBox1.LoadFile("docs/" + dr["Путь"].ToString() + ""); }
                i++;
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTheory f = new AddTheory();
            f.ShowDialog();
        }

        private void Theory_Activated(object sender, EventArgs e)
        {
        
            treeView1.Nodes.Clear();
            con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Раздел,Главы WHERE Код = КодРаздела", con);
            da.Fill(dt);
            string ssss="";
             int n = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    
                    if (ssss != dr["НазваниеРаздела"].ToString())
                    {
                        nod = new TreeNode(dr["НазваниеРаздела"].ToString());
                        ssss = dr["НазваниеРаздела"].ToString();
                        treeView1.Nodes.Add(nod);
                    }
                        nod.Nodes.Add(dr["Название"].ToString()).Tag = n;
                        n++;
                }
            con.Close();
        }

        private void Theory_Load(object sender, EventArgs e)
        {

        }
    }
}
