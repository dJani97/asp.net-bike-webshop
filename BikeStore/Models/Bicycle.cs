using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public class Bicycle
    {
        public int BicycleID { get; set; }

        [Required, StringLength(60)]
        public string ModelName { get; set; }

        [StringLength(60)]
        public string Manufacturer { get; set; }

        [StringLength(60)]
        public string Type { get; set; }

        public int Price { get; set; }
        public string ImageFile { get; set; }
        public Nullable<int> CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public int Votes { get; set; }
    }
}