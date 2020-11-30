using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TugasMCC_API.Models
{
    public class PeopleContext : DbContext
    {


        public PeopleContext() : base("PeopleContext") { }
        
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }
    }

        //public System.Data.Entity.DbSet<TugasMCC_API.Models.Employee> Employees { get; set; }
   
}
