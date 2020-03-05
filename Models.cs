using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pineapple
{
   public class Employee
   {
       int computerID=-1;
       string[] info = new string[5];
       //info[0] = ФИО
       //info[1] = Год рождения
       //info[2] = Должность
       //info[3] = Отдел
       //info[4] = Индивидуальный номер
       string condition="working";
       public Employee(int ID)
       {
           info[4] = Convert.ToString(ID);
       }
       public string attachComputer(int ID)
       {
           computerID=ID;
           return "Computer with ID=" + computerID + " was attached to this employee";
       }
       public string deattachComputer()
       {
           computerID = -1;
           return "Employee was deattached";
       }
       public string editEmployeeInfo(int ID, string newInfo, int infoID)
       {
           if (infoID < 0 || infoID >= 5) return "Wrong input";
           else
           {
               // для каждого свой отдельный 
               // напиши switch()
           }
       }
       public void deleteEmployee()
       {
           condition = "fired";
       }
       public string fullName { get; set; }
       public int yearOfBirth { get; set; }
       public string title { get; set; }
       public string department { get; set; }
       public int employeeID { get; set; }
   }
}
/*
addEmployee() - добавляет сотрудника с автоматическим ID.
addEmployee(int ID) - добавляет сотрудника с определенным ID.
attachComputer(int computerID, int employeeId ) - прикрепляет компьютер к сотруднику.
deattachComputer(int computerID, int employeeId ) -открепляет компьютер от сотрудника.
editEmployeeInfo(int ID, String info[int InfoID]) - изменяет информацию о сотруднике.
deleteEmployee(int ID) - меняет состояние сотрудника на "уволенный".
*/
