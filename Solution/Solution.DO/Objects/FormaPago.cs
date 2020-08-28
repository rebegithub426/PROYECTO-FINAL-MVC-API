using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class FormaPago
    //{
    //}

    public partial class FormaPago
    {
       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormaPago()
        {
            //this.Factura = new HashSet<Factura>();
        }

        public int Id_Fomapago { get; set; }
        public string Tipo { get; set; }
        public string Descripción { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Factura> Factura { get; set; }
    }
}
