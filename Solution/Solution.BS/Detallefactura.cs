using AutoMapper;
using Solution.DO.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DAL.EF;
using ent = Solution.DO.Objects;

namespace Solution.BS
{
    //class Detallefactura
    //{
    //}

    public class DetalleFactura : ICRUD<ent.DetalleFactura>
    {
        private DAL.DetalleFactura _dal = new DAL.DetalleFactura();
        public void Delete(ent.DetalleFactura t)
        {
            var _ent = Mapper.Map<ent.DetalleFactura, data.DetalleFactura>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.DetalleFactura> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.DetalleFactura>, IEnumerable<ent.DetalleFactura>>(t);
            return _ent;
        }

        public ent.DetalleFactura GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.DetalleFactura, ent.DetalleFactura>(t);
            return _ent;
        }

        public void Insert(ent.DetalleFactura t)
        {
            var _ent = Mapper.Map<ent.DetalleFactura, data.DetalleFactura>(t);
            _dal.Insert(_ent);
        }

        //public IEnumerable<ent.DetalleFactura> SearchByFirstName(string FirstName)
        //{
        //    IEnumerable<data.DetalleFactura> t = _dal.SearchByFirstName(FirstName);
        //    var _ent = Mapper.Map<IEnumerable<data.DetalleFactura>, IEnumerable<ent.DetalleFactura>>(t);
        //    return _ent;
        //}

        public IEnumerable<ent.DetalleFactura> Search(Expression<Func<ent.DetalleFactura, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.DetalleFactura t)
        {
            var _ent = Mapper.Map<ent.DetalleFactura, data.DetalleFactura>(t);
            _dal.Updated(_ent);
        }
    }
}
