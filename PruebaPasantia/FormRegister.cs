using PruebaPasantia.Models;
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

namespace PruebaPasantia
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AgregarUsuario(); // Método para agregar usuario a la base de datos si la validación es correcta
            }
        }

        private void AgregarUsuario()
        {
            using (Models.PruebaPasanteEntities db = new Models.PruebaPasanteEntities())
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                    string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtApellido.Text) ||
                    string.IsNullOrEmpty(txtCorreo.Text) ||
                    string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                // Crear un nuevo usuario con los datos del formulario
                var nuevoUsuario = new Usuarios
                {
                    Nombre_usuario = txtNombreUsuario.Text,
                    Contrasena = txtContraseña.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text
                };

                try
                {
                    // Agregar el usuario al contexto y guardar los cambios en la base de datos
                    db.Usuarios.Add(nuevoUsuario);
                    db.SaveChanges();

                    MessageBox.Show("Usuario agregado correctamente.");

                    // Limpiar los campos después de guardar
                    txtNombreUsuario.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtTelefono.Text = "";
                    txtCorreo.Text = "";
                    txtContraseña.Text = "";

                   this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private bool ValidarCampos()
        {
            // Validación de correo
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtCorreo.Text, emailPattern))
            {
                MessageBox.Show("El correo no tiene el formato correcto (ejemplo: juan@gmail.com).");
                return false;
            }

            // Validación de teléfono
            string telefonoPattern = @"^\d{4}-\d{4}$";
            if (!Regex.IsMatch(txtTelefono.Text, telefonoPattern))
            {
                MessageBox.Show("El teléfono no tiene el formato correcto (ejemplo: 0000-0000).");
                return false;
            }

            return true;
        }
    }
}
