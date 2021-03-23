using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        [Column(TypeName = "varchar(128)")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Column(TypeName = "varchar(128)")]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        [Column(TypeName = "varchar(128)")]
        public string Email { get; set; }

        
        [Column(TypeName = "varchar(128)")]
        public string Password { get; set; }

        [Display(Name = "Address")]
        [Column(TypeName = "varchar(128)")]
        public string Address { get; set; }

        [Display(Name = "Address Line Two")]
        [Column(TypeName = "varchar(128)")]
        public string Address2 { get; set; }


        
        [Column(TypeName = "varchar(128)")]
        public string City { get; set; }

        
        [Column(TypeName = "varchar(2)")]
        public string State { get; set; }

        
        [Column(TypeName = "varchar(128)")]
        public string Zip { get; set; }



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
