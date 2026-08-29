using System;
using System.Data.SqlClient;
using System.Globalization;

public static class SqlDebugExtensions
{
  public static string ToDebugSql(
      this string sql,
      params SqlParameter[] parametros)
  {
    var sqlDebug = sql;

    foreach (var parametro in parametros
                 .OrderByDescending(p => p.ParameterName.Length))
    {
      string valor;

      if (parametro.Value == null || parametro.Value == DBNull.Value)
      {
        valor = "NULL";
      }
      else if (parametro.Value is DateTime data)
      {
        valor = $"'{data:yyyy-MM-dd HH:mm:ss.fff}'";
      }
      else if (parametro.Value is string texto)
      {
        valor = $"'{texto.Replace("'", "''")}'";
      }
      else if (parametro.Value is bool booleano)
      {
        valor = booleano ? "1" : "0";
      }
      else
      {
        valor = Convert.ToString(
            parametro.Value,
            CultureInfo.InvariantCulture
        );
      }

      sqlDebug = sqlDebug.Replace(
          parametro.ParameterName,
          valor
      );
    }

    return sqlDebug;
  }
}