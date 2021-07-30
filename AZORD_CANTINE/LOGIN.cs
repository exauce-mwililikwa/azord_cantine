using AZORD_CANTINE.USERCONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        //    Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");   
          //  Regex regex = new Regex(@"[0-9]+"); //has number
            Regex re = new Regex(strRegex);
         //le 1 upper 4 lower space char number   Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            Regex regex = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");
            if (regex.IsMatch("" + textBox1.Text))
                label4.Text="";
            else
                label4.Text = "email invalide";
        }
    }
}
