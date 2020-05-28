using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Test1

namespace Pineapple
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PositionID { get; set; }
        [ForeignKey("PositionID")]
        public Position Position { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        
    }
    public class Department 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
    public class Computer
    {
        [Key]

        public int Id { get; set; }
        public string Condition { get; set; }

        public string SettingId { get; set; }
        [ForeignKey("SettingId")]
        public CompSetting Setting { get; set; }

        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee employee { get; set; }

    }

    public class CompSetting {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Computer> ComputerSetting { get; set; }
    }

    public class Periphery
    {
        [Key]

        public int Id { get; set; }
        public string Condition { get; set; }

        public string SettingID { get; set; }
        [ForeignKey("SettingID")]
        public PerSetting Setting { get; set; }

        public int CompID { get; set; }
        [ForeignKey("CompID")]
        public Computer computer { get; set; }
    }

    public class PerSetting
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Periphery> PeripherySetting { get; set; }
    }
}