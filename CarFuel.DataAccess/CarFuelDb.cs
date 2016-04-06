using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFuel.Models;
using System.Data.Entity;

namespace CarFuel.DataAccess
{
    public class CarFuelDb : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }

}
