using System.Runtime.Caching;

namespace SVG.Infra.FunctionsDB
{
  public static class XAppCache
  {
    private static readonly ObjectCache cache = MemoryCache.Default;

    public static T Get<T>(string pKey) where T : class
    {
      T result;
      result = (T)cache.Get(pKey);
      return result;
    }

    public static string NewKey(params object[] pValues)
    {
      var key = string.Empty;
      foreach (var value in pValues)
        key += value.ToString();

      return key;
    }

    public static bool Has(string pKey)
    {
      return cache.Contains(pKey);
    }

    public static T Alter<T>(string pKey, T pObject)
    {
      var policy = new CacheItemPolicy();
      cache.Set(pKey, pObject, policy);
      return pObject;
    }


    public static T Set<T>(string pKey, T pObject)
    {
      var policy = new CacheItemPolicy
      {
        AbsoluteExpiration = DateTimeOffset.Now.AddYears(1)
      };
      cache.Add(pKey, pObject, policy);
      return pObject;
    }
  }
}
