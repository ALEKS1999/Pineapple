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
        public string[] condition = new string[1];
        public Computer () {
            CompID = LastID;
            LastID++;
        }
        public Computer (int CompID) {
            LastID++;
        }

        public attachComputertoEmployee () {
        }
        public deattachPeriphery () {
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
}

/*addComputer() - добавить компьютер, с автоматическим идентификационным номером.
addComputer(Int ID) - добавляет компьютер со следующими данными: идентификационный номер компьютера.
attachPeripheryToComputer(int ID,periphery[] _periphery ) - прикрепляет периферию к компьютеру по ID.
attachToEmployee(int ID, int employeeId ) - прикрепляет компьютер к сотруднику.
editPeriphery(int ID, int PeripheryId, periphery _periphery ) - изменяет данные о периферии, прикрепленной к компьтеру по идентификационному номеру.
editComputer(int ID, int computerSetting, String setting) - изменяет описание характеристики компьютера по ID.  
editCondition(int ID, String condition) - изменяет состояние компьютера.
*/