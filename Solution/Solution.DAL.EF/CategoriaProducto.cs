//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solution.DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoriaProducto
    {
        public int Id_CategoriaProducto { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Categoria { get; set; }
    
        public virtual Categoría Categoría { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
