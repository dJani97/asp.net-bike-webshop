using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required, StringLength(30)]
        public string CatName { get; set; }

        public virtual ICollection<Bicycle> Bikes { get; set; }
    }
}