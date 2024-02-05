﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Model;

namespace Users.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUser();
    }
}
