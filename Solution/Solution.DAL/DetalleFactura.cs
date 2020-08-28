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
    //class DetalleFactura
    //{
    //}

    public class DetalleFactura : ICRUD<data.DetalleFactura>
    {
        private Repository.Repository<data.DetalleFactura> _repository = new Repository<data.DetalleFactura>(new Tienda_DERMOEntities());
        public void Delete(data.DetalleFactura t)
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

        public IEnumerable<data.DetalleFactura> GetAll()
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

        public data.DetalleFactura GetOneById(int id)
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

        public void Insert(data.DetalleFactura t)
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

        //public IEnumerable<data.DetalleFactura> SearchByFirstName(string FirstName)
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

        public IEnumerable<data.DetalleFactura> Search(Expression<Func<data.DetalleFactura, bool>> predicado)
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

        public void Updated(data.DetalleFactura t)
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
