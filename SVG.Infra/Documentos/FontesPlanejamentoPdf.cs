using PdfSharp.Fonts;
namespace SVG.Infra.Documentos;

internal sealed class FontesPlanejamentoPdf : IFontResolver
{
    private static readonly object Trava=new();
    public static void Configurar()
    {
        lock(Trava)
        {
            if(GlobalFontSettings.FontResolver==null) GlobalFontSettings.FontResolver=new FontesPlanejamentoPdf();
        }
    }
    public FontResolverInfo ResolveTypeface(string familyName, bool bold, bool italic) => new(bold?"DejaVuSans-Bold":"DejaVuSans",false,italic);
    public byte[] GetFont(string faceName)
    {
        using var stream=typeof(FontesPlanejamentoPdf).Assembly.GetManifestResourceStream($"SVG.Infra.Documentos.Fontes.{faceName}.ttf")
            ?? throw new InvalidOperationException("Fonte do PDF não encontrada.");
        using var buffer=new MemoryStream();stream.CopyTo(buffer);return buffer.ToArray();
    }
}
