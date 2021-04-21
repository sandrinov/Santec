using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Santec_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Santec_Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<SantecUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
