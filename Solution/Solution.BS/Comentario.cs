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
    //class Comentario
    //{
    //}

    public class Comentario : ICRUD<ent.Comentario>
    {
        private DAL.Comentario _dal = new DAL.Comentario();
        public void Delete(ent.Comentario t)
        {
            var _ent = Mapper.Map<ent.Comentario, data.Comentario>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.Comentario> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Comentario>, IEnumerable<ent.Comentario>>(t);
            return _ent;
        }

        public ent.Comentario GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Comentario, ent.Comentario>(t);
            return _ent;
        }

        public void Insert(ent.Comentario t)
        {
            var _ent = Mapper.Map<ent.Comentario, data.Comentario>(t);
            _dal.Insert(_ent);
        }

        //public IEnumerable<ent.Comentario> SearchByFirstName(string FirstName)
        //{
        //    IEnumerable<data.Comentario> t = _dal.SearchByFirstName(FirstName);
        //    var _ent = Mapper.Map<IEnumerable<data.Comentario>, IEnumerable<ent.Comentario>>(t);
        //    return _ent;
        //}

        public IEnumerable<ent.Comentario> Search(Expression<Func<ent.Comentario, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Comentario t)
        {
            var _ent = Mapper.Map<ent.Comentario, data.Comentario>(t);
            _dal.Updated(_ent);
        }
    }
}
