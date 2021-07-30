using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZORD_CANTINE.ABOUT_BOXES
{
    partial class TROMBIN : Form
    {
        AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE A = new AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE();
        AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE B = new AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE();
        public TROMBIN()
        {
            InitializeComponent();
            A.CHARGEMENT_COMBO(NIVEAU, "" + B.NIVEAU_COMBO);
            
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            A.CHOISIR_IMAGE(pictureBox1);
        }

        private void SECTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(DESIGNATION, "" + B.DESIGNATION_COMBO + "" + NIVEAU.SelectedItem + " AND ABREVIATION='" + SECTION.SelectedItem + "'");
       
        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            SECTION.Items.Clear();
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(SECTION, "" + B.SECTION_COMBO + "" + NIVEAU.SelectedItem);
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
              
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "' AND CONCAT(NOM,' ',POSTNOM,' ',PRENOM) like '%" + guna2TextBox1.Text + "%'");
           
        }

        private void TABLEELEVE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MATRICULE.Text = TABLEELEVE.CurrentRow.Cells[0].Value.ToString();
            NOM.Text = TABLEELEVE.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = TABLEELEVE.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = TABLEELEVE.CurrentRow.Cells[3].Value.ToString();
          A.GET_PHOTO("ELEVE", "'" + MATRICULE.Text + "'", pictureBox1);
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            A.MODIFIERPHOTO(MATRICULE, "La photo de l'eleve '"+NOM.Text+"' a ete modifier avec succes");
        }

       
    }
}
