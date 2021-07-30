using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZORD_CANTINE.USERCONTROL
{
    public partial class DASHBOARD : Form
    {
        AZORD_CANTINE.DESIGN_CLASSES.DESIGN A = new AZORD_CANTINE.DESIGN_CLASSES.DESIGN();
        public DASHBOARD()
        {
            InitializeComponent();
        }
        public DASHBOARD(String username)
        {
            InitializeComponent();
            label2.Text =username;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
         //   A.APPEL_PANEL(new AZORD_CANTINE.USERCONTROL.ADDIND_STUDENT(),panel3);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            A.ButtonChanged(guna2Button1, guna2Button2, guna2Button3, guna2Button1);
             A.APPEL_PANEL(new AZORD_CANTINE.USERCONTROL.ADDIND_STUDENT(),panel3);
        
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            A.ButtonChanged(guna2Button1, guna2Button2, guna2Button3, guna2Button2);
            A.APPEL_PANEL(new AZORD_CANTINE.USERCONTROL.ABONNEMENT(), panel3);
         
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            A.APPEL_PANEL(new AZORD_CANTINE.USERCONTROL.PAIEMENTFRAIS(), panel3);
            A.ButtonChanged(guna2Button1, guna2Button2, guna2Button3, guna2Button3);
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            A.APPEL_PANEL(new AZORD_CANTINE.USERCONTROL.SALLE(), panel3);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            A.APPEL_PANEL(new AZORD_CANTINE.USERCONTROL.STOCK(), panel3);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            new AZORD_CANTINE.ABOUT_BOXES.TROMBIN().ShowDialog();
        }
    }
}
