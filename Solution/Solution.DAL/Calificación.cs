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
    //class Calificación
    //{
    //}

    public class Calificación : ICRUD<data.Calificación>
    {
        private Repository.Repository<data.Calificación> _repository = new Repository<data.Calificación>(new Tienda_DERMOEntities());
        public void Delete(data.Calificación t)
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

        public IEnumerable<data.Calificación> GetAll()
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

        public data.Calificación GetOneById(int id)
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

        public void Insert(data.Calificación t)
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

        //public IEnumerable<data.Calificación> SearchByFirstName(string FirstName)
        //{
        //    try
        //    {
        //        return _repository.Search(p => p.Nombre.Contains(FirstName));
        //    }
        //    catch (Exception ee)
        //    {
        //        throw;
        //    }
        //}

        public IEnumerable<data.Calificación> Search(Expression<Func<data.Calificación, bool>> predicado)
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

        public void Updated(data.Calificación t)
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
