using AutoMapper;
using SVG.App.ViewModels;
using SVG.Domain.Entities;
using SVG.WebApp.Models;

namespace SVG.WebApp.AutoMapper
{
  public class ViewModelToDomainMappingProfile : Profile
  {
    public ViewModelToDomainMappingProfile()
    {
      CreateMap<OperadorViewModel, Operador>();
      CreateMap<OperacaoViewModel, Operacao>();

      CreateMap<ViaturaRetiradaViewModel, ViaturaMovimentacao>()
      .ForMember(x => x.ID, opt => opt.Ignore())
      .ForMember(x => x.Viatura, opt => opt.Ignore())
      .ForMember(x => x.Operador, opt => opt.Ignore());
    }
  }
}