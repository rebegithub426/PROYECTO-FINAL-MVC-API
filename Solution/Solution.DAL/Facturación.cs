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
    //class Facturación
    //{
    //}

    public class Facturación : ICRUD<data.Facturación>
    {
        private Repository.Repository<data.Facturación> _repository = new Repository<data.Facturación>(new Tienda_DERMOEntities());
        public void Delete(data.Facturación t)
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

        public IEnumerable<data.Facturación> GetAll()
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

        public data.Facturación GetOneById(int id)
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

        public void Insert(data.Facturación t)
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

        public IEnumerable<data.Facturación> SearchByFirstName(string FirstName)
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

        public IEnumerable<data.Facturación> Search(Expression<Func<data.Facturación, bool>> predicado)
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

        public void Updated(data.Facturación t)
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
