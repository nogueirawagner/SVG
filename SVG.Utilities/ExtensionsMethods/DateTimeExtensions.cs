using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Utilities.ExtensionsMethods
{
  public static class DateTimeExtensions
  {
    private static TimeZoneInfo BrazilTimeZone()
    {
      try
      {
        return TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"); // Windows
      }
      catch
      {
        return TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo"); // Linux
      }
    }

    /// <summary>
    /// Converte para horário do Brasil SOMENTE se o DateTime estiver em UTC.
    /// Local e Unspecified são retornados como estão.
    /// </summary>
    public static DateTime ToBrazilTime(this DateTime dateTime)
    {
      if (dateTime.Kind == DateTimeKind.Utc)
      {
        return TimeZoneInfo.ConvertTimeFromUtc(dateTime, BrazilTimeZone());
      }

      // Local ou Unspecified → assume que já está correto
      return dateTime;
    }

    /// <summary>
    /// Overload para DateTime?
    /// </summary>
    public static DateTime? ToBrazilTime(this DateTime? dateTime)
    {
      if (!dateTime.HasValue) return null;
      return dateTime.Value.ToBrazilTime();
    }

    /// <summary>
    /// Garante que o DateTime seja tratado como Local.
    /// Útil para valores vindos de input datetime-local (Kind = Unspecified).
    /// </summary>
    public static DateTime AsLocal(this DateTime dateTime)
    {
      return dateTime.Kind == DateTimeKind.Unspecified
          ? DateTime.SpecifyKind(dateTime, DateTimeKind.Local)
          : dateTime;
    }

    /// <summary>
    /// Converte um DateTime local para UTC de forma segura.
    /// </summary>
    public static DateTime ToUtcSafe(this DateTime dateTime)
    {
      return dateTime.AsLocal().ToUniversalTime();
    }

    /// <summary>
    /// Converte um DateTime vindo de input datetime-local (sem fuso) para UTC,
    /// assumindo que o usuário digitou no horário de São Paulo.
    /// </summary>
    public static DateTime ToUtcFromBrazilInput(this DateTime input)
    {
      // ⚠️ Força Unspecified porque datetime-local NÃO tem timezone.
      var unspecified = DateTime.SpecifyKind(input, DateTimeKind.Unspecified);
      return TimeZoneInfo.ConvertTimeToUtc(unspecified, BrazilTimeZone());
    }

    public static DateTime ToBrazilFromUtc(this DateTime utc)
    {
      var dtUtc = utc.Kind == DateTimeKind.Utc ? utc : DateTime.SpecifyKind(utc, DateTimeKind.Utc);
      return TimeZoneInfo.ConvertTimeFromUtc(dtUtc, BrazilTimeZone());
    }

    public static DateTime? ToUtcFromBrazilInput(this DateTime? input)
    {
      if (!input.HasValue) return null;
      return input.Value.ToUtcFromBrazilInput();
    }

    public static DateTime? ToBrazilFromUtc(this DateTime? utc)
    {
      if (!utc.HasValue) return null;
      return utc.Value.ToBrazilFromUtc();
    }
  }
}
