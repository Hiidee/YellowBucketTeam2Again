using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YellowBucket.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Column(TypeName = "varchar(32)")]
        public string Name { get; set; }

#nullable enable
        [Column(TypeName = "varchar(256)")]
        public string? Description { get; set; }
#nullable disable
        public Movie Movie { get; set; }

        public int MovieId { get; set; }
    }
}
