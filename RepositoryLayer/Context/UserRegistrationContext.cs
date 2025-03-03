﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    public class UserRegistrationContext:DbContext
    {
        public UserRegistrationContext(DbContextOptions<UserRegistrationContext> options) : base(options) { }
        public virtual DbSet<Entity.UserEntity> Users { get; set; } 
    }
}
