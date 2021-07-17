using AZORD_CANTINE.USERCONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZORD_CANTINE
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE.LOGIN(USERNAME, PASSWORD);
            //new AZORD_CANTINE.USERCONTROL.DASHBOARD().Show();
          
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
