#nullable disable
namespace Supply_Chain_Backend.Models;

[Table("Category")]
public partial class Category
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [InverseProperty("CategoryNavigation")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}