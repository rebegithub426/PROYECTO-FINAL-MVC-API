using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DAL.EF;
using ent = Solution.DO.Objects;
namespace Solution.Maps
{
    public class Maps
    {
        public static void CreateMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ent.Cliente, data.Cliente>();
                cfg.CreateMap<data.Cliente, ent.Cliente>();

                cfg.CreateMap<ent.Producto, data.Producto>();
                cfg.CreateMap<data.Producto, ent.Producto>();

                cfg.CreateMap<ent.Imagen, data.Imagen>();
                cfg.CreateMap<data.Imagen, ent.Imagen>();

                cfg.CreateMap<ent.Categoría, data.Categoría>();
                cfg.CreateMap<data.Categoría, ent.Categoría>();

                cfg.CreateMap<ent.CategoriaProducto, data.CategoriaProducto>();
                cfg.CreateMap<data.CategoriaProducto, ent.CategoriaProducto>();


                cfg.CreateMap<ent.FormaPago, data.FormaPago>();
                cfg.CreateMap<data.FormaPago, ent.FormaPago>();


                cfg.CreateMap<ent.Factura, data.Factura>();
                cfg.CreateMap<data.Factura, ent.Factura>();


                cfg.CreateMap<ent.Facturación, data.Facturación>();
                cfg.CreateMap<data.Facturación, ent.Facturación>();


                cfg.CreateMap<ent.DetalleFactura, data.DetalleFactura>();
                cfg.CreateMap<data.DetalleFactura, ent.DetalleFactura>();


                cfg.CreateMap<ent.Comentario, data.Comentario>();
                cfg.CreateMap<data.Comentario, ent.Comentario>();


                cfg.CreateMap<ent.Calificación, data.Calificación>();
                cfg.CreateMap<data.Calificación, ent.Calificación>();

            });

        }

    }
}
