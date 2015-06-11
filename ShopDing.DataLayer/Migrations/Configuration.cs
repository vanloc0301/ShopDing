using ShopDing.Model;

namespace ShopDing.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopDing.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ShopDing.DataLayer.SalesContext context)
        {
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder { CustomerName =  "Văn Lộc", PONumber = "9302" },
                new SalesOrder { CustomerName = "Tùng Dinh"},
                new SalesOrder { CustomerName = "Bích Trâm", PONumber = "Sector 9"},
                new SalesOrder { CustomerName = "Hà Lan", PONumber = "Tips 45"}
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
