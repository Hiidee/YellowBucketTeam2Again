using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YellowBucket.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        [Display(Name = "Kiosk")]
        public int KioskId { get; set; }
        public Kiosk Kiosk { get; set; }

        [Display(Name = "Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int Dvd { get; set; }

        public int BluRay { get; set; }

        public int IsRented { get; set; }

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
