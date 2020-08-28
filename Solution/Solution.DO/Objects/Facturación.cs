using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class Facturación
    //{
    //}
    public partial class Facturación
    {
        public int Id_Facturación { get; set; }
        public int Id_Factura { get; set; }
        public string Identificación { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Teléfono { get; set; }
        public string Dirección { get; set; }

        public virtual Factura Factura { get; set; }
    }
}
