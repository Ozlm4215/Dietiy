using Dietiy.Data.DataContext;
using Dietiy.Data.Infrastructure;
using Dietiy.Data.Repository;
using Dietiy.Entities;
using Dietiy.Services.Infrastucture;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dietiy.Services
{
    public class ClientService : IClientServices
    {
        private  IClientRepository clientRepository;
        private  IAppointmentRepository appointmentRepository;

        public ClientService()
        {


               
        }


        public void ClientAdd(Client client)
        {

            using (var dietiyContext = new DietiyContext())
            {
                clientRepository = new ClientRepository(dietiyContext);

                clientRepository.Add(client);

            }
        }

        

        public Client GetClientWithDetails(Expression<Func<Client, bool>> filter)
        {
            using (var dietiyContext = new DietiyContext())
            {
                clientRepository = new ClientRepository(dietiyContext);
                appointmentRepository = new AppointmentRepository(dietiyContext);

                var client = clientRepository.Get(filter);

                client.Appointments = appointmentRepository.GetList(c=>c.Client.Id == client.Id);

                return client;


            }
        }
    }
}
