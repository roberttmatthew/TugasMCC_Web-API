using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TugasMCC_API.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        [ForeignKey("department")]
        public int DepartmentId { get; set; }
        public Department department { get; set; }


    }
}