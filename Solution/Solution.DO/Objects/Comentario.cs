using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class Comentario
    //{
    //}

    public partial class Comentario
    {
        public int Id_Comentario { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Producto { get; set; }
        public string Descripción { get; set; }
        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
