namespace FigureShop.POS.Data.Models;

public class Role
{
    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}