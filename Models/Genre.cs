﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//lmfao look at this dude tryinna get github working
namespace YellowBucket.Models
{
    public class Genre
    {
        [Key]      
        public int GenreId { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        #nullable enable
        [Column(TypeName = "varchar(4096)")]
        public string? Description { get; set; }
        #nullable disable

        public List<Movie> Movies { get; set; }
    }
}
