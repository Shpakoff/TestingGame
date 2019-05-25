using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Игра.UserControls
{
    public partial class MenuRecords : UserControl
    {
   
        public MenuRecords()
        {
            InitializeComponent();
        }

        private void MenuRecords_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
        private string Path = null;
        public string PathString
        {
            get { return Path; }
            set { Path = value; }
        }
        private void LoadInfo()
        {
            if (Path != null)
            {
                OleDbConnection con = new OleDbConnection(Path.ToString());
                con.Open();
                OleDbCommand thisCommand1 = con.CreateCommand();

                {
                    thisCommand1.CommandText = "SELECT * FROM Рекорды,Пользователи WHERE КодПользователя = Код AND КодИгры = 1";
                    OleDbDataReader thisReader = thisCommand1.ExecuteReader();
                    while (thisReader.Read())
                    {
                        bunifuCustomDataGrid1.Rows.Add(thisReader["Имя"].ToString(), thisReader["КоличествоБаллов"]);
                    }
                    thisReader.Close();
                }

                OleDbCommand thisCommand2 = con.CreateCommand();

                {
                    thisCommand2.CommandText = "SELECT * FROM Рекорды,Пользователи WHERE КодПользователя = Код AND КодИгры = 2";
                    OleDbDataReader thisReader1 = thisCommand2.ExecuteReader();
                    while (thisReader1.Read())
                    {
                        bunifuCustomDataGrid2.Rows.Add(thisReader1["Имя"].ToString(), thisReader1["КоличествоБаллов"]);
                    }
                    thisReader1.Close();
                }
                con.Close();
                bunifuCustomDataGrid1.Sort(bunifuCustomDataGrid1.Columns[1], ListSortDirection.Descending);
                bunifuCustomDataGrid2.Sort(bunifuCustomDataGrid2.Columns[1], ListSortDirection.Descending);
            }
        }
    }
}
