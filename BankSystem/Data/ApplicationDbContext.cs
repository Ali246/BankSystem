using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bank> bank { get; set; }
        public DbSet<BankAccount> bankaccount { get; set; }
        public DbSet<Currency> currency { get; set; }
        public DbSet<Agency> agency { get; set; }
        public DbSet<Contact> contact { get; set; }
    } 
}
