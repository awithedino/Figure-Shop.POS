using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FigureShop.POS.Models
{
    [Table("ChatLieu")]
    public class ChatLieu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChatLieu { get; set; }

        [Required]
        [StringLength(100)]
        public string TenChatLieu { get; set; }
    }
}