using Application.Contracts.Persistence;
using Message_Exchange_App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Exchange_App.Application.Contracts.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        // Implement all needed interfaces here
    }
}
