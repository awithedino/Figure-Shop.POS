namespace FigureShop.POS.Data.Models;

public partial class Figure
{
    public Guid Id { get; set; }

    public Guid? BranchId { get; set; }

    public Guid? CategoryId { get; set; }

    public double Price { get; set; }

    public string ImgSrcJson { get; set; } = null!;

    public double SalePercent { get; set; }

    public int Quantity { get; set; }

    public DateTime? SaleFrom { get; set; }

    public DateTime? SaleTo { get; set; }

    public string Description { get; set; } = null!;

    public double Vote { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<OrderFigure> OrderFigures { get; set; } = new List<OrderFigure>();

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
}
