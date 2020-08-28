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
    //class CategoriaProducto
    //{
    //}

    public class CategoriaProducto : ICRUD<ent.CategoriaProducto>
    {
        private DAL.CategoriaProducto _dal = new DAL.CategoriaProducto();
        public void Delete(ent.CategoriaProducto t)
        {
            var _ent = Mapper.Map<ent.CategoriaProducto, data.CategoriaProducto>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.CategoriaProducto> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.CategoriaProducto>, IEnumerable<ent.CategoriaProducto>>(t);
            return _ent;
        }

        public ent.CategoriaProducto GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.CategoriaProducto, ent.CategoriaProducto>(t);
            return _ent;
        }

        public void Insert(ent.CategoriaProducto t)
        {
            var _ent = Mapper.Map<ent.CategoriaProducto, data.CategoriaProducto>(t);
            _dal.Insert(_ent);
        }

        //public IEnumerable<ent.CategoriaProducto> SearchByFirstName(string FirstName)
        //{
        //    IEnumerable<data.CategoriaProducto> t = _dal.SearchByFirstName(FirstName);
        //    var _ent = Mapper.Map<IEnumerable<data.CategoriaProducto>, IEnumerable<ent.CategoriaProducto>>(t);
        //    return _ent;
        //}

        public IEnumerable<ent.CategoriaProducto> Search(Expression<Func<ent.CategoriaProducto, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.CategoriaProducto t)
        {
            var _ent = Mapper.Map<ent.CategoriaProducto, data.CategoriaProducto>(t);
            _dal.Updated(_ent);
        }
    }
}
