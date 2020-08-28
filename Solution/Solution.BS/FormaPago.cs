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
    //class FormaPago
    //{
    //}

    public class FormaPago : ICRUD<ent.FormaPago>
    {
        private DAL.FormaPago _dal = new DAL.FormaPago();
        public void Delete(ent.FormaPago t)
        {
            var _ent = Mapper.Map<ent.FormaPago, data.FormaPago>(t);
            _dal.Delete(_ent);
        }

        public IEnumerable<ent.FormaPago> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.FormaPago>, IEnumerable<ent.FormaPago>>(t);
            return _ent;
        }

        public ent.FormaPago GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.FormaPago, ent.FormaPago>(t);
            return _ent;
        }

        public void Insert(ent.FormaPago t)
        {
            var _ent = Mapper.Map<ent.FormaPago, data.FormaPago>(t);
            _dal.Insert(_ent);
        }

        public IEnumerable<ent.FormaPago> SearchByFirstName(string FirstName)
        {
            IEnumerable<data.FormaPago> t = _dal.SearchByFirstName(FirstName);
            var _ent = Mapper.Map<IEnumerable<data.FormaPago>, IEnumerable<ent.FormaPago>>(t);
            return _ent;
        }

        public IEnumerable<ent.FormaPago> Search(Expression<Func<ent.FormaPago, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.FormaPago t)
        {
            var _ent = Mapper.Map<ent.FormaPago, data.FormaPago>(t);
            _dal.Updated(_ent);
        }
    }

}
