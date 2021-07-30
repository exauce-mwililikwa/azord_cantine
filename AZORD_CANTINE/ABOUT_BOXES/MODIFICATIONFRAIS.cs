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
    partial class MODIFICATIONFRAIS : Form
    {
        AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE A = new AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE();
        AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE B = new AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE();
        public MODIFICATIONFRAIS()
        {
            InitializeComponent();
            A.CHARGEMENT_COMBO(MOTIFFRAIS, "SELECT DESIGNATION FROM MOTIF_FRAIS");
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

        private void labelCopyright_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new AZORD_CANTINE.ABOUT_BOXES.NOUVEAUMOTIFPAIEMENT().Show();
        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            SECTION.Items.Clear();
            A.CHARGEMENT_COMBO(SECTION, "" + B.SECTION_COMBO + "" + NIVEAU.SelectedItem);
            NIVEAULABEL.Text = "" + NIVEAU.SelectedItem.ToString();
        
        }

        private void SECTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            SECTIONLABEL.Text = "" + SECTION.SelectedItem.ToString();
        }

        private void MODIFICATIONFRAIS_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            A.EXEC_UNIVERSELLE("AJOUTERFRAISCLASSE", "" + NIVEAU.Text + ",'" + SECTION.Text + "','" + MOTIFFRAIS.SelectedItem + "'," + MONTANT.Text, "Le frais de " + MOTIFFRAIS.SelectedItem + " avec le montant de "+MONTANT.Text+" ont ete ajouter avec succes dans les salle de "+NIVEAU.SelectedItem+"/"+SECTION.SelectedItem+"");
        }
    }
}
