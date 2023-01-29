using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Day2TaskCompany.Models
{
    public class Department
    {
        [Key]
        public int Number { get; set; }
        public string? Name { get; set; }
        public virtual List<DepartmentLocation>? DepartmentLocations { get; set; }
        public virtual List<Project>? Projects { get; set; }

        // NP and FK for relation (manege 1 to 1) Employee => Department
        [ForeignKey("employeeManege")]
        public int? mngrSSN { get; set; }
        public virtual Employee? employeeManege { get; set; }

        // NP and FK for relation (manege 1 to 1) Employee => Department
        public virtual List<Employee>? EmployeesWork { get; set; }

    }
}
