#nullable disable
namespace Supply_Chain_Backend.Models;

[Table("Order Items")]
public partial class Order_Item
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(50)]
    public string ProductName { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Price { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? ProductID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? OrederHearderID { get; set; }

    [ForeignKey("OrederHearderID")]
    [InverseProperty("Order_Items")]
    public virtual OrderHeader OrederHearder { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("Order_Items")]
    public virtual Product Product { get; set; }
}