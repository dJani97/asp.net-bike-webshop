using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BikeStore.Models;
using System.Web.ModelBinding;

namespace BikeStore {
    public partial class BikeDetails : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        public IQueryable<Bicycle> GetOneBike([QueryString("BicycleID")] int? bicycleID) {
            var db = new BicycleContext();
            if(bicycleID == null || !bicycleID.HasValue) {
                bicycleID = 1;
            }
            IQueryable<Bicycle> query = from line in db.Bicycles
                                        where line.BicycleID == bicycleID
                                        select line;
            return query;
        }
    }
}