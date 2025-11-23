
using AutoMapper;
using Microsoft.Extensions.Logging.Abstractions;

namespace SVG.WebApp.AutoMapper
{
  public class AutoMapperConfig
  {
    private static MapperConfiguration _config;
    public static IMapper Mapper { get; private set; }

    public static MapperConfiguration RegisterMappings()
    {
      ILoggerFactory loggerFactory = NullLoggerFactory.Instance;

      _config = new MapperConfiguration(cfg =>
      {
        cfg.AddProfile<DomainToViewModelMappingProfile>();
        cfg.AddProfile<ViewModelToDomainMappingProfile>();
      }, loggerFactory);

      Mapper = _config.CreateMapper();
      return _config;
    }
  }
}