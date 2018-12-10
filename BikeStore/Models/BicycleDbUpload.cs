using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace BikeStore.Models
{
    public class BicycleDbUpload : DropCreateDatabaseIfModelChanges<BicycleContext>
    {
        protected override void Seed(BicycleContext context)
        {
            foreach(Category item in ReadCategories())
            {
                context.Categories.Add(item);
            }

            foreach (Bicycle item in ReadBicycles())
            {
                context.Bicycles.Add(item);
            }
        }

        private static List<Bicycle> ReadBicycles()
        {
            StreamReader reader = File.OpenText(HttpContext.Current.Server.MapPath("~/App_Data/bicikli.txt"));
            var bikes = new List<Bicycle>();
            Bicycle bike;
            string[] line;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine().Split(';');
                bike = new Bicycle()
                {
                    BicycleID = int.Parse(line[0]),
                    ModelName = line[1],
                    Manufacturer = line[2],
                    Type = line[3],
                    Price = int.Parse(line[4]),
                    ImageFile = line[5],
                    CategoryID = int.Parse(line[6])
                };
                bikes.Add(bike);
            }
            reader.Close();
            return bikes;
        }

        private static List<Category> ReadCategories()
        {
            StreamReader reader = File.OpenText(HttpContext.Current.Server.MapPath("~/App_Data/katadat.txt"));
            var categories = new List<Category>();
            Category category;
            string[] line;

            while(!reader.EndOfStream)
            {
                line = reader.ReadLine().Split(';');
                category = new Category()
                {
                    CategoryID = int.Parse(line[0]),
                    CatName = line[1]
                };
                categories.Add(category);
            }
            reader.Close();
            return categories;
        }
    }
}