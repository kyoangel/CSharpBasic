using CSharpBasicTests.Enums;

namespace CSharpBasicTests.Models
{
    public class Employee
    {
        public double WorkingYear { get; set; }
        public int Age { get; set; }
        public int MonthSalary { get; set; }
        public RoleType Role { get; set; }
        public string Name { get; set; }
    }
}