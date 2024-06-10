#nullable disable
namespace Supply_Chain_Backend.Models;

[Table("Store Product")]
public partial class Store_Product
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? StoreID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? ProductID { get; set; }

    [ForeignKey("ProductID")]
    [InverseProperty("Store_Products")]
    public virtual Product Product { get; set; }

    [ForeignKey("StoreID")]
    [InverseProperty("Store_Products")]
    public virtual Store Store { get; set; }
}