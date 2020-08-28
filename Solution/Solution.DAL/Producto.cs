﻿using Solution.DAL.EF;
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
    //class Producto
    //{

    //}

    public class Producto : ICRUD<data.Producto>
    {
        private Repository.Repository<data.Producto> _repository = new Repository<data.Producto>(new Tienda_DERMOEntities());
        public void Delete(data.Producto t)
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

        public IEnumerable<data.Producto> GetAll()
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

        public data.Producto GetOneById(int id)
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

        public void Insert(data.Producto t)
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

        public IEnumerable<data.Producto> SearchByFirstName(string FirstName)
        {
            try
            {
                return _repository.Search(p => p.Nombre.Contains(FirstName));
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public IEnumerable<data.Producto> Search(Expression<Func<data.Producto, bool>> predicado)
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

        public void Updated(data.Producto t)
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
