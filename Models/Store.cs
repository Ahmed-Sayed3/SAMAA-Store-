#nullable disable
namespace Supply_Chain_Backend.Models;

public partial class Store
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Address { get; set; }

    [Column(TypeName = "decimal(9,6)")]
    public decimal? Long { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? Lat { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CarNumbers { get; set; }

    [InverseProperty("Store")]
    public virtual ICollection<Store_Product> Store_Products { get; set; } = new List<Store_Product>();
}