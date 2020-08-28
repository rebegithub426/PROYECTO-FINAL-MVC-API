using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class Imagen
    //{
    //}
    public partial class Imagen
    {
        public int Id_Imagen { get; set; }
        public int Id_Producto { get; set; }
        public string URL { get; set; }
        public bool Exportada { get; set; }

       // public virtual Producto Producto { get; set; }
    }
}
