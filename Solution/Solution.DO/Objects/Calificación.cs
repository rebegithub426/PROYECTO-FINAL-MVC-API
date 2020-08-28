using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class Calificacion
    //{
    //}

    public partial class Calificación
    {
        public int Id_Calificación { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Producto { get; set; }
        public Nullable<decimal> Valoración { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
