using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AUTHORIZATION1.Data;

namespace AUTHORIZATION1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AUTHORIZATION1.Data.AuditTable> AuditTable { get; set; }
        public DbSet<AUTHORIZATION1.Data.Departments> Departments { get; set; }
        public DbSet<AUTHORIZATION1.Data.Employees> Employees { get; set; }
        public DbSet<AUTHORIZATION1.Data.NetUser> NetUser { get; set; }
        public DbSet<AUTHORIZATION1.Data.UserRole> UserRole { get; set; }
        public DbSet<AUTHORIZATION1.Data.CommentHere> Comment { get; set; }
    }
}
