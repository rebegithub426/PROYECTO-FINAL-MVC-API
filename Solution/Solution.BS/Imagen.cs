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
    //class Imagen
    //{
    //}

    public class Imagen : ICRUD<ent.Imagen>
    {
        private DAL.Imagen _dal = new DAL.Imagen();
        public void Delete(ent.Imagen t)
        {
            var _ent = Mapper.Map<ent.Imagen, data.Imagen>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.Imagen> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Imagen>, IEnumerable<ent.Imagen>>(t);
            return _ent;
        }

        public ent.Imagen GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Imagen, ent.Imagen>(t);
            return _ent;
        }

        public void Insert(ent.Imagen t)
        {
            var _ent = Mapper.Map<ent.Imagen, data.Imagen>(t);
            _dal.Insert(_ent);
        }

        //public IEnumerable<ent.Imagen> SearchByFirstName(string FirstName)
        //{
        //    IEnumerable<data.Imagen> t = _dal.SearchByFirstName(FirstName);
        //    var _ent = Mapper.Map<IEnumerable<data.Imagen>, IEnumerable<ent.Imagen>>(t);
        //    return _ent;
        //}

        public IEnumerable<ent.Imagen> Search(Expression<Func<ent.Imagen, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Imagen t)
        {
            var _ent = Mapper.Map<ent.Imagen, data.Imagen>(t);
            _dal.Updated(_ent);
        }
    }
}
