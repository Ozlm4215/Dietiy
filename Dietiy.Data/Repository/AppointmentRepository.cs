using Dietiy.Data.DataContext;
using Dietiy.Data.Infrastructure;
using Dietiy.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dietiy.Data.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DietiyContext _context;

        public AppointmentRepository(DietiyContext context)
        {
            _context = context;
        }
        public void Add(Appointment entity)
        {
            _context.Appointments.Add(entity);
        }
        public Appointment Get(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment Get(Expression<Func<Appointment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetList()
        {
           return _context.Appointments.AsQueryable();
        }

        public IEnumerable<Appointment> GetList(Expression<Func<Appointment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(Appointment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Appointment entity)
        {
            throw new NotImplementedException();
        }
    }
}
