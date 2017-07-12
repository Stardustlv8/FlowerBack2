using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlowerBack2.Models
{
    public class Flower
    {
        [Key]
        public int FlowerId { get; set; }

        [Required(ErrorMessage="You must enter a {0}")]
        [StringLength(50, ErrorMessage = "The Field {0} can contain maximum {1} {2} characters", MinimumLength =1)]
        [Index("Flower_Description_Index", IsUnique = true)]
        public string Description { get; set; }

        public decimal Price { get; set; }

    }
}