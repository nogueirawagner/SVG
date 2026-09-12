using AutoMapper;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.WebApp.Models;

namespace SVG.WebApp.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
  {
    public DomainToViewModelMappingProfile()
    {
      CreateMap<Operador, OperadorViewModel>();
      CreateMap<Operacao, OperacaoViewModel>();
      CreateMap<ViaturaMovimentacao, ViaturaRetiradaViewModel>();

      CreateMap<Operacao, OperacaoViewModel>()
      .ForMember(dest => dest.TipoOperacaoNome,
               opt => opt.MapFrom(src => src.TipoOperacao.Nome));

    }
  }
}