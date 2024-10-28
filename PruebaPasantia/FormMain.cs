using PruebaPasantia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PruebaPasantia
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CargarGrid(); // Método para cargar los datos
        }
        public void CargarGrid() 
        {

            using (var context = new PruebaPasanteEntities())
            {
                var query = from p in context.Productos
                            join o in context.Opciones on p.Codigo equals o.Producto_relacionado into opciones
                            from o in opciones.DefaultIfEmpty()
                            select new
                            {
                                Codigo = p.Codigo,
                                Nombre = p.Nombre,
                                Existencia = p.Existencia,
                                Estado = p.Estado,
                                Nombre_proveedor = p.Nombre_proveedor,
                                Opcion = o.Nombre_opcion
                            };

                dgDatos.DataSource = query.ToList();
            }


        }
        // Evento para buscar productos por nombre
        private void BuscarProducto()
        {
            using (var context = new PruebaPasanteEntities())
            {
                string nombreProducto = txtBuscar.Text.Trim();
                var productos = context.Productos
                                       .Where(p => p.Nombre.Contains(nombreProducto))
                                       .ToList();
                context.Configuration.LazyLoadingEnabled = false;

                
                dgDatos.DataSource = productos;
                dgDatos.Columns[5].Visible = false;
            }

        }
        private void FiltrarPorEstado()
        {
            using (var context = new PruebaPasanteEntities())
            {
                bool filtrarPorEstado = chkEstado.Checked;
                var productos = context.Productos.AsQueryable();

                if (filtrarPorEstado)
                {
                    productos = productos.Where(p => p.Estado == true); // Filtra donde el estado este en true
                }
                context.Configuration.LazyLoadingEnabled = false;//Resuelve un dataError

               

                dgDatos.DataSource = productos.ToList();
                dgDatos.Columns[5].Visible = false;
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarPorEstado(); 
            BuscarProducto();
            txtBuscar.Text = string.Empty;
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorEstado();
            
        }
    }
}

