using System;
using System.Collections.Generic;

namespace FigureShop.POS.Models;

public partial class OrderFigure
{
    public Guid UserId { get; set; }

    public Guid FigureId { get; set; }

    public Guid OrderId { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public virtual Figure Figure { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
