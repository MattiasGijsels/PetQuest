using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PetQuest.Contracts.Shared;
using PetQuest.Contracts.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetQuest.Contracts.Models
{
    public class Pet : ModelBase
    {
        [Required]
        [StringLength(100)]
        public string PetName { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public  Species Name { get; set; } = new Species();

        [Required]
        [StringLength(50)]
        public string Breed { get; set; } = default!;

        public int Age { get; set; }
        
        


        public Pet() : base() { }



    }
}
