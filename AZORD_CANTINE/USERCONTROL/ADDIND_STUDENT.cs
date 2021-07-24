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
    public partial class ADDIND_STUDENT : UserControl
    {
        AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE A = new AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE();
        AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE B = new AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE();
        public ADDIND_STUDENT()
        {
            InitializeComponent();
            A.CHARGEMENT_COMBO(NIVEAU, "" + B.NIVEAU_COMBO);
           // A.CHARGEMENT_LABEL(NOMBRE,)
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            SECTION.Items.Clear();
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(SECTION, "" + B.SECTION_COMBO+""+NIVEAU.SelectedItem);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SECTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(DESIGNATION, "" + B.DESIGNATION_COMBO+""+NIVEAU.SelectedItem+" AND ABREVIATION='"+SECTION.SelectedItem+"'");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NOM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            POSTNOM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            PRENOM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            NOMPERE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            NOMMERE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            TELEPHONE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
             if(NOM.Text=="")
            {
                NOM.BorderColor = System.Drawing.Color.Red;
                Console.Beep();
            }
            else if(POSTNOM.Text==""){
                POSTNOM.BorderColor = System.Drawing.Color.Red;
                Console.Beep();
            }
            else if(PRENOM.Text=="")
            {
                PRENOM.BorderColor = System.Drawing.Color.Red;
                Console.Beep();
            }
            else if(NOMMERE.Text=="")
            {
                NOMMERE.BorderColor = System.Drawing.Color.Red;
                Console.Beep();
            }
            else if (NOMPERE.Text == "")
            {
                NOMPERE.BorderColor = System.Drawing.Color.Red;
                Console.Beep();
            }
            else if (ADRESSE.Text=="")
            {
                Console.Beep();
               // ADRESSE.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                string SEXE = "";
                if(radioButton1.Checked==true)
                {
                    SEXE = "M";
                }
                else
                {
                    SEXE = "F";
                }
                A.EXEC_UNIVERSELLE("AJOUTER_ELEVE", "'" + NOM.Text + "','" + POSTNOM.Text + "','" + PRENOM.Text + "','" + NOMMERE.Text + "','" + NOMMERE.Text + "','" + TELEPHONE.Text + "','" + ADRESSE.Text.ToString() + "'," + int.Parse(NIVEAU.SelectedItem.ToString()) + ",'" + SECTION.SelectedItem + "','" + DESIGNATION.SelectedItem + "','"+SEXE+"'", "ELEVE AJOUTER");
               // NOMPERE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                NOM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                POSTNOM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                PRENOM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                NOMPERE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                NOMMERE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                TELEPHONE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
               
            }
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            A.CHARGEMENT_LABEL(NOMBRE, "SELECT ISNULL(COUNT(*),0) FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
                TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
                
            
         }

       

        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "' AND CONCAT(NOM,' ',POSTNOM,' ',PRENOM) like '%" + guna2TextBox1.Text + "%'");
              
        }
    }
}
