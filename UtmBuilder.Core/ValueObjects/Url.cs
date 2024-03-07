namespace UtmBuilder.Core.ValueObjects;

public class Url: ValueObject
{
    public Url(string adress)
    {
        Adress = adress;
    }
    public string Adress { get; } //não ter set = não altera | ter private set = altera dentro da classe
}