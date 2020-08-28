using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DAL.EF;

namespace Solution.DAL
{
    //class FormaPago
    //{
    //}

    public class FormaPago : ICRUD<data.FormaPago>
    {
        private Repository.Repository<data.FormaPago> _repository = new Repository<data.FormaPago>(new Tienda_DERMOEntities());
        public void Delete(data.FormaPago t)
        {
            try
            {
                //t.PhotoPath = true.ToString();
                //_repository.Updated(t);

                _repository.Delete(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.FormaPago> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public data.FormaPago GetOneById(int id)
        {
            try
            {
                return _repository.GetOneByID(id);
            }
            catch (Exception ee)
            {
                throw;
            };
        }

        public void Insert(data.FormaPago t)
        {
            try
            {
                _repository.Insert(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.FormaPago> SearchByFirstName(string FirstName)
        {
            try
            {
                return _repository.Search(p => p.Tipo.Contains(FirstName));
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.FormaPago> Search(Expression<Func<data.FormaPago, bool>> predicado)
        {
            try
            {
                return _repository.Search(predicado);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Updated(data.FormaPago t)
        {
            try
            {
                _repository.Updated(t);
                _repository.Commit();
            }
            catch (Exception ee)
            {
                throw;
            }
        }
    }
}
