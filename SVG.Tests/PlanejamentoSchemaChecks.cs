using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using SVG.Infra.Context.SQLServer;

public static class PlanejamentoSchemaChecks
{
    // Compila os mapeamentos em memória; não abre conexão nem executa migration.
    public static XDocument BuildModel()
    {
        var builder=new DbModelBuilder();
        var entity=typeof(DbModelBuilder).GetMethod("Entity")!;
        foreach(var property in typeof(SQLServerContext).GetProperties().Where(p=>p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition()==typeof(DbSet<>)))
            entity.MakeGenericMethod(property.PropertyType.GetGenericArguments()[0]).Invoke(builder,null);
        using var context=new SQLServerContext();
        typeof(SQLServerContext).GetMethod("OnModelCreating",BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(context,new[]{builder});
        var model=builder.Build(new DbProviderInfo("System.Data.SqlClient","2012"));
        var xml=new XDocument(); using(var writer=xml.CreateWriter()) EdmxWriter.WriteEdmx(model,writer);
        return xml;
    }
    public static void Run()
    {
        var xml=BuildModel();
        XNamespace ns="http://schemas.microsoft.com/ado/2009/11/edm/ssdl";
        var types=xml.Descendants(ns+"EntityType").ToDictionary(e=>(string)e.Attribute("Name")!);
        if(!types.ContainsKey("PlanejamentoAlvo") || types["Alvo"].Elements(ns+"Property").Any(p=>(string?)p.Attribute("Name")=="PlanejamentoID")) throw new Exception("Mapeamento N:N incorreto.");
        var version=types["Planejamento"].Elements(ns+"Property").Single(p=>(string?)p.Attribute("Name")=="Versao");
        foreach(var nome in new[]{"AnexoAlvo","AnexoPlanejamento"})
        {
            var properties=types[nome].Elements(ns+"Property").Select(p=>(string?)p.Attribute("Name")).ToList();
            if(properties.Contains("Conteudo") || !properties.Contains("Caminho") || !properties.Contains("DataHoraCriacao"))
                throw new Exception("Mapeamento de anexo não segue armazenamento externo.");
        }
        if((string?)version.Attribute("Type")!="rowversion")throw new Exception("Controle de concorrência não mapeado.");
        var latest=typeof(SQLServerContext).Assembly.GetTypes()
            .Where(t=>!t.IsAbstract && typeof(System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata).IsAssignableFrom(t))
            .Select(t=>(System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata)Activator.CreateInstance(t)!)
            .OrderBy(m=>m.Id,StringComparer.Ordinal).Last();
        using var compressed=new MemoryStream(Convert.FromBase64String(latest.Target));
        using var decompressed=new System.IO.Compression.GZipStream(compressed,System.IO.Compression.CompressionMode.Decompress);
        var snapshot=XDocument.Load(decompressed);
        if(!snapshot.Descendants(ns+"EntityType").Single(e=>(string?)e.Attribute("Name")=="Planejamento")
            .Elements(ns+"Property").Any(p=>(string?)p.Attribute("Name")=="Link_Endereco_Alvo"))
            throw new Exception("Snapshot da migration não contém Link_Endereco_Alvo.");
        foreach(var nome in new[]{"Planejamento","PlanejamentoIntegrante","AnexoPlanejamento"})
        {
            var atual=types[nome].Elements(ns+"Property").Select(p=>(string?)p.Attribute("Name")).ToHashSet();
            var persistido=snapshot.Descendants(ns+"EntityType").Single(e=>(string?)e.Attribute("Name")==nome)
                .Elements(ns+"Property").Select(p=>(string?)p.Attribute("Name")).ToHashSet();
            if(!atual.SetEquals(persistido))throw new Exception("Snapshot diverge dos campos de "+nome);
        }
        Console.WriteLine("Planejamento: modelo EF6 compilado e relações verificadas sem banco.");
    }
}
