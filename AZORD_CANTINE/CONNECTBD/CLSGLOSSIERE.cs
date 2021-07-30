using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZORD_CANTINE.CONNECTBD
{
    class CLSGLOSSIERE
    {
        public static SqlConnection con = MYCONNECTION.con;
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataAdapter dt = null;
        public static SqlDataReader dr = null;
        public static DataSet ds = null;

        public static string imgLon = "";
        public void CHOISIR_IMAGE(PictureBox picture)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Selectionner une image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLon = dlg.FileName.ToString();
                picture.ImageLocation = imgLon;
            }
        }
        public void MODIFIERPHOTO(Label MATRICULE,string MESSAGE)
        {
             
                con.Open();
                try {
                    byte[] img = null;
                   
                    cmd.Parameters.Clear();
                    FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    cmd.CommandText = ("EXEC UPDATEPHOTOELEVE '" + MATRICULE.Text + "',@IMAGE");
                   cmd.Parameters.Add(new SqlParameter("@IMAGE", img));
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("" + MESSAGE, "OPERATION REUSSI", MessageBoxButtons.OK, MessageBoxIcon.None);
                    img = null;
                    imgLon = "";
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(""+ex);
                }
                con.Close();

            }
        public void GET_PHOTO(string table,  string reference, PictureBox picemp)
        {
            string test="";
            string sexe = "";
            con.Open();
            try
            {

                cmd.CommandText = "select  IMAGE,sexe from " + table + " where MATRICULE=" + reference + "";
   
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   test= dr[0].ToString();
                   sexe = dr[1].ToString();
                }
                if(test=="")
                {
                    if(sexe=="F")
                    {
                        picemp.Image = global::AZORD_CANTINE.Properties.Resources.avtar_1;
                    }
                    else
                    {
                        picemp.Image = global::AZORD_CANTINE.Properties.Resources.avtar_3;
                    }
                
                }
                else
                {
                    con.Close();
                    con.Open();
                    try
                    {

                        cmd.CommandText = "select  IMAGE from " + table + " where MATRICULE=" + reference + "";
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            byte[] img = (byte[])(dr[0]);
                            if (img == null)
                                picemp.Image = null;
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picemp.Image = System.Drawing.Image.FromStream(ms);
                            }

                        }

                        //  Console.WriteLine("select PHOTO from " + table + " where " + colonne_ref + "='" + reference + "'");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
               

            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }
        
        public void CHARGEMENT_LABEL(Label CHARGING,String rqt)
        {
            con.Open();
            cmd.CommandText = rqt;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CHARGING.Text = dr[0].ToString();
            }
            con.Close();
        }
        public void CHARGEMENT_TEXTBOX(Guna2TextBox CHARGING, String rqt)
        {
            con.Open();
            cmd.CommandText = rqt;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CHARGING.Text = dr[0].ToString();
            }
            con.Close();
        }
        public static void LOGIN(Guna2TextBox username,Guna2TextBox passowrd)
        {
            con.Open();
            String testi;

            cmd.CommandText = "EXEC LOGIN_PROC '"+username.Text+"','"+passowrd.Text+"'";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                testi = dr[0].ToString();
                if (int.Parse(testi) == 1)
                {
                    MessageBox.Show(" LE NOM D'UTILISATEUR EST INCORRECT");
                }
                else if (int.Parse(testi) == 2)
                {
                    MessageBox.Show(" LE MOT DE PASSE EST INCORRECT");
                }
                else
                {
                    new AZORD_CANTINE.USERCONTROL.DASHBOARD(""+username.Text.ToString()+"").Show();
                }
            }
            con.Close();
        }
        public void CHARGEMENT_COMBO(Guna2ComboBox COMBO, string RQT)
        {
            con.Open();
            cmd.CommandText = RQT;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                COMBO.Items.Add(dr[0]);
            }
            con.Close();
        }
        public void EXEC_UNIVERSELLE(String FUNCTION,String PARAMS,String MESSAGE)
        {
            con.Open();
            try { 
            cmd.CommandText=("EXEC "+FUNCTION+" "+PARAMS);
            cmd.ExecuteNonQuery();
            MessageBox.Show(""+MESSAGE);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(""+ex);
            }
            con.Close();
        }
        public DataTable TABLEAU(String rqte)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand(rqte, con);
                dt = null;
                dt = new SqlDataAdapter(cmd);
                ds = new DataSet();
                Console.WriteLine(rqte);
                dt.Fill(ds);
                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("erreur de login " + ex);
            }
            return ds.Tables[0];
        }
    }
}
