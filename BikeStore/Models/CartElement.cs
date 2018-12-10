using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models {
    public class CartElement {

        [Key]
        public string CartElementID { get; set; }
        public string CartID { get; set; }
        public int Ammount { get; set; }
        public System.DateTime Creation { get; set; }
        public int BicycleID { get; set; }
        public virtual Bicycle Bicycle { get; set; }
    }
}