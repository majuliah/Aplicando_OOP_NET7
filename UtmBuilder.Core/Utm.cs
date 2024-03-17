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

    public static implicit operator string(Utm utm) => utm.ToString();
    
    public override string ToString()
    {
        var segments = new List<string>();
        segments.AddIfNotNull("utm_source", Campaign.Source);
        segments.AddIfNotNull("utm_medium", Campaign.Source);
        segments.AddIfNotNull("utm_id", Campaign.Id);
        segments.AddIfNotNull("utm_term", Campaign.Term);
        segments.AddIfNotNull("utm_content", Campaign.Content);
        return $"{Url.Adress}?{string.Join("&", segments)}";
    }
}
