using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket.Models
{

    public class Customer_Review
    {
        [Key]
        public int Customer_ReviewId { get; set; }

        //many to many reltionship. Worry about this last

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Display(Name = "Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column(TypeName = "varchar(4096)")]
        public string Review { get; set; }

        public int Kernals { get; set; }

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

