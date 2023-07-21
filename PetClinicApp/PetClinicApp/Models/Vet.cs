using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PetClinicApp.Models;

namespace PetClinicApp.Models
{
    public class Vet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Profession { get; set; }

        [Required]
        [Range(22, 65)]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"^(\+359|0)[0-9]{9}$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        public List<Procedure> Procedures { get; set; }
    }

}
