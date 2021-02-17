using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Title { get; set; }

        [Display(Name = "Rating")]
        public int RatingId { get; set; }
        public Rating Rating { get; set; }

        [Column(TypeName = "varchar(4096)")]
        public string Description { get; set; }

        [Display(Name = "Running Time (minutes)")]
        public int Length { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Review")]
        public Review Review { get; set; }

        [Display(Name = "On DVD")]
        public bool Is_Dvd { get; set; }

        [Display(Name = "On BluRay")]
        public bool Is_BluRay { get; set; }

        [Display(Name = "Cover Photo")]
        [Column(TypeName = "varchar(128)")]
        public string Cover_Photo { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Release_Date { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created_Date
        {
            get { return _Created_Date; }
            set { _Created_Date = DateTime.Now; }
        }

        private DateTime _Created_Date;

        [DataType(DataType.Date)]
        public DateTime? Updated_Date { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Deleted_Date { get; set; }
    }
}
