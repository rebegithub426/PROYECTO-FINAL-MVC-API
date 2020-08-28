using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class CategoriaProducto
    //{
    //}

    public partial class CategoriaProducto
    {
        public int Id_CategoriaProducto { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Categoria { get; set; }

        public virtual Categoría Categoría { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
