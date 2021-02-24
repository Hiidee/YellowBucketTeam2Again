using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace YellowBucket.Models
{
    public class Kiosk
    {
        [Key]
        public int KioskId { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Location { get; set; }

        [Display(Name = "Address Line One")]
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
