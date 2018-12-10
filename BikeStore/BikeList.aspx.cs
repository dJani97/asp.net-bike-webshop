using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using BikeStore.Models;

namespace BikeStore
{
    public partial class BikeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        public IQueryable<Bicycle> GetBikes([QueryString("id")] int? categoryID) {
            var db = new BicycleContext();
            IQueryable<Bicycle> query = db.Bicycles;
            if(categoryID != null && categoryID.HasValue) {
                query = from line in query
                        where line.CategoryID == categoryID
                        select line;
            }
            return query;
        }
    }
}