using Dietiy.Data.DataContext;
using Dietiy.Data.Infrastructure;
using Dietiy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dietiy.Data.Repository
{
   public class ClientRepository : IClientRepository
    {
         private readonly DietiyContext _context;

        public ClientRepository(DietiyContext context)
        {
            _context = context;
        }
        public void Add(Client entity)
        {
            _context.Clients.Add(entity);
        }

        public Client Get(int id)
        {
           return _context.Clients.Find(id);
        }

        public Client Get(Expression<Func<Client, bool>> filter)
        {
            return _context.Clients.Where(filter).FirstOrDefault();
        }

        public IEnumerable<Client> GetList(Expression<Func<Client, bool>> filter)
        {
            return _context.Clients.Where(filter);
        }

        public IEnumerable<Client> GetList()
        {
            return _context.Clients.AsEnumerable();
        }

        public void Remove(Client entity)
        {
            _context.Clients.Remove(entity);
        }

        public void Update(Client entity)
        {
            _context.Clients.Update(entity);

            //var updatedEntity = _context.Entry(entity);
            //updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
          

        }
    }
}
