﻿using Microsoft.EntityFrameworkCore;
using LiveChat_Backend.DTOS;

namespace LiveChat_Backend.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<AccountDTO> accounts { get; set; }
        public DbSet<DialogDTO> dialogs { get; set; }
        public DbSet<MessageDTO> messages { get; set; }
        public DbSet<IntrestDTO> intrests { get; set; }

    }

}
