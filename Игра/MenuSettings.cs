using System;
using System.Windows.Forms;

namespace Игра
{
    public partial class MenuSettings : UserControl
    {
        public event EventHandler ClickDownload;

        public event EventHandler ClickToChange;

        public MenuSettings()
        {
            InitializeComponent();
        }

        public void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            ClickToChange?.Invoke(this, e);
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            ClickDownload?.Invoke(this, e);
        }
    }
}
