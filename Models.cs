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
        public int FIO { get; set; }
        public string PositionID { get; set; }
        [ForeignKey("PositionID")]
        public Position Position { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        
    }
    public class Computer
    {
        [Key]

        public int Id { get; set; }
        public string Condition { get; set; }

        public string Setting { get; set; }
        [ForeignKey("Setting")]
        public CompSetting Setting { get; set; }

        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Id { get; set; }

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

        public string Setting { get; set; }
        [ForeignKey("Setting")]
        public PerSetting Setting { get; set; }

        public int CompID { get; set; }
        [ForeignKey("CompID")]
        public Computer Id { get; set; }
    }

    public class PerSetting
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Periphery> PeripherySetting { get; set; }
    }

    public class Department
    {
        string[] info = new string[2];
        //info[0] = ID
        //info[1] = Название
    }
}