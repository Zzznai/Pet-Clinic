using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PetClinicApp.Models;

namespace PetClinicApp.Models
{
    public class Procedure
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        [Required]
        public int VetId { get; set; }
        public Vet Vet { get; set; }

        public List<ProcedureAnimalAid> ProcedureAnimalAids { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateTime { get; set; }
    }
}
