using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Planejamento;

namespace SVG.Infra.Services;

// O HttpClient deve ter AllowAutoRedirect=false: cada destino é validado antes do acesso.
public sealed class GoogleMapsService(HttpClient client) : IGoogleMapsService
{
    private const string Numero = @"[+-]?\d{1,3}(?:\.\d+)?";
    private const string SemCoordenadas = "Não foi possível identificar o ponto nesse link. No Google Maps, selecione o local e copie o link de compartilhar com o ponto marcado.";

    public async Task<XCoordenadasMaps> ResolverAsync(string link, CancellationToken cancellationToken = default)
    {
        var uri = ValidarUrl(link);
        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeout.CancelAfter(TimeSpan.FromSeconds(12));
        try
        {
            for (var salto = 0; salto < 6; salto++)
            {
                var coordenadas = Extrair(uri);
                if (coordenadas != null) return coordenadas;
                // Só expande encurtadores e links Maps. Não lê nem interpreta HTML remoto.
                using var request = new HttpRequestMessage(HttpMethod.Get, uri);
                using var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, timeout.Token);
                if (response.StatusCode is HttpStatusCode.MovedPermanently or HttpStatusCode.Redirect
                    or HttpStatusCode.SeeOther or HttpStatusCode.TemporaryRedirect or HttpStatusCode.PermanentRedirect)
                {
                    var location = response.Headers.Location;
                    if (location == null) break;
                    uri = ValidarUrl(new Uri(uri, location).AbsoluteUri);
                    continue;
                }
                break;
            }
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        { throw new ValidationException("O Google Maps demorou para responder. Tente novamente ou use o link completo do ponto."); }
        catch (HttpRequestException)
        { throw new ValidationException("Não foi possível consultar o Google Maps. Tente novamente ou use o link completo do ponto."); }
        throw new ValidationException(SemCoordenadas);
    }

    public static Uri ValidarUrl(string link)
    {
        if (string.IsNullOrWhiteSpace(link) || link.Length > 2048 || !Uri.TryCreate(link.Trim(), UriKind.Absolute, out var uri)
            || uri.Scheme != Uri.UriSchemeHttps || !uri.IsDefaultPort || uri.UserInfo.Length > 0)
            throw new ValidationException("Informe um link HTTPS válido do Google Maps (até 2048 caracteres).");
        var host = uri.IdnHost.ToLowerInvariant();
        var path = uri.AbsolutePath;
        var mapsPath = path == "/maps" || path.StartsWith("/maps/", StringComparison.Ordinal);
        var permitido = host == "maps.app.goo.gl"
            || host == "goo.gl" && path.StartsWith("/maps/", StringComparison.Ordinal)
            || (host is "google.com" or "www.google.com" or "google.com.br" or "www.google.com.br") && mapsPath
            || (host is "maps.google.com" or "maps.google.com.br") && (mapsPath || path == "/");
        if (!permitido) throw new ValidationException("Use um link de localização do Google Maps.");
        return uri;
    }

    public static XCoordenadasMaps? Extrair(Uri uri)
    {
        // Não confundir o centro da câmera (@latitude,longitude) com o ponto selecionado.
        var path = Uri.UnescapeDataString(uri.AbsolutePath);
        if (path.Contains("/dir/", StringComparison.Ordinal)) return null;
        var data = Uri.UnescapeDataString(uri.PathAndQuery);
        var pontos = Regex.Matches(data, $@"!3d({Numero})!4d({Numero})(?:!|&|$)");
        if (pontos.Count == 1) return Coordenadas(pontos[0].Groups[1].Value, pontos[0].Groups[2].Value);
        if (pontos.Count > 1) return null;
        foreach (var par in uri.Query.TrimStart('?').Split('&', StringSplitOptions.RemoveEmptyEntries))
        {
            var partes = par.Split('=', 2);
            if (partes.Length != 2 || partes[0] is not ("q" or "query")) continue;
            var valor = Uri.UnescapeDataString(partes[1].Replace('+', ' '));
            var match = Regex.Match(valor, $@"^\s*({Numero})\s*,\s*({Numero})\s*$");
            if (match.Success) return Coordenadas(match.Groups[1].Value, match.Groups[2].Value);
        }
        return null;
    }

    private static XCoordenadasMaps Coordenadas(string lat, string lon)
    {
        if (!decimal.TryParse(lat, NumberStyles.Float, CultureInfo.InvariantCulture, out var latitude)
            || !decimal.TryParse(lon, NumberStyles.Float, CultureInfo.InvariantCulture, out var longitude)
            || latitude is < -90 or > 90 || longitude is < -180 or > 180)
            throw new ValidationException("O link contém coordenadas inválidas.");
        return new(decimal.Round(latitude, 7), decimal.Round(longitude, 7));
    }
}
