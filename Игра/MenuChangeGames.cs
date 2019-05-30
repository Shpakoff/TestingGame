using System;
using System.Windows.Forms;

namespace Игра
{
    public partial class MenuChangeGames : UserControl
    {
        public MenuChangeGames()
        {
            InitializeComponent();
        }
        public event EventHandler ClickFirstGame;
        public event EventHandler ClickSecondGame;

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            ClickFirstGame?.Invoke(this, e);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            ClickSecondGame?.Invoke(this, e);
        }
    }
}
