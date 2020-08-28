using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DO.Objects
{
     public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Cédula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
        public string Email { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
    }
}
