using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class Categoria
    //{
    //}

    public partial class Categoría
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categoría()
        {
           // this.CategoriaProducto = new HashSet<CategoriaProducto>();
        }

        public int Id_Categoría { get; set; }
        public string Nombre { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CategoriaProducto> CategoriaProducto { get; set; }
    }

}
