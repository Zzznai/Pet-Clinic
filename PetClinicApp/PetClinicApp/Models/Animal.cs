using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PetClinicApp.Models;

public class Animal
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Name { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Type { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Age must be greater than 0")]
    public int Age { get; set; }

    [Required]
    public string PassportSerialNumber { get; set; }

    public Passport Passport { get; set; }
    public List<Procedure> Procedures { get; set; }
}