using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm
{
    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }
    /// <summary>
    /// URL website link
    /// </summary>
    public Url Url { get; }
    
    /// <summary>
    /// Campaign details
    /// </summary>
    public Campaign Campaign { get; init; } 
    
    public override string ToString()
    {
        var segments = new List<string>();
        segments.AddIfNotNull();
        return $"{Url.Adress}?{string.Join("&", segments)}";
    }
}
