namespace SVG.WebApp.Configurations
{
  public interface IUserContext
  {
    bool IsAuthenticated { get; }
    bool IsAdmin { get; }
    bool IsOperador { get; }
    int? OperadorId { get; }
    string UserName { get; }
    string Matricula { get; }
  }
}
