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
    //class Comentario
    //{
    //}

    public class Comentario : ICRUD<data.Comentario>
    {
        private Repository.Repository<data.Comentario> _repository = new Repository<data.Comentario>(new Tienda_DERMOEntities());
        public void Delete(data.Comentario t)
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

        public IEnumerable<data.Comentario> GetAll()
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

        public data.Comentario GetOneById(int id)
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

        public void Insert(data.Comentario t)
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

        //public IEnumerable<data.Comentario> SearchByFirstName(string FirstName)
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

        public IEnumerable<data.Comentario> Search(Expression<Func<data.Comentario, bool>> predicado)
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

        public void Updated(data.Comentario t)
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
