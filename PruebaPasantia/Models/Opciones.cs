//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaPasantia.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Opciones
    {
        public int Id { get; set; }
        public string Nombre_opcion { get; set; }
        public Nullable<int> Producto_relacionado { get; set; }
        public bool Estado { get; set; }
    
        public virtual Productos Productos { get; set; }
    }
}
