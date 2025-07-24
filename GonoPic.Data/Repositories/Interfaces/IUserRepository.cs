﻿using GonoPic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonoPic.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {   
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task AddAsync (User user);
        Task UpdateAsync (User user);
        Task DeleteAsync (int id);

    }
}
