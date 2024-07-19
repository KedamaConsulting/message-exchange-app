using MediatR;
using Message_Exchange_App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Exchange_App.Application.Features.Users.Queries.GetUser
{
    public class GetUserDetailQuery : IRequest<User> //Normally we should use User view model instead
    {
        //user Id propertiy
    }
}
