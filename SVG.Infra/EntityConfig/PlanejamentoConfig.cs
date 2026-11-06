using System.Data.Entity;
using SVG.Domain.Entities;

namespace SVG.Infra.EntityConfig;

public static class PlanejamentoConfig
{
    public static void Configurar(DbModelBuilder b)
    {
        var p=b.Entity<Planejamento>();
        p.HasRequired(x=>x.Secao).WithMany().HasForeignKey(x=>x.SecaoID).WillCascadeOnDelete(false);
        p.Property(x=>x.LocalBriefing).HasMaxLength(300);
        p.Property(x=>x.HorarioBriefingDOE).HasColumnType("time");
        p.Property(x=>x.HorarioSaidaDOE).HasColumnType("time");
        p.Property(x=>x.HorarioBriefingDP).HasColumnType("time");
        p.Property(x=>x.SocorristaAPH1).HasMaxLength(200);
        p.Property(x=>x.SocorristaAPH2).HasMaxLength(200);
        p.Property(x=>x.MotoristaVtrAPH).HasMaxLength(200);
        p.Property(x=>x.PrefixoVtrAPH).HasMaxLength(100);
        p.Property(x=>x.ResponsavelRelatorio).HasMaxLength(200);
        p.Property(x=>x.ResponsavelFotoMBA).HasMaxLength(200);
        p.Property(x=>x.CoordenadaZPH).HasMaxLength(200);
        p.Property(x=>x.Link_Rota_DOE_Unidade_Apoio).HasMaxLength(2048);
        p.Property(x=>x.Link_Rota_DP_Desemb).HasMaxLength(2048);
        p.Property(x=>x.Link_Localizacao_Desemb).HasMaxLength(2048);
        p.Property(x=>x.Link_Localizacao_Hospital_1).HasMaxLength(2048);
        p.Property(x=>x.Link_Localizacao_Hospital_2).HasMaxLength(2048);
        p.Property(x=>x.DistanciaRotaDOEUnidadeApoioKm).HasPrecision(10,2);

        p.Property(x=>x.DistanciaRotaDPDesembKm).HasPrecision(10,2);

        p.Property(x=>x.NumeroMBA).HasMaxLength(100);
        p.Property(x=>x.Titulo).IsRequired().HasMaxLength(200);
        p.Property(x=>x.Situacao).IsRequired().HasMaxLength(20);
        p.Property(x=>x.UnidadeApoio).HasMaxLength(200);
        p.Property(x=>x.Objetivo).HasMaxLength(8000);
        p.Property(x=>x.Endereco).HasMaxLength(1000);
        p.Property(x=>x.Referencia).HasMaxLength(1000);
        p.Property(x=>x.CanalViaturas).HasMaxLength(200);
        p.Property(x=>x.CanalOperadores).HasMaxLength(200);
        p.Property(x=>x.ApoioMedico).HasMaxLength(8000);
        p.Property(x=>x.Particularidades).HasMaxLength(8000);
        p.Property(x=>x.Link_Endereco_Alvo).HasMaxLength(2048);
        p.Property(x=>x.Latitude).HasPrecision(10,7);
        p.Property(x=>x.Longitude).HasPrecision(10,7);
        p.Property(x=>x.Versao).IsRowVersion();
        p.HasIndex(x=>x.SecaoID);
        var a=b.Entity<Alvo>();
        a.Property(x=>x.Nome).IsRequired().HasMaxLength(200);
        a.Property(x=>x.Alcunha).HasMaxLength(200);
        a.Property(x=>x.CPF).HasMaxLength(11);
        a.Property(x=>x.NomeMae).HasMaxLength(200);
        a.Property(x=>x.NomePai).HasMaxLength(200);
        a.HasIndex(x=>x.Nome);
        // Índice único filtrado de CPF é definido no script de revisão SQL.
        var v=b.Entity<PlanejamentoAlvo>();
        v.HasRequired(x=>x.Planejamento).WithMany(x=>x.Alvos).HasForeignKey(x=>x.PlanejamentoID).WillCascadeOnDelete(false);
        v.HasRequired(x=>x.Alvo).WithMany(x=>x.Planejamentos).HasForeignKey(x=>x.AlvoID).WillCascadeOnDelete(false);
        v.HasIndex(x=>new{x.PlanejamentoID,x.AlvoID}).IsUnique();
        v.HasIndex(x=>x.AlvoID);
        v.Property(x=>x.Codigo).HasMaxLength(30);
        v.Property(x=>x.Observacoes).HasMaxLength(8000);
        var an=b.Entity<AnexoAlvo>();
        an.HasRequired(x=>x.Alvo).WithMany(x=>x.Anexos).HasForeignKey(x=>x.AlvoID).WillCascadeOnDelete(false);
        an.Property(x=>x.NomeArquivo).IsRequired().HasMaxLength(255);
        an.Property(x=>x.TipoMime).IsRequired().HasMaxLength(100);
        an.Property(x=>x.Caminho).IsRequired().HasMaxLength(500);
        var info=b.Entity<InformacaoAlvo>();
        info.HasRequired(x=>x.Alvo).WithMany(x=>x.Informacoes).HasForeignKey(x=>x.AlvoID).WillCascadeOnDelete(false);
        info.Property(x=>x.Texto).IsRequired().HasMaxLength(8000);
        info.Property(x=>x.Fonte).HasMaxLength(500);
        var item=b.Entity<PlanejamentoItem>();
        item.HasRequired(x=>x.Planejamento).WithMany(x=>x.Itens).HasForeignKey(x=>x.PlanejamentoID).WillCascadeOnDelete(false);
        item.Property(x=>x.Tipo).IsRequired().HasMaxLength(20);
        item.Property(x=>x.Descricao).IsRequired().HasMaxLength(1000);
        item.Property(x=>x.Responsavel).HasMaxLength(200);
        item.Property(x=>x.Url).HasMaxLength(2000);
        item.Property(x=>x.DistanciaKm).HasPrecision(10,2);
        var eq=b.Entity<PlanejamentoIntegrante>();
        eq.HasRequired(x=>x.Planejamento).WithMany(x=>x.Integrantes).HasForeignKey(x=>x.PlanejamentoID).WillCascadeOnDelete(false);
        eq.HasRequired(x=>x.Operador).WithMany().HasForeignKey(x=>x.OperadorID).WillCascadeOnDelete(false);
        eq.HasOptional(x=>x.Viatura).WithMany().HasForeignKey(x=>x.ViaturaID).WillCascadeOnDelete(false);
        eq.Property(x=>x.Entrada).HasMaxLength(100);
        eq.Property(x=>x.Funcao).IsRequired().HasMaxLength(300);
        eq.HasIndex(x=>new{x.PlanejamentoID,x.OperadorID}).IsUnique();
        var ap=b.Entity<AnexoPlanejamento>();
        ap.HasRequired(x=>x.Planejamento).WithMany(x=>x.Anexos).HasForeignKey(x=>x.PlanejamentoID).WillCascadeOnDelete(false);
        ap.Property(x=>x.NomeArquivo).IsRequired().HasMaxLength(255);
        ap.Property(x=>x.TipoMime).IsRequired().HasMaxLength(100);
        ap.Property(x=>x.Caminho).IsRequired().HasMaxLength(500);
    }
}
