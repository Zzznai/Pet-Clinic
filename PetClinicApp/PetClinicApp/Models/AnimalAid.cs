using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PetClinicApp.Models;

namespace PetClinicApp.Models
{
    public class AnimalAid
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        public List<ProcedureAnimalAid> AnimalAidProcedures { get; set;}
    }
}
