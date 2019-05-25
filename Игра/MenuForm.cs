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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            menuWeb1.Dock = DockStyle.Fill;
            menuRecords1.Dock = DockStyle.Fill;
            menuWeb1.BringToFront();

        }
        readonly Image image1 = Image.FromFile("images/icons8-уменьшить-64.png");
        readonly Image image2 = Image.FromFile("images/icons8-расширить-64.png");
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
        

        private void Button4_Click(object sender, EventArgs e)
        {          
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
    }
}
