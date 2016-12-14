using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myForm
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        public string sName => textBox.Text.Trim();

        private void pbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
