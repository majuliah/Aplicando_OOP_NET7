namespace UtmBuilder.Core.ValueObjects;

public class Url: ValueObject
{
    /// <summary>
    /// Creates a new url
    /// </summary>
    /// <param name="adress">Adress of url website link</param>
    public Url(string adress)
    {
        Adress = adress;
    }
    /// <summary>
    /// Adress of url 
    /// </summary>
    /// <param name="Attribute"></param>
    public string Adress { get; } //não ter set = não altera | ter private set = altera dentro da classe
}