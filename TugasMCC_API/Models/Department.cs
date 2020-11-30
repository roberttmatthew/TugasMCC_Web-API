using System.ComponentModel.DataAnnotations;

namespace TugasMCC_API.Models
{

    public class Department
    {
    
        public Department() { }
        public Department(int id, string name)
        {
            CustId = id;
            Name = name;
        }
        [Key]
        public int CustId { get; set; }
        public string Name { get; set; }


    }

}