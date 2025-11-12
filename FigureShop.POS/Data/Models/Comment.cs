namespace FigureShop.POS.Data.Models;

public partial class Comment
{
    public Guid UserId { get; set; }

    public Guid FigureId { get; set; }

    public int Vote { get; set; }

    public string Content { get; set; } = null!;

    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public virtual Figure Figure { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
