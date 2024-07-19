using MediatR;
using Message_Exchange_App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Exchange_App.Application.Features.Users.Queries.GetUser
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, User>
    {
        public async Task<User> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

// All commands and queries are send to mediator for treatment and mediator will send back the result