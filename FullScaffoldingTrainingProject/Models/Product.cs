using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullScaffoldingTrainingProject.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "The product must have Title")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Please enter the Quantity")]
    public decimal Quantity { get; set; }

    [Required(ErrorMessage = "Please enter the UnitPrice")]
    public decimal UnitPrice { get; set; }

    public decimal Price { get { return UnitPrice * Quantity; } }
}
