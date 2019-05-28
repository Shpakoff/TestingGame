using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class MenuTheory : UserControl
    {
        public MenuTheory()
        {
            InitializeComponent();
        }

        public event EventHandler TreeViewAfterSelect;
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int k = Convert.ToInt32(e.Node.Tag);
            TreeViewAfterSelect?.Invoke(k, e);
        }
    }
}
