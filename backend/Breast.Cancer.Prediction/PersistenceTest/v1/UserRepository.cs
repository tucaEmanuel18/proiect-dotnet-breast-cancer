﻿using Application.Interfaces;
using Domain.Entities;
using Persistence.Context;


namespace Persistence.v1
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UserContext context): base(context)
        {
        }
    }
}
