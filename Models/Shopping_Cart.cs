#nullable disable
namespace Supply_Chain_Backend.Models;

[Table("Shopping Cart")]
public partial class Shopping_Cart
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? UserID { get; set; }

    [InverseProperty("ShoppingCart")]
    public virtual ICollection<Cart_Item> Cart_Items { get; set; } = new List<Cart_Item>();
}