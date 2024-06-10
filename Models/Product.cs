#nullable disable
namespace Supply_Chain_Backend.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Category { get; set; }

    [StringLength(50)]
    public string SpecialTag { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Price { get; set; }

    public byte[] Image { get; set; }

    [StringLength(50)]
    public string Description { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Cart_Item> Cart_Items { get; set; } = new List<Cart_Item>();

    [ForeignKey("Category")]
    [InverseProperty("Products")]
    public virtual Category CategoryNavigation { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Order_Item> Order_Items { get; set; } = new List<Order_Item>();

    [InverseProperty("Product")]
    public virtual ICollection<Store_Product> Store_Products { get; set; } = new List<Store_Product>();
}