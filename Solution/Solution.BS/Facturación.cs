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
    //class Facturación
    //{
    //}

    public class Facturación : ICRUD<ent.Facturación>
    {
        private DAL.Facturación _dal = new DAL.Facturación();
        public void Delete(ent.Facturación t)
        {
            var _ent = Mapper.Map<ent.Facturación, data.Facturación>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.Facturación> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Facturación>, IEnumerable<ent.Facturación>>(t);
            return _ent;
        }

        public ent.Facturación GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Facturación, ent.Facturación>(t);
            return _ent;
        }

        public void Insert(ent.Facturación t)
        {
            var _ent = Mapper.Map<ent.Facturación, data.Facturación>(t);
            _dal.Insert(_ent);
        }

        public IEnumerable<ent.Facturación> SearchByFirstName(string FirstName)
        {
            IEnumerable<data.Facturación> t = _dal.SearchByFirstName(FirstName);
            var _ent = Mapper.Map<IEnumerable<data.Facturación>, IEnumerable<ent.Facturación>>(t);
            return _ent;
        }

        public IEnumerable<ent.Facturación> Search(Expression<Func<ent.Facturación, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Facturación t)
        {
            var _ent = Mapper.Map<ent.Facturación, data.Facturación>(t);
            _dal.Updated(_ent);
        }
    }

}
