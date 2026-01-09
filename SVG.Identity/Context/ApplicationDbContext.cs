using GestaoDDD.Domain.Entities.Identity;
using SVG.Identity.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace SVG.Identity.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("ConnectionLocalCaio", throwIfV1Schema: false)
        {
        }

        DbSet<Client> Client { get; set; }
        DbSet<Claims> Claims { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
