using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarFinder.Entities
{
    public class Car
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public bool IsNew { get; set; }

        [Required, StringLength(20)]
        public string Make { get; set; }

        [Required, StringLength(200)]
        public string Model { get; set; }

        [Required]
        public double Price { get; set; }

    }
}
