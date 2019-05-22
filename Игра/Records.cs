﻿using System;
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
    public partial class Records : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        //OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Game.accdb");
        public Records()
        {
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand thisCommand1 = con.CreateCommand();
          //  thisCommand1.CommandText = "SELECT COUNT(*) FROM Рекорды WHERE КодИгры = 1";
           // int c = Convert.ToInt32(thisCommand1.ExecuteScalar());
            //for (int i = 1; i <= c; i++)
            { 
                        thisCommand1.CommandText = "SELECT * FROM Рекорды,Пользователи WHERE КодПользователя = Код AND КодИгры = 1";
                        OleDbDataReader thisReader = thisCommand1.ExecuteReader();
                        while (thisReader.Read())
                        {
                            dataGridView1.Rows.Add(thisReader["Имя"].ToString(), thisReader["КоличествоБаллов"]);
                        }
                        thisReader.Close();
            }
           // con.Close();
           // con1.Open();
            OleDbCommand thisCommand2 = con.CreateCommand();
          //  thisCommand2.CommandText = "SELECT COUNT(*) FROM Рекорды WHERE КодИгры = 2";
           //  int c2 = Convert.ToInt32(thisCommand2.ExecuteScalar());
         //   for (int i = 1; i <= c2; i++)
            {
                        thisCommand2.CommandText = "SELECT * FROM Рекорды,Пользователи WHERE КодПользователя = Код AND КодИгры = 2";
                        OleDbDataReader thisReader1 = thisCommand2.ExecuteReader();
                        while (thisReader1.Read())
                        {
                            dataGridView2.Rows.Add(thisReader1["Имя"].ToString(), thisReader1["КоличествоБаллов"]);
                        }
                        thisReader1.Close();
            }
            con.Close();
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show();
        }

        private void Records_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
