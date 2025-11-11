using SVG.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SVG.Infra.EntityConfig
{
  public class OperadorConfiguration : EntityTypeConfiguration<Operador>
  {
    public OperadorConfiguration()
    {
      HasKey(c => c.ID);
      Property(c => c.ID).HasColumnName("ID").HasColumnOrder(1);
    }
  }
}
