using AutoMapper;
using SVG.App.ViewModels;
using SVG.Domain.Entities;

namespace SVG.WebApp.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
  {
    public DomainToViewModelMappingProfile()
    {
      CreateMap<Operador, OperadorViewModel>();
      CreateMap<Operacao, OperacaoViewModel>();
    }
  }
}