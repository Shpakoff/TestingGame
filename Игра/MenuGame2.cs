using System;
using System.Windows.Forms;

namespace Игра
{
    public partial class MenuGame2 : UserControl
    {
        public MenuGame2()
        {
            InitializeComponent();
        }
        public event EventHandler Click_Next_Game2;

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Click_Next_Game2?.Invoke(this, e);
        }
    }
}
