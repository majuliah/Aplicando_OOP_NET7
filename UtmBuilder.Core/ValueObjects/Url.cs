namespace UtmBuilder.Core.ValueObjects;

public class Url: ValueObject
{
    public Url(string adress)
    {
        Adress = adress;
    }
    public string Adress { get; }
}