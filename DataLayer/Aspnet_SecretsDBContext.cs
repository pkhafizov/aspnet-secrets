﻿using aspnet_secrets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_secrets.DataLayer
{
    public class Aspnet_SecretsDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public Aspnet_SecretsDBContext()
        {

        }

        public Aspnet_SecretsDBContext(DbContextOptions<Aspnet_SecretsDBContext> options)
            :base(options)
        {

        }
    }
}
