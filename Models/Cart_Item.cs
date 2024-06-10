#nullable disable
namespace Supply_Chain_Backend.Models;

[Table("Cart Items")]
public partial class Cart_Item
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? ProductID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? ShoppingCartID { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("Cart_Items")]
    public virtual Product Product { get; set; }

    [ForeignKey("ShoppingCartID")]
    [InverseProperty("Cart_Items")]
    public virtual Shopping_Cart ShoppingCart { get; set; }
}