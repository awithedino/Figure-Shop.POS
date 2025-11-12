namespace FigureShop.POS.Data.Models;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid? VoucherId { get; set; }

    public string Status { get; set; } = null!;

    public double TotalPrice { get; set; }

    public double PaidPrice { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public virtual ICollection<OrderFigure> OrderFigures { get; set; } = new List<OrderFigure>();

    public virtual User User { get; set; } = null!;

    public virtual Voucher? Voucher { get; set; }
}
