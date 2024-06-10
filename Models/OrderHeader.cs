#nullable disable
namespace Supply_Chain_Backend.Models;

[Table("OrderHeader")]
public partial class OrderHeader
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? UserID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? PickupPhone { get; set; }

    [StringLength(50)]
    public string PickupEmail { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? OrderTotal { get; set; }

    public DateOnly? OrderDate { get; set; }

    [StringLength(50)]
    public string Status { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? TotalItems { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? StripePaymentIntelID { get; set; }

    [StringLength(50)]
    public string PickupName { get; set; }

    [StringLength(50)]
    public string Adderss { get; set; }

    [InverseProperty("OrederHearder")]
    public virtual ICollection<Order_Item> Order_Items { get; set; } = new List<Order_Item>();
}