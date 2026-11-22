using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SVG.App.Interface;
using SVG.App.Interfaces;
using SVG.App.ViewModels;
using SVG.Domain.TiposEstruturados.Planejamento;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.WebApp.Configurations;

namespace SVG.WebApp.Controllers;

[Authorize]
[ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
public class PlanejamentoController(IPlanejamentoAppService service, IOperadorAppService operadores,
    IViaturaAppService viaturas, ISessaoAppService sessoes, IUserContext usuario, ILogger<PlanejamentoController> logger, SVG.Domain.Interfaces.Services.IArmazenamentoAnexos armazenamento,
    SVG.Domain.Interfaces.Services.IGoogleMapsService googleMaps, IPlanejamentoDocumentoAppService documentos) : Controller
{
    [HttpGet]
    public IActionResult Index(string? termo, bool minhaSecao=false)
    {
        ViewBag.Termo=termo; ViewBag.MinhaSecao=minhaSecao;
        ViewBag.Resultados=service.BuscarAlvos(termo??"");
        var secao=usuario.OperadorId.HasValue?operadores.GetById(usuario.OperadorId.Value)?.SessaoID:null;
        if(minhaSecao && secao==null)
        {
            ViewBag.Aviso="Seu usuário não possui operador/seção associado.";
            return View(Array.Empty<XPlanejamentoResumo>());
        }
        return View(service.Listar(minhaSecao?secao:null));
    }
    [HttpGet]
    public IActionResult Mapa() => View(service.ListarMapa());

    [HttpGet]
    public IActionResult BuscarAlvos(string? termo) => Json(service.BuscarAlvos(termo??""));
    [HttpPost, ValidateAntiForgeryToken, Authorize(Roles="Admin,Operador")]
    public async Task<IActionResult> CoordenadasMaps(string link, CancellationToken cancellationToken)
    {
        if(!usuario.OperadorId.HasValue) return Forbid();
        try { return Json(await googleMaps.ResolverAsync(link, cancellationToken)); }
        catch(ValidationException ex) { return BadRequest(new { mensagem=ex.Message }); }
    }
    [HttpGet]
    public IActionResult Alvo(int id)
    {
        var alvo=service.ObterAlvo(id); return alvo==null?NotFound():View(alvo);
    }
    [HttpGet]
    public IActionResult Foto(int id)
    {
        var foto=service.ObterFoto(id);
        if(foto==null) return NotFound();
        Response.Headers["X-Content-Type-Options"]="nosniff";
        var stream=armazenamento.Abrir(foto.Caminho);
        return stream==null?NotFound():File(stream,foto.TipoMime,enableRangeProcessing:true);
    }
    [HttpGet]
    public IActionResult Detalhes(int id)
    {
        var p=service.Obter(id); if(p==null)return NotFound();
        ViewBag.PodeEditar=p.Situacao=="Rascunho" && usuario.OperadorId.HasValue && (usuario.IsAdmin || p.CriadorOperadorID==usuario.OperadorId);
        return View(p);
    }
    [HttpPost, ValidateAntiForgeryToken, Authorize(Roles="Admin,Operador")]
    public IActionResult Excluir(int id,string versao)
    {
        if(!usuario.OperadorId.HasValue)return Forbid();
        try
        {
            service.Excluir(id,versao,new XAutorPlanejamento(usuario.OperadorId.Value,usuario.IsAdmin));
            TempData["Sucesso"]="Planejamento excluído. Os cadastros dos alvos foram preservados.";
        }
        catch(KeyNotFoundException){return NotFound();}
        catch(UnauthorizedAccessException){return Forbid();}
        catch(ValidationException ex){TempData["Erro"]=ex.Message;}
        catch(Exception ex)
        {
            logger.LogError(ex,"Falha ao excluir planejamento {PlanejamentoID}",id);
            TempData["Erro"]="Não foi possível excluir o planejamento. Atualize a listagem e tente novamente.";
        }
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult GerarPdf(int id)
    {
        try
        {
            var urlBase=$"{Request.Scheme}://{Request.Host}{Request.PathBase}";
            var documento=documentos.GerarPdf(id,urlBase);
            if(documento==null) return NotFound();
            Response.Headers["X-Content-Type-Options"]="nosniff";
            return File(documento.Conteudo,"application/pdf",documento.NomeArquivo);
        }
        catch(ValidationException ex) { TempData["ErroPdf"]=ex.Message; }
        catch(Exception ex)
        {
            logger.LogError(ex,"Falha ao gerar PDF do planejamento {PlanejamentoID}",id);
            TempData["ErroPdf"]="Não foi possível gerar o PDF. Tente novamente ou contate o administrador.";
        }
        return RedirectToAction(nameof(Detalhes),new{id});
    }

    [HttpGet]
    public IActionResult Anexo(int id)
    {
        var anexo=service.ObterAnexo(id); if(anexo==null)return NotFound();
        Response.Headers["X-Content-Type-Options"]="nosniff";
        var stream=armazenamento.Abrir(anexo.Caminho);
        return stream==null?NotFound():File(stream,anexo.TipoMime,anexo.NomeArquivo,enableRangeProcessing:true);
    }
    [HttpGet]
    public IActionResult Midia(int id)
    {
        var anexo=service.ObterAnexo(id); if(anexo==null)return NotFound();
        if(anexo.TipoMime is not ("image/png" or "image/jpeg" or "video/mp4" or "video/webm"))return NotFound();
        Response.Headers["X-Content-Type-Options"]="nosniff";
        var stream=armazenamento.Abrir(anexo.Caminho);
        return stream==null?NotFound():File(stream,anexo.TipoMime,enableRangeProcessing:true);
    }
    [HttpGet]
    public IActionResult AnexoAlvo(int id)
    {
        var anexo=service.ObterAnexoAlvo(id); if(anexo==null)return NotFound();
        Response.Headers["X-Content-Type-Options"]="nosniff";
        var stream=armazenamento.Abrir(anexo.Caminho);
        return stream==null?NotFound():File(stream,anexo.TipoMime,anexo.NomeArquivo,enableRangeProcessing:true);
    }
    [HttpGet, Authorize(Roles="Admin,Operador")]
    public IActionResult Criar()
    {
        if(!usuario.OperadorId.HasValue) return SemOperador();
        Combos(); return View("Editar", new PlanejamentoViewModel());
    }
    [HttpGet, Authorize(Roles="Admin,Operador")]
    public IActionResult Editar(int id)
    {
        var p=service.Obter(id); if(p==null)return NotFound();
        if(!usuario.OperadorId.HasValue)return SemOperador();
        if(!usuario.IsAdmin && p.CriadorOperadorID!=usuario.OperadorId)return Forbid();
        if(p.Situacao!="Rascunho") return RedirectToAction(nameof(Detalhes),new{id});
        ViewBag.AnexosPlanejamento=p.Anexos;
        Combos(); return View(service.PrepararEdicao(id));
    }
    [HttpPost, ValidateAntiForgeryToken, Authorize(Roles="Admin,Operador")]
    [RequestSizeLimit(105 * 1024 * 1024)]
    [RequestFormLimits(MultipartBodyLengthLimit=105 * 1024 * 1024, ValueCountLimit=5000)]
    public async Task<IActionResult> Salvar(PlanejamentoViewModel model, bool finalizar=false)
    {
        if(!usuario.OperadorId.HasValue)return SemOperador();
        var fotos=new List<XAnexoAlvoEntrada>();
        var anexos=new List<XArquivoPlanejamentoEntrada>();
        try
        {
            foreach(var file in Request.Form.Files.Where(f=>f.Length>0))
            {
                if(file.Name.StartsWith("AnexosPlanejamento_",StringComparison.Ordinal))
                {
                    if(!int.TryParse(file.Name["AnexosPlanejamento_".Length..],out var codigo)
                        || !Enum.IsDefined(typeof(XSubgrupoImagemPlanejamento),codigo))
                        throw new ValidationException("Subgrupo de imagem inválido.");
                    if(file.Length>50*1024*1024)throw new ValidationException("Cada anexo pode ter até 50 MB.");
                    using var arquivo=new MemoryStream();await file.CopyToAsync(arquivo);
                    anexos.Add(new(file.FileName,arquivo.ToArray(),(XSubgrupoImagemPlanejamento)codigo));continue;
                }
                var principal=file.Name.StartsWith("Foto_");
                var prefixo=principal?"Foto_":"AnexosAlvo_";
                if(!file.Name.StartsWith(prefixo) || !int.TryParse(file.Name[prefixo.Length..],out var index))
                    throw new ValidationException("Campo de anexo inválido.");
                if(file.Length>(principal?5L:50L)*1024*1024) throw new ValidationException("Foto principal: até 5 MB. Demais anexos: até 50 MB.");
                using var memory=new MemoryStream(); await file.CopyToAsync(memory);
                fotos.Add(new XAnexoAlvoEntrada(index,file.FileName,memory.ToArray(),principal));
            }
            // O link é a fonte das coordenadas; valores enviados pelo navegador não são confiáveis.
            ModelState.Remove(nameof(model.Latitude)); ModelState.Remove(nameof(model.Longitude));
            model.Latitude=null; model.Longitude=null;
            model.Link_Endereco_Alvo=string.IsNullOrWhiteSpace(model.Link_Endereco_Alvo)?null:model.Link_Endereco_Alvo.Trim();
            if(model.Link_Endereco_Alvo!=null)
            {
                var ponto=await googleMaps.ResolverAsync(model.Link_Endereco_Alvo, HttpContext.RequestAborted);
                model.Latitude=ponto.Latitude; model.Longitude=ponto.Longitude;
            }
            else if(model.ID>0)
            {
                var anterior=service.Obter(model.ID);
                // Preserva coordenadas de registros anteriores à introdução do link.
                if(anterior!=null && string.IsNullOrWhiteSpace(anterior.Link_Endereco_Alvo))
                { model.Latitude=anterior.Latitude; model.Longitude=anterior.Longitude; }
            }
            if(ModelState.IsValid)
            {
                var id=service.Salvar(model,new XAutorPlanejamento(usuario.OperadorId.Value,usuario.IsAdmin),fotos,finalizar,anexos);
                TempData["Sucesso"]=finalizar?"Planejamento finalizado. O registro está disponível para consulta.":"Rascunho salvo.";
                return RedirectToAction(nameof(Detalhes),new{id});
            }
        }
        catch(UnauthorizedAccessException) { return Forbid(); }
        catch(KeyNotFoundException) { return NotFound(); }
        catch(ValidationException ex) { ModelState.AddModelError("",ex.Message); }
        catch(Exception ex)
        {
            logger.LogError(ex,"Falha ao salvar planejamento {PlanejamentoID}",model.ID);
            ModelState.AddModelError("","Não foi possível salvar. Nenhuma gravação desta solicitação foi confirmada. Reabra o registro ou tente novamente.");
        }
        if(fotos.Count>0 || anexos.Count>0)ModelState.AddModelError("","Selecione novamente fotos e anexos antes de reenviar o formulário.");
        // Nomes do alvo existente vêm do servidor, nunca do navegador.
        foreach(var alvo in (model.Alvos ??= new()).Where(a=>a.AlvoID.HasValue))
        {
            var existente=service.ObterAlvo(alvo.AlvoID!.Value);
            alvo.Nome=existente?.Nome??"Alvo não encontrado";
        }
        if(model.ID>0)ViewBag.AnexosPlanejamento=service.Obter(model.ID)?.Anexos;
        Combos(); return View("Editar",model);
    }
    private IActionResult SemOperador()
    {
        TempData["Erro"]="Vincule seu usuário a um operador com seção para cadastrar planejamentos.";
        return RedirectToAction(nameof(Index));
    }
    private void Combos()
    {
        var listaOperadores=operadores.GetAll().OrderBy(o=>o.Nome).ToList();
        ViewBag.Operadores=listaOperadores.Select(o=>new SelectListItem(o.Nome,o.ID.ToString())).ToList();
        ViewBag.OperadoresPorSecao=listaOperadores.Select(o=>new { o.ID, o.SessaoID, o.Nome, o.Matricula }).ToList();
        ViewBag.Sessoes=sessoes.GetAll().OrderBy(s=>s.Nome).Select(s=>new SelectListItem(s.Nome,s.ID.ToString())).ToList();
        var listaViaturas=viaturas.GetAll().ToList();
        ViewBag.ViaturasSecoes=listaViaturas.ToDictionary(v=>v.ID.ToString(),v=>v.SessaoID);
        ViewBag.Viaturas=listaViaturas.Select(v=>new SelectListItem(string.IsNullOrWhiteSpace(v.Prefixo)?v.Placa:v.Prefixo,v.ID.ToString())).OrderBy(v=>v.Text).ToList();
    }
}
