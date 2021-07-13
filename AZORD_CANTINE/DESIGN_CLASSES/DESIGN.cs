using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZORD_CANTINE.DESIGN_CLASSES
{
    class DESIGN
    {
        


        public void APPEL_PANEL(UserControl s, Panel pan)
        {
            
            s.Dock = DockStyle.Fill;
            pan.Controls.Clear();
            pan.Controls.Add(s);
            pan.Show();

        }
        public void ButtonChanged(Guna2Button acceuil, Guna2Button abonnement, Guna2Button paiement, Guna2Button activer)
        {
            acceuil.Checked = false;
            abonnement.Checked = false;
            paiement.Checked = false;
            activer.Checked = true;
        }
      
    }
}
