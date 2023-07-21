using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PetClinicApp.Models;

public class Passport
{
    [Key]
    [RegularExpression(@"^[a-zA-Z]{7}[0-9]{3}$", ErrorMessage = "Serial number must have 7 letters and 3 digits")]
    public string SerialNumber { get; set; }

    [Required]
    public Animal Animal { get; set; }

    [Required]
    [RegularExpression(@"^(\+359|0)[0-9]{9}$", ErrorMessage = "Invalid phone number")]
    public string OwnerPhoneNumber { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(30)]
    public string OwnerName { get; set; }

    [Required]
    public DateTime RegistrationDate { get; set; }
}
