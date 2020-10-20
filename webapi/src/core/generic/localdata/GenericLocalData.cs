using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.src.core.database;
using webapi.src.core.generic.repository;

namespace webapi.src.core.generic.localdata
{
    public class GenericLocalData<T> : IGenericLocalData<T> where T : class
    {
        private DataBaseContext _context = null;
        private DbSet<T> table = null;

        public GenericLocalData()
        {
            this._context = new DataBaseContext();
            table = _context.Set<T>();
        }


        public GenericLocalData(DataBaseContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public int Save()
        {
          var result =  _context.SaveChanges();
            return result;

        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
