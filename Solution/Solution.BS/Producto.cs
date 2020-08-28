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
    //class Producto
    //{
    //}

    public class Producto : ICRUD<ent.Producto>
    {
        private DAL.Producto _dal = new DAL.Producto();
        public void Delete(ent.Producto t)
        {
            var _ent = Mapper.Map<ent.Producto, data.Producto>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.Producto> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Producto>, IEnumerable<ent.Producto>>(t);
            return _ent;
        }

        public ent.Producto GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Producto, ent.Producto>(t);
            return _ent;
        }

        public void Insert(ent.Producto t)
        {
            var _ent = Mapper.Map<ent.Producto, data.Producto>(t);
            _dal.Insert(_ent);
        }

        public IEnumerable<ent.Producto> SearchByFirstName(string FirstName)
        {
            IEnumerable<data.Producto> t = _dal.SearchByFirstName(FirstName);
            var _ent = Mapper.Map<IEnumerable<data.Producto>, IEnumerable<ent.Producto>>(t);
            return _ent;
        }

        public IEnumerable<ent.Producto> Search(Expression<Func<ent.Producto, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Producto t)
        {
            var _ent = Mapper.Map<ent.Producto, data.Producto>(t);
            _dal.Updated(_ent);
        }
    }

}
