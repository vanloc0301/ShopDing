using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDing.Model;

namespace ShopDing.DataLayer
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("DefaultConection")
        {
            
        }

        public DbSet<SalesOrder> SalesOrders { get; set; } 
    }
}
