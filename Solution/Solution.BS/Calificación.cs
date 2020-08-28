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
    //class Calificación
    //{
    //}

    public class Calificación : ICRUD<ent.Calificación>
    {
        private DAL.Calificación _dal = new DAL.Calificación();
        public void Delete(ent.Calificación t)
        {
            var _ent = Mapper.Map<ent.Calificación, data.Calificación>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.Calificación> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Calificación>, IEnumerable<ent.Calificación>>(t);
            return _ent;
        }

        public ent.Calificación GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Calificación, ent.Calificación>(t);
            return _ent;
        }

        public void Insert(ent.Calificación t)
        {
            var _ent = Mapper.Map<ent.Calificación, data.Calificación>(t);
            _dal.Insert(_ent);
        }

        //public IEnumerable<ent.Calificación> SearchByFirstName(string FirstName)
        //{
        //    IEnumerable<data.Calificación> t = _dal.SearchByFirstName(FirstName);
        //    var _ent = Mapper.Map<IEnumerable<data.Calificación>, IEnumerable<ent.Calificación>>(t);
        //    return _ent;
        //}

        public IEnumerable<ent.Calificación> Search(Expression<Func<ent.Calificación, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Calificación t)
        {
            var _ent = Mapper.Map<ent.Calificación, data.Calificación>(t);
            _dal.Updated(_ent);
        }
    }

}
