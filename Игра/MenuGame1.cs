using System;
using System.Windows.Forms;

namespace Игра
{
    public partial class MenuGame1 : UserControl
    {
        public MenuGame1()
        {
            InitializeComponent();
        }
        public event EventHandler CLickOk;
        public event EventHandler CLickNext;
        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            CLickOk?.Invoke(this, e);
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            CLickNext?.Invoke(this, e);
        }
    }
}
