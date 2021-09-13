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
    public partial class ABONNEMENT : UserControl
    {
        AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE A = new AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE();
        AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE B = new AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE();
        public ABONNEMENT()
        {
            InitializeComponent();
            A.CHARGEMENT_COMBO(NIVEAU, "" + B.NIVEAU_COMBO);
            reinitialiser();
        }
        public void reinitialiser()
        {
            NOM.Text = "";
            POSTNOM.Text = "";
            PRENOM.Text ="";
            NONABONNE.Text = "";
            ABONNE.Text = "";
            TOTAL.Text = "";
            STATUS.Text = "";
                
        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(DESIGNATION, "" + B.DESIGNATION_COMBO + "" + NIVEAU.SelectedItem + " AND ABREVIATION='" + SECTION.SelectedItem + "'");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {

            SECTION.Items.Clear();
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(SECTION, "" + B.SECTION_COMBO + "" + NIVEAU.SelectedItem);
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  A.CHARGEMENT_LABEL(NOMBRE, "SELECT ISNULL(COUNT(*),0) FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
            TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE,ISNULL(CONVERT(VARCHAR(15),ABONNEMENT.ID),'NON ABONNE') AS ABONNEMENT FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE LEFT JOIN ABONNEMENT ON ABONNEMENT.ANNE=AFFECTATION.ANNE AND ABONNEMENT.ELEVE=ELEVE.ID WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
            A.CHARGEMENT_LABEL(ABONNE, "select count(*) from ABONNEMENT INNER JOIN ELEVE ON ABONNEMENT.ELEVE=ELEVE.ID INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID AND AFFECTATION.ANNE=ABONNEMENT.ANNE INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE AND AFFECTATION.ANNE=(SELECT MAX(ID) FROM ANNE) WHERE SALLE_DE_CLASSE.NIVEAU="+NIVEAU.SelectedItem+" AND SALLE_DE_CLASSE.ABREVIATION='"+SECTION.SelectedItem+"' AND SALLE_DE_CLASSE.DESIGNATION='"+DESIGNATION.Text+"'");
            A.CHARGEMENT_LABEL(TOTAL, "select count(*) from ELEVE  INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID AND AFFECTATION.ANNE=(SELECT MAX(ID) FROM ANNE) INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU="+NIVEAU.SelectedItem+" AND SALLE_DE_CLASSE.ABREVIATION='"+SECTION.SelectedItem+"' AND SALLE_DE_CLASSE.DESIGNATION='"+DESIGNATION.SelectedItem+"'");
            NONABONNE.Text =""+(int.Parse(TOTAL.Text)-int.Parse(ABONNE.Text));
        }

        private void TABLEELEVE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            NOM.Text = TABLEELEVE.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = TABLEELEVE.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = TABLEELEVE.CurrentRow.Cells[3].Value.ToString();
           STATUS.Text = TABLEELEVE.CurrentRow.Cells[5].Value.ToString();

           if (TABLEELEVE.CurrentRow.Cells[5].Value.ToString() == "NON ABONNE")
           {
               guna2Button1.Text = "ABONNER";
           }
           else
           {
               guna2Button1.Text = "DESABONNER";
           }
           guna2Button1.Enabled = true;
            A.GET_PHOTO("ELEVE", "'" + TABLEELEVE.CurrentRow.Cells[0].Value.ToString() + "'", pictureBox1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Text == "ABONNER")
            {
                A.EXEC_UNIVERSELLE("ABONNER", "'" + TABLEELEVE.CurrentRow.Cells[0].Value.ToString() + "'", "ABONNEMENT EFFECTUER");
                TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE,ISNULL(CONVERT(VARCHAR(15),ABONNEMENT.ID),'NON ABONNE') AS ABONNEMENT FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE LEFT JOIN ABONNEMENT ON ABONNEMENT.ANNE=AFFECTATION.ANNE AND ABONNEMENT.ELEVE=ELEVE.ID WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
                if (TABLEELEVE.CurrentRow.Cells[5].Value.ToString() == "NON ABONNE")
                {
                    guna2Button1.Text = "ABONNER";
                }
                else
                {
                    guna2Button1.Text = "DESABONNER";
                }
                A.CHARGEMENT_LABEL(ABONNE, "select count(*) from ABONNEMENT INNER JOIN ELEVE ON ABONNEMENT.ELEVE=ELEVE.ID INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID AND AFFECTATION.ANNE=ABONNEMENT.ANNE INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE AND AFFECTATION.ANNE=(SELECT MAX(ID) FROM ANNE) WHERE SALLE_DE_CLASSE.NIVEAU=" + NIVEAU.SelectedItem + " AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.Text + "'");
                A.CHARGEMENT_LABEL(TOTAL, "select count(*) from ELEVE  INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID AND AFFECTATION.ANNE=(SELECT MAX(ID) FROM ANNE) INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + NIVEAU.SelectedItem + " AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
                NONABONNE.Text = "" + (int.Parse(TOTAL.Text) - int.Parse(ABONNE.Text));
            }
        }

        private void ABONNEMENT_Load(object sender, EventArgs e)
        {

        }
    }
}
