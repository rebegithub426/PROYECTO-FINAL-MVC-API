using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SolutionMvc2.Models
{
    [Table("Producto")]
    public class Producto1
    {
        [Key]
        [Column("Id_Producto")]
        public int Id_Producto { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Precio")]
        public decimal Precio { get; set; }
        [Column("Stock")]
        public short Stock { get; set; }
        [Column("Marca")]
        public string Marca { get; set; }
        [Column("Descripción")]
        public string Descripción { get; set; }
        [Column("Referencia")]
        public string Referencia { get; set; }
    }
}