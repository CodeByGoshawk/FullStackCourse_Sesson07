using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullScaffoldingTrainingProject.Models;

public class Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Person must have a FirstName")]
    public string firstName { get; set; }

    [Required(ErrorMessage = "Person must have a LastName")]
    public string lastName { get; set; }

    [Required(ErrorMessage = "Person must have a NationalCode")]
    public string nationalCode { get; set; }

    public string fullName { get { return $"{firstName} {lastName}"; } }
}
