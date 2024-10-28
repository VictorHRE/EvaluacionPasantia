using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPasantia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CorreoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Models.PruebaPasanteEntities db = new Models.PruebaPasanteEntities())
            {
                var lst = from d in db.Usuarios  // Autenticacion 
                          where d.Correo  == CorreoTxt.Text
                          && d.Contrasena == PassText.Text
                          select d;
                if ( lst.Count()>0 )
                {
                    CorreoTxt.Text = string.Empty;
                    PassText.Text = string.Empty;

                   
                    FormMain frm = new FormMain();
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Correo y contraseña no coinciden ");
                }
              
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister frm = new FormRegister(); // Presenta el formulario de registro
            frm.Show();
        }
    }
}
