using Dietiy.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Dietiy.Services.Infrastucture
{
    public interface IClientServices
    {
        void ClientAdd(Client client);
        Client GetClientWithDetails(Expression<Func<Client, bool>> filter);

    }
}
