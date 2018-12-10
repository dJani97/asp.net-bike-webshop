using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BikeStore.Models;

namespace BikeStore {
    public partial class VoteForBike : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            string requestedID = Request.QueryString["id"];

            if (!String.IsNullOrEmpty(requestedID) && int.TryParse(requestedID, out int bikeID)) {
                var db = new BicycleContext();
                Bicycle bicycle = (from bike in db.Bicycles
                                   where bike.BicycleID == bikeID
                                   select bike).FirstOrDefault();
                bicycle.Votes++;
                db.SaveChanges();
            }
            else {
                Response.Redirect("404.aspx");
            }

            Uri previousUri = Request.UrlReferrer;
            if (previousUri != null)
                Response.Redirect(previousUri.ToString());
            else {
                Response.Redirect("BikeList.aspx");
            }

        }
    }
}