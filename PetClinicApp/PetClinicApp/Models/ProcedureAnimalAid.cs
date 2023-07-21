using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PetClinicApp.Models;

namespace PetClinicApp.Models
{
    public class ProcedureAnimalAid
    {
        [Required]
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
        public int AnimalAidId { get; set; }
        public AnimalAid AnimalAid { get; set; }
    }
}
