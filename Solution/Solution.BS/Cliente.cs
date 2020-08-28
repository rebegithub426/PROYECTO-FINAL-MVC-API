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
    public class Cliente : ICRUD<ent.Cliente>
    {
        private DAL.Cliente _dal = new DAL.Cliente();
        public void Delete(ent.Cliente t)
        {
            var _ent = Mapper.Map<ent.Cliente, data.Cliente>(t);
           _dal.Delete(_ent);
        }

        public IEnumerable<ent.Cliente> GetAll()
        {
            var t = _dal.GetAll();
            var _ent = Mapper.Map<IEnumerable<data.Cliente>, IEnumerable<ent.Cliente>>(t);
            return _ent;
        }

        public ent.Cliente GetOneById(int id)
        {
            var t = _dal.GetOneById(id);
            var _ent = Mapper.Map<data.Cliente, ent.Cliente>(t);
            return _ent;
        }

        public void Insert(ent.Cliente t)
        {
            var _ent = Mapper.Map<ent.Cliente, data.Cliente>(t);
            _dal.Insert(_ent);
        }

        public IEnumerable<ent.Cliente> SearchByFirstName(string FirstName)
        {
            IEnumerable<data.Cliente> t = _dal.SearchByFirstName(FirstName);
            var _ent = Mapper.Map<IEnumerable<data.Cliente>, IEnumerable<ent.Cliente>>(t);
            return _ent;
        }

        public IEnumerable<ent.Cliente> Search(Expression<Func<ent.Cliente, bool>> predicado)
        {
            return null;
        }

        public void Updated(ent.Cliente t)
        {
            var _ent = Mapper.Map<ent.Cliente, data.Cliente>(t);
            _dal.Updated(_ent);
        }
    }
}
