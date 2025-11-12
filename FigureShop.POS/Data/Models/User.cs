using System.ComponentModel.DataAnnotations;

namespace FigureShop.POS.Data.Models;

public partial class User
{
    public Guid Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }  

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }
    
    [StringLength(100)] // Good to set a max length
    public string? FullName { get; set; } // For "Tên NV"
    
    [StringLength(10)]
    public string? Gender { get; set; } // For "Giới tính" (e.g., "Nam", "Nữ")
    
    public DateTime? Birthday { get; set; } // For "Ngày sinh"
    
    [StringLength(20)]
    public string? PhoneNumber { get; set; } // For "SĐT"
    
    [StringLength(255)]
    public string? Address { get; set; } // For "Địa chỉ"

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

    public virtual ICollection<Role> RolesNames { get; set; } = new List<Role>();
}
