using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SVG.Identity.Identity.Context
{
  public class ApplicationDbContext : IdentityDbContext, IDisposable
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
    {
      
    }
  }
}
