using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket.Models
{
    public class Rentals
    {
        [Key]
        public int RentalsId { get; set; }

        [Display(Name = "Inventory")]
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int Rental_KioskId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Rental_Date { get; set; }

        public int Return_KioskId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Return_Date { get; set; }


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
