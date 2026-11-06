using System.ComponentModel.DataAnnotations;
using System.Net;
using SVG.Infra.Services;

public static class GoogleMapsChecks
{
    public static async Task Run()
    {
        int checks=0;
        void Check(bool value,string text){if(!value)throw new Exception(text);checks++;}
        var handler=new MapsHandler(_=>new HttpResponseMessage(HttpStatusCode.OK));
        using var client=new HttpClient(handler);
        var service=new GoogleMapsService(client);
        foreach(var link in new[]{
            "https://www.google.com/maps/search/?api=1&query=-15.1234567%2C-48.1234567",
            "https://maps.google.com/?q=-15.1234567,-48.1234567",
            "https://www.google.com.br/maps/place/Local/@-20,-40,16z/data=!4m2!3d-15.1234567!4d-48.1234567"})
        {
            var result=await service.ResolverAsync(link);
            Check(result.Latitude==-15.1234567m && result.Longitude==-48.1234567m,"Coordenadas incorretas ou confundidas com o centro da câmera.");
        }
        Check(handler.Calls==0,"Links com coordenadas não precisam de requisição externa.");
        foreach(var link in new[]{"http://www.google.com/maps?q=1,2","https://google.com.evil.test/maps?q=1,2",
            "https://127.0.0.1/maps?q=1,2","https://www.google.com:8443/maps?q=1,2","https://user@www.google.com/maps?q=1,2",
            "https://www.google.com/url?q=https://example.com","https://www.google.com/maps?q=91,0"})
        {
            try { await service.ResolverAsync(link); throw new Exception("Link inválido aceito."); }
            catch(ValidationException){ checks++; }
        }
        Check(handler.Calls==0,"URL não permitida gerou acesso externo.");
        var shortHandler=new MapsHandler(_=>Redirect("https://www.google.com/maps?q=-15,-48"));
        using var shortClient=new HttpClient(shortHandler);
        var shortResult=await new GoogleMapsService(shortClient).ResolverAsync("https://maps.app.goo.gl/exemplo");
        Check(shortResult.Latitude==-15 && shortResult.Longitude==-48 && shortHandler.Calls==1,"Encurtador não expandido.");
        var badHandler=new MapsHandler(_=>Redirect("https://127.0.0.1/private"));
        using var badClient=new HttpClient(badHandler);
        try{await new GoogleMapsService(badClient).ResolverAsync("https://goo.gl/maps/exemplo");throw new Exception("Redirecionamento externo aceito.");}
        catch(ValidationException){Check(badHandler.Calls==1,"Destino não permitido foi acessado.");}
        var loopHandler=new MapsHandler(_=>Redirect("https://maps.app.goo.gl/loop"));
        using var loopClient=new HttpClient(loopHandler);
        try{await new GoogleMapsService(loopClient).ResolverAsync("https://maps.app.goo.gl/loop");throw new Exception("Loop aceito.");}
        catch(ValidationException){Check(loopHandler.Calls==6,"Limite de redirecionamentos não respeitado.");}
        Check(GoogleMapsService.Extrair(new Uri("https://www.google.com/maps/place/Local/@-15,-48,16z"))==null,"Centro do mapa foi tratado como alvo.");
        Check(GoogleMapsService.Extrair(new Uri("https://www.google.com/maps/dir/A/B/data=!3d1!4d2!3d3!4d4"))==null,"Rota ambígua foi aceita.");
        Console.WriteLine($"Google Maps: {checks} verificações passaram (HTTP simulado, sem acesso externo).");
    }

    private static HttpResponseMessage Redirect(string url)
    {
        var response=new HttpResponseMessage(HttpStatusCode.Redirect);
        response.Headers.Location=new Uri(url);return response;
    }

    private sealed class MapsHandler(Func<HttpRequestMessage,HttpResponseMessage> response) : HttpMessageHandler
    {
        public int Calls {get;private set;}
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,CancellationToken cancellationToken)
        { Calls++; return Task.FromResult(response(request)); }
    }
}
