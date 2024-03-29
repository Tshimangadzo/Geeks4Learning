﻿using G4L.UserManagement.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4L.UserManagement.BL.Interfaces
{
    public interface IUserService
    {
        Task CreateNewUserAsync(User user);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
