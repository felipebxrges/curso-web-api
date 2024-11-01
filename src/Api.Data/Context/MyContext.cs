﻿using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Data.Mapping;

namespace Data.Context
{
    internal class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext (DbContextOptions<MyContext> options) :base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
        }
    }
}
