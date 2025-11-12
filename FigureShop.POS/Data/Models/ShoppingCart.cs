namespace FigureShop.POS.Data.Models;

public partial class ShoppingCart
{
    public Guid UserId { get; set; }

    public Guid FigureId { get; set; }

    public int Quantity { get; set; }

    public virtual Figure Figure { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
