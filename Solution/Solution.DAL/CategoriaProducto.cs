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
    //class CategoriaProducto
    //{
    //}

    public class CategoriaProducto : ICRUD<data.CategoriaProducto>
    {
        private Repository.Repository<data.CategoriaProducto> _repository = new Repository<data.CategoriaProducto>(new Tienda_DERMOEntities());
        public void Delete(data.CategoriaProducto t)
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

        public IEnumerable<data.CategoriaProducto> GetAll()
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

        public data.CategoriaProducto GetOneById(int id)
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

        public void Insert(data.CategoriaProducto t)
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

        //public IEnumerable<data.CategoriaProducto> SearchByFirstName(string FirstName)
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

        public IEnumerable<data.CategoriaProducto> Search(Expression<Func<data.CategoriaProducto, bool>> predicado)
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

        public void Updated(data.CategoriaProducto t)
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