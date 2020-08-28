using SolutionMvc2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SolutionMvc2.Data
{
    public class ContextoProducto : DbContext
    {
        public ContextoProducto() : base("DefaultConnection")
        {
            
        }
        public DbSet<Producto1> Producto { get; set; }
    }
}