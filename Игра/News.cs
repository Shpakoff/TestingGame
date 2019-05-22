using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class News : Form
    {
        public News()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show();
        }

        private void News_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
