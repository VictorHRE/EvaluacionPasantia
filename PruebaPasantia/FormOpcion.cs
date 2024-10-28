using PruebaPasantia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PruebaPasantia
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    public partial class FormOpcion : Form
    {
        private int codigoProducto;

        public FormOpcion(int codigoProducto)
        {
            InitializeComponent();
            this.codigoProducto = codigoProducto;
            CargarOpciones();
        }

        private void CargarOpciones()
        {
            using (var context = new PruebaPasanteEntities())
            {
                var opciones = context.Opciones
                    .Where(o => o.Producto_relacionado == codigoProducto)
                    .ToList();
                opcionesDataGridView.DataSource = opciones;
                context.Configuration.LazyLoadingEnabled = false; // Resuelve un dataError

            }
        }

        public void SetDatos(Opciones o)
        {
            try
            {
                // Asegúrate de que los valores de los campos estén correctamente asignados
                o.Nombre_opcion = txtOpcion.Text;
                o.Estado = chkEstadO.Checked;

                // Convertir txtRelacion.Text a int
                if (int.TryParse(txtRelacion.Text, out int productoRelacionado))
                {
                    o.Producto_relacionado = productoRelacionado;
                }
                else
                {
                    MessageBox.Show("El valor en el campo de relación no es un número válido.");
                    return; // Salir del método si la conversión falla
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar los datos: " + ex.Message);
            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();


            PruebaPasanteEntities modelo = new PruebaPasanteEntities();

            SetDatos(opciones);//GUARDAR NUEVA OPCION
            modelo.Opciones.Add(opciones);
            modelo.SaveChanges();
            CargarOpciones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (opcionesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                return;
            }

            // Obtener el ID del registro seleccionado
            int Id = Convert.ToInt32(opcionesDataGridView.SelectedRows[0].Cells["Id"].Value);

            using (PruebaPasanteEntities modelo = new PruebaPasanteEntities())
            {
                // Buscar el registro por ID
                var opcion = modelo.Opciones.Find(Id);
                if (opcion != null)
                {
                    // Actualizar los datos del registro
                    SetDatos(opcion);

                    // Marcar el objeto como modificado
                    modelo.Entry(opcion).State = EntityState.Modified;

                    // Guardar los cambios
                    try
                    {
                        modelo.SaveChanges();
                        MessageBox.Show("Registro actualizado exitosamente.");

                        // Limpiar los campos y recargar el DataGridView
                        txtOpcion.Clear();
                        chkEstadO.Checked = false;
                        txtRelacion.Clear();
                        CargarOpciones();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar cambios: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El registro no se encontró.");
                }
            }
        }
    }

}
