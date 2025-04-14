namespace TreeMapLayoutTypeChange;

public class PopulationDetails
{
    public PopulationDetails()
    {
        Country = string.Empty;
        Continent = string.Empty;
    }

    /// <summary>
    /// Gets or sets country name.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets continent name.
    /// </summary>
    public string Continent { get; set; }

    /// <summary>
    /// Gets or sets population details.
    /// </summary>
    public double Population { get; set; }
}
	