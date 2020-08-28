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
    //class Categoría
    //{
    //}

    public class Categoría : ICRUD<ent.Categoría>
    {
        private DAL.Categoría _dal = new DAL.Categoría();
        public void Delete(ent.Categoría t)
        {
            var _ent = Mapper.Map<ent.Categoría, data.Categoría>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.Categoría> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Categoría>, IEnumerable<ent.Categoría>>(t);
            return _ent;
        }

        public ent.Categoría GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Categoría, ent.Categoría>(t);
            return _ent;
        }

        public void Insert(ent.Categoría t)
        {
            var _ent = Mapper.Map<ent.Categoría, data.Categoría>(t);
            _dal.Insert(_ent);
        }

        public IEnumerable<ent.Categoría> SearchByFirstName(string FirstName)
        {
            IEnumerable<data.Categoría> t = _dal.SearchByFirstName(FirstName);
            var _ent = Mapper.Map<IEnumerable<data.Categoría>, IEnumerable<ent.Categoría>>(t);
            return _ent;
        }

        public IEnumerable<ent.Categoría> Search(Expression<Func<ent.Categoría, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Categoría t)
        {
            var _ent = Mapper.Map<ent.Categoría, data.Categoría>(t);
            _dal.Updated(_ent);
        }
    }
}
