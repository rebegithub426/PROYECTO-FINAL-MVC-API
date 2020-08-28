using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
    //class Factura
    //{
    //}

    public partial class Factura
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            //this.DetalleFactura = new HashSet<DetalleFactura>();
            //this.Facturación = new HashSet<Facturación>();
        }

        public int Id_Factura { get; set; }
        public int Nombre { get; set; }
        public int Id_Cliente { get; set; }
        public System.DateTime Fecha { get; set; }
        public int id_FormaPago { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Valor_Iva { get; set; }
        public decimal Valor_Descuento { get; set; }
        public decimal Neto { get; set; }
        public bool Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
       // public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
        public virtual FormaPago FormaPago { get; set; }
       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //  public virtual ICollection<Facturación> Facturación { get; set; }
    }
}
