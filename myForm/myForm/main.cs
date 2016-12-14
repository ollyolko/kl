using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace myForm
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            add addF = new add();
            if (addF.ShowDialog()==DialogResult.OK)
            {
                string str = addF.sName;
                if (str!= String.Empty)
                {
                    listView.Items.Add(str);
                }
            }
            
        }

        private void remouve_Click(object sender, EventArgs e)
        {
            while (listView.SelectedItems.Count>0)
            {
               listView.Items.Remove(listView.SelectedItems[0]);
            }
        }
    }
}
