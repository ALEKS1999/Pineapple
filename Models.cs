using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pineapple
{
    public class Computer {

        public int LastID = 1;
        public int CompID = 0;
        public string[] setting = new string[21];
        public string[] condition = new string[21];

        public Computer () {
            CompID = LastID;
            LastID++;
        }

        public Computer (int CompID) {
            LastID++;
        }

        public string deattachPeriphery () {
           CompID = -1;
           return "Periphery was deattached";
        }

        public string editComputerInfo(int ID, string newSetting, int settingID) {
           if (settingID < 0 || settingID >= 21) return "Wrong input";
           else
           {
               string oldSetting = setting[settingID];
               setting[settingID] = newSetting;
               return "Setting was changed from " + oldSetting + " to " + newSetting;
           }
       }

    }
    public class Periphery{
        public int LastID = 1;
        public int PerID = 0;
        public string[] setting = new string[21];
        public string[] condition = new string[21];

        public void addPeriphery () {
            PerID = LastID;
            LastID++;
        }

        public string addPeripheryID (int CompID) {
            LastID++;
            return "Periphery";
        }

        public string deattachPeriphery () {
           PerID = -1;
           return "Periphery was deattached";
        }

        public string editComputerInfo(int ID, string newSetting, int settingID) {
           if (settingID < 0 || settingID >= 21) return "Wrong input";
           else
           {
               string oldSetting = setting[settingID];
               setting[settingID] = newSetting;
               return "Setting was changed from " + oldSetting + " to " + newSetting;
           }
       }
    }

/*addComputer() - добавить компьютер, с автоматическим идентификационным номером.
addComputer(Int ID) - добавляет компьютер со следующими данными: идентификационный номер компьютера.
attachToEmployee(int ID, int employeeId ) - прикрепляет компьютер к сотруднику.
editPeriphery(int ID, int PeripheryId, periphery _periphery ) - изменяет данные о периферии, прикрепленной к компьтеру по идентификационному номеру.
editComputer(int ID, int computerSetting, String setting) - изменяет описание характеристики компьютера по ID.  
editCondition(int ID, String condition) - изменяет состояние компьютера.
*/

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
