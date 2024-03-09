using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects;

public class Url: ValueObject
{
    private const string UrlRegexPattern = @"";
    /// <summary>
    /// Creates a new url
    /// </summary>
    /// <param name="adress">Adress of url website link</param>
    public Url(string adress)
    {
        Adress = adress;
        if (Regex.IsMatch(Adress, UrlRegexPattern))
        {
            throw new Exception("Teste");
        }
    }
    /// <summary>
    /// Adress of url 
    /// </summary>
    /// <param name="Attribute"></param>
    public string Adress { get; } //não ter set = não altera | ter private set = altera dentro da classe
}