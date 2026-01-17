
namespace SVG.Identity
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
