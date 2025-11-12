namespace FigureShop.POS.Data.Models;

public partial class Voucher
{
    public Guid Id { get; set; }

    public double? MinPriceCanUse { get; set; }

    public double? MaxPriceCanDiscount { get; set; }

    public string Description { get; set; } = null!;

    public int Quantity { get; set; }

    public bool IsActive { get; set; }

    public double SalePercent { get; set; }

    public DateTime UsedFrom { get; set; }

    public DateTime UsedTo { get; set; }

    public string FiguresAvailable { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
