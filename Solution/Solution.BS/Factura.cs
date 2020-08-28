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
    //class Factura
    //{
    //}

    public class Factura : ICRUD<ent.Factura>
    {
        private DAL.Factura _dal = new DAL.Factura();
        public void Delete(ent.Factura t)
        {
            var _ent = Mapper.Map<ent.Factura, data.Factura>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.Factura> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Factura>, IEnumerable<ent.Factura>>(t);
            return _ent;
        }

        public ent.Factura GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Factura, ent.Factura>(t);
            return _ent;
        }

        public void Insert(ent.Factura t)
        {
            var _ent = Mapper.Map<ent.Factura, data.Factura>(t);
            _dal.Insert(_ent);
        }

        //public IEnumerable<ent.Factura> SearchByFirstName(string FirstName)
        //{
        //    IEnumerable<data.Factura> t = _dal.SearchByFirstName(FirstName);
        //    var _ent = Mapper.Map<IEnumerable<data.Factura>, IEnumerable<ent.Factura>>(t);
        //    return _ent;
        //}

        public IEnumerable<ent.Factura> Search(Expression<Func<ent.Factura, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Factura t)
        {
            var _ent = Mapper.Map<ent.Factura, data.Factura>(t);
            _dal.Updated(_ent);
        }
    }
}
