using System;
using System.Windows.Forms;

namespace Игра
{
    public partial class MenuChangeGame2 : UserControl
    {
        public MenuChangeGame2()
        {
            InitializeComponent();
        }
        public event EventHandler Click_Ok_ChangeGame2;
        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Click_Ok_ChangeGame2?.Invoke(this, e);
        }

        private void BunifuiOSSwitch1_Click(object sender, EventArgs e)
        {
            bunifuiOSSwitch1.Value = true;
            bunifuiOSSwitch2.Value = false;
        }

        private void BunifuiOSSwitch2_Click(object sender, EventArgs e)
        {
            bunifuiOSSwitch1.Value = false;
            bunifuiOSSwitch2.Value = true;
        }

        private void BunifuiOSSwitch3_Click(object sender, EventArgs e)
        {
            bunifuiOSSwitch3.Value = true;
            bunifuiOSSwitch4.Value = false;
        }

        private void BunifuiOSSwitch4_Click(object sender, EventArgs e)
        {
            bunifuiOSSwitch3.Value = false;
            bunifuiOSSwitch4.Value = true;
        }
    }
}
