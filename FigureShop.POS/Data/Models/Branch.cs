namespace FigureShop.POS.Data.Models;

public partial class Branch
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public virtual ICollection<Figure> Figures { get; set; } = new List<Figure>();
}
