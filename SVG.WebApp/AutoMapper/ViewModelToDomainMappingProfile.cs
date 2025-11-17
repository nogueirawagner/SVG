using AutoMapper;
using SVG.App.ViewModels;
using SVG.Domain.Entities;

namespace SVG.WebApp.AutoMapper
{
  public class ViewModelToDomainMappingProfile : Profile
  {
    public ViewModelToDomainMappingProfile()
    {
      CreateMap<OperadorViewModel, Operador>();
    }
  }
}