using System;
using System.Collections.Generic;

namespace FigureShop.POS.Models;

public partial class Role
{
    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
