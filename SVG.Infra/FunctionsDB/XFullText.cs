namespace SVG.Infra.FunctionsDB
{
  public class XFullText
  {
    protected List<String> Chaves;

    public static String MontarCondicao(String pFrase, String pColunaPesquisa, out List<String> pChaves)
    {
      return GerarCondicao(pFrase, pColunaPesquisa, out pChaves);
    }

    public static String GerarCondicao(String pFrase, string pColunaPesquisa, out List<String> pChaves)
    {
      var Chaves = new List<string>();
      var CondicaoThesaurusUtilizada = "";
      var contains = "";
      var chavesQuebradas = QuebrarFrase(pFrase);

      foreach (var parte in chavesQuebradas)
      {
        if (String.IsNullOrEmpty(parte))
          continue;
        //Se já foi adicionada alguma condição, devemos adicionar o OR antes de adicionar uma nova
        if (CondicaoThesaurusUtilizada.Length > 0)
          CondicaoThesaurusUtilizada += ", ";

        if (parte.Contains('+'))
        { // Se contiver + montar AND entre as palavras
          var sPartes = parte.Split('+');

          var condicaoAnd = "";

          foreach (var palavra in sPartes)
          {
            Chaves.Add(palavra);
            if (String.IsNullOrEmpty(palavra))
              continue;

            if (condicaoAnd.Length > 0)
              condicaoAnd += " AND ";

            condicaoAnd += " \"" + palavra.ToUpper() + "\" ";
          }

          CondicaoThesaurusUtilizada += condicaoAnd;
        }
        else
        {
          Chaves.Add(parte);
          CondicaoThesaurusUtilizada += "\"" + parte.ToUpper() + "\" ";
        }
      }

      pChaves = Chaves;
      if (chavesQuebradas.Length > 1)
        contains = string.Format(" CONTAINS({0}, 'NEAR({1})')", pColunaPesquisa, CondicaoThesaurusUtilizada);
      else
        contains = string.Format("CONTAINS({0}, '{1}')", pColunaPesquisa, CondicaoThesaurusUtilizada);

      return contains;
    }

    public static String[] QuebrarFrase(String pFrase)
    {
      //remover espaços ao redor do + para evitar dividir palavras que possuem + entre elas
      while (pFrase.IndexOf(" +", StringComparison.Ordinal) != -1)
        pFrase = pFrase.Replace(" +", "+");

      while (pFrase.IndexOf("+ ", StringComparison.Ordinal) != -1)
        pFrase = pFrase.Replace("+ ", "+");

      //caso a quantidade de " presente na string seja impar, ignore a última
      if (System.Text.RegularExpressions.Regex.Matches(pFrase, "\"").Count % 2 == 1)
      {
        int idx = pFrase.LastIndexOf('"');

        pFrase = pFrase.Substring(0, idx) + pFrase.Substring(idx + 1);
      }

      var partes = System.Text.RegularExpressions.Regex.Split(pFrase, "\"([^\"]+)\"|\\s").Where(x => x.Length > 0).ToArray();
      var partesGrandes = partes.Where(x => x.Length > 2).ToArray();

      return partesGrandes.Length > 0 ? partesGrandes : partes;
    }
  }
}
