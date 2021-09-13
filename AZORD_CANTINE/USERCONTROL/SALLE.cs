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
    public partial class SALLE : UserControl
    {
        AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE A = new AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE();
        AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE B = new AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE();
        
        public SALLE()
        {
            InitializeComponent();
            A.CHARGEMENT_COMBO(NIVEAU,""+B.NIVEAU);
            A.CHARGEMENT_COMBO(SECTION, "" + B.SECTION);
            //A.CHARGEMENT_COMBO()
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AZORD_CANTINE.boxe().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AZORD_CANTINE.ABOUT_BOXES.NOUVELLE_SECTION().ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            A.EXEC_UNIVERSELLE("NOUVEAU_SALLE", "'" + NIVEAU.SelectedItem.ToString() + "','" + SECTION.SelectedItem.ToString() + "','" + DESIGNATION.Text + "'", "SALLE AJOUTER");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
