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
    //class Imagen
    //{
    //}

    public class Imagen : ICRUD<data.Imagen>
    {
        private Repository.Repository<data.Imagen> _repository = new Repository<data.Imagen>(new Tienda_DERMOEntities());
        public void Delete(data.Imagen t)
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

        public IEnumerable<data.Imagen> GetAll()
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

        public data.Imagen GetOneById(int id)
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

        public void Insert(data.Imagen t)
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

        //public IEnumerable<data.Imagen> SearchByFirstName(string FirstName)
        //{
        //    try
        //    {
        //        return _repository.Search(p => p..Contains(FirstName));
        //    }
        //    catch (Exception ee)
        //    {
        //        throw;
        //    }
        //}

        public IEnumerable<data.Imagen> Search(Expression<Func<data.Imagen, bool>> predicado)
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

        public void Updated(data.Imagen t)
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
