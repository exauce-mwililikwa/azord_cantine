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
    public partial class PAIEMENTFRAIS : UserControl
    {
        AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE A = new AZORD_CANTINE.CONNECTBD.CLSGLOSSIERE();
        AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE B = new AZORD_CANTINE.CONNECTBD.INTERPHACE.REQUETE();
        public PAIEMENTFRAIS()
        {
            InitializeComponent();
            A.CHARGEMENT_COMBO(NIVEAU, "" + B.NIVEAU_COMBO);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new AZORD_CANTINE.ABOUT_BOXES.MODIFICATIONFRAIS().Show();

        }

        private void NIVEAU_SelectedIndexChanged(object sender, EventArgs e)
        {
            SECTION.Items.Clear();
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(SECTION, "" + B.SECTION_COMBO + "" + NIVEAU.SelectedItem);
        }

        private void SECTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            DESIGNATION.Items.Clear();
            A.CHARGEMENT_COMBO(DESIGNATION, "" + B.DESIGNATION_COMBO + "" + NIVEAU.SelectedItem + " AND ABREVIATION='" + SECTION.SelectedItem + "'");
      
        }

        private void DESIGNATION_SelectedIndexChanged(object sender, EventArgs e)
        {
            MOTIFFRAIS.Items.Clear();
          //  A.CHARGEMENT_LABEL(NOMBRE, "SELECT ISNULL(COUNT(*),0) FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
            TABLEELEVE.DataSource = A.TABLEAU("SELECT MATRICULE,NOM,POSTNOM,PRENOM,SEXE FROM ELEVE INNER JOIN AFFECTATION ON AFFECTATION.IDETUDIANT=ELEVE.ID INNER JOIN SALLE_DE_CLASSE ON SALLE_DE_CLASSE.ID=AFFECTATION.IDSALLE WHERE SALLE_DE_CLASSE.NIVEAU=" + int.Parse(NIVEAU.SelectedItem.ToString()) + "AND SALLE_DE_CLASSE.ABREVIATION='" + SECTION.SelectedItem + "' AND SALLE_DE_CLASSE.DESIGNATION='" + DESIGNATION.SelectedItem + "'");
            A.CHARGEMENT_COMBO(MOTIFFRAIS, "SELECT MOTIF_FRAIS.DESIGNATION FROM MOTIF_FRAIS INNER JOIN FRAISCLASSE ON FRAISCLASSE.IDMOTIF=MOTIF_FRAIS.ID INNER JOIN CLASSE ON CLASSE.ID=FRAISCLASSE.IDCLASSE INNER JOIN NIVEAU ON NIVEAU.ID=CLASSE.NIVEAU INNER JOIN SECTION ON SECTION.ID=CLASSE.SECTION WHERE NIVEAU.NIVEAU="+NIVEAU.SelectedItem +"AND SECTION.ABREVIATION='"+SECTION.SelectedItem+"'");
        }

        private void TABLEELEVE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NOM.Text = TABLEELEVE.CurrentRow.Cells[1].Value.ToString();
            POSTNOM.Text = TABLEELEVE.CurrentRow.Cells[2].Value.ToString();
            PRENOM.Text = TABLEELEVE.CurrentRow.Cells[3].Value.ToString();
            A.GET_PHOTO("ELEVE", "'" + TABLEELEVE.CurrentRow.Cells[0].Value.ToString() + "'", pictureBox1);
            
        }

        private void MOTIFFRAIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            A.CHARGEMENT_LABEL(DEJA, "EXEC MONTANTDEJAPAYE '" + TABLEELEVE.CurrentRow.Cells[0].Value.ToString() + "','"+MOTIFFRAIS.SelectedItem+"'");
            A.CHARGEMENT_LABEL(TARIF, "SELECT FRAISCLASSE.MONTANT FROM MOTIF_FRAIS INNER JOIN FRAISCLASSE ON FRAISCLASSE.IDMOTIF=MOTIF_FRAIS.ID INNER JOIN CLASSE ON CLASSE.ID=FRAISCLASSE.IDCLASSE INNER JOIN NIVEAU ON NIVEAU.ID=CLASSE.NIVEAU INNER JOIN SECTION ON SECTION.ID=CLASSE.SECTION WHERE NIVEAU.NIVEAU=" + NIVEAU.SelectedItem + "AND SECTION.ABREVIATION='" + SECTION.SelectedItem + "' AND MOTIF_FRAIS.DESIGNATION='"+MOTIFFRAIS.SelectedItem+"'");
            RESTE.Text = "" + (int.Parse(TARIF.Text) - int.Parse(DEJA.Text));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(RESTE.Text) == 0)
            {
                MessageBox.Show("Le frais a deja ete payer en totalite par l'eleve");
            }
            else
            {
                if (TOTAL_P.Text == "")
                {
                    MessageBox.Show("Entre le montant total a payer");
                }
                else if (int.Parse(MONTANT_P.Text) > int.Parse(TOTAL_P.Text))
                {
                    MessageBox.Show("Le montant doit etre inferieur au total");
                }
                else
                {
                    TOTAL_P.Enabled = false;
                    RESTE_P.Text = "" + (int.Parse(RESTE_P.Text) - int.Parse(MONTANT_P.Text));
                    A.EXEC_UNIVERSELLE("AJOUTERPANIER", "'" + TABLEELEVE.CurrentRow.Cells[0].Value.ToString() + "',"+MONTANT_P.Text+",'"+MOTIFFRAIS.SelectedItem+"',"+NIVEAU.SelectedItem+", '"+SECTION.SelectedItem+"'", "PANIER");
                }
            }
        }

        private void TOTAL_P_TextChanged(object sender, EventArgs e)
        {
            RESTE_P.Text = "" + TOTAL_P.Text;
        }
    }
}
