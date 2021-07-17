using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZORD_CANTINE.USERCONTROL
{
    public partial class STOCK : UserControl
    {
        public STOCK()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new AZORD_CANTINE.ABOUT_BOXES.ADDPRODUIT().ShowDialog();
        }
    }
}
