using System.Collections.ObjectModel;

namespace TreeMapLayoutTypeChange;

/// <summary>
/// Represents the view model for the layout type functionality.
/// </summary>
public class LayoutTypeViewModel
{
    /// <summary>
    /// Gets or sets the collection of layout type details.
    /// </summary>
    public ObservableCollection<LayoutTypes> LayoutType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LayoutTypeViewModel"/> class.
    /// </summary>
    public LayoutTypeViewModel()
	{
        this.LayoutType = new ObservableCollection<LayoutTypes>();
        this.LayoutType.Add(new LayoutTypes() { Name = "Squarified" });
        this.LayoutType.Add(new LayoutTypes() { Name = "Slice and dice auto" });
        this.LayoutType.Add(new LayoutTypes() { Name = "Slice and dice horizontal" });
        this.LayoutType.Add(new LayoutTypes() { Name = "Slice and dice vertical" });
    }
}