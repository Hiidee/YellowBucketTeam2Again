using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace YellowBucket.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Column(TypeName = "varchar(32)")]
        public string Name { get; set; }

        #nullable enable
        [Column(TypeName = "varchar(256)")]
        public string? Description { get; set; }
        #nullable disable

        public List<Movie> Movies { get; set; }
    }
}
