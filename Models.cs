using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pineapple
<<<<<<< HEAD
{
    public class Computer
    {

        public int LastID = 1;
        public int CompID = 0;
        public string[] setting = new string[5];
        public string[] condition = new string[3];
        
        /*
        public void addComputer()
        {
            CompID = LastID;
            LastID++;
        }

        public void addComputerID(int CompID)
        {
            LastID++;
        }

        public void deattachPeriphery()
        {
            PerID = -1;
        }

        public string editComp(int ID, string newSetting, int settingID)
        {
            if (settingID < 0 || settingID >= 5) return "Wrong input";
            else
            {
                string oldSetting = setting[settingID];
                setting[settingID] = newSetting;
                return "Setting was changed from " + oldSetting + " to " + newSetting;
            }
        }

        public void decomComp()
        {
            condition = "decommissioned";
        }

        public string cpu
        {
            get
            {
                return setting[0];
            }
            set
            {
                setting[0] = cpu;
            }
        }
        public int ram
        {
            get
            {
                return Convert.ToInt32(setting[1]);
            }
            set
            {
                setting[1] = Convert.ToString(ram);
            }
        }
        public string mb
        {
            get
            {
                return setting[2];
            }
            set
            {
                setting[2] = mb;
            }
        }
        public string ps
        {
            get
            {
                return setting[3];
            }
            set
            {
                setting[3] = ps;
            }
        }
        public int hdd
        {
            get
            {
                return Convert.ToInt32(setting[4]);
            }
            set
            {
                setting[4] = Convert.ToString(hdd);
            }
        }*/
    }
    public class Periphery
    {
        public int LastID = 1;
        public int PerID = 0;
        public string[] setting = new string[3];
        public string[] condition = new string[3];

        /*public void addPeriphery()
        {
            PerID = LastID;
            LastID++;
        }

        public void addPeripheryID(int CompID)
        {
            LastID++;
        }

        public string deattachPeriphery()
        {
            CompID = -1;
        }
        public string editComp(int ID, string newSetting, int settingID)
        {
            if (settingID < 0 || settingID >= 5) return "Wrong input";
            else
            {
                string oldSetting = setting[settingID];
                setting[settingID] = newSetting;
                return "Setting was changed from " + oldSetting + " to " + newSetting;
            }
        }

        public void decomComp()
        {
            condition = "decommissioned";
        }*/

    }
    public class Employee
    {
        int computerID = -1;
        string[] info = new string[5];
        //info[0] = ФИО
        //info[1] = Год рождения
        //info[2] = Должность
        //info[3] = Отдел
        //info[4] = Индивидуальный номер
        string condition = "working";
        /*public Employee(int ID)
        {
            info[4] = Convert.ToString(ID);
        }
        public void attachComputer(int ID)
        {
            computerID = ID;
        }
        public void deattachComputer()
        {
            computerID = -1;
        }
        public void editEmployeeInfo(int ID, string newInfo, int infoID)
        {
            if (infoID >= 1 || infoID <= 5)
            {
                info[infoID] = newInfo;
            }
        }
        public void deleteEmployee()
        {
            condition = "fired";
        }
        public string fullName
        {
            get
            {
                return info[0];
            }
            set
            {
                info[0] = fullName;
            }
        }
        public int yearOfBirth
        {
            get
            {
                return Convert.ToInt32(info[1]);
            }
            set
            {
                info[1] = Convert.ToString(yearOfBirth);
            }
        }
        public string title
        {
            get
            {
                return info[2];
            }
            set
            {
                info[2] = title;
            }
        }
        public string department
        {
            get
            {
                return info[3];
            }
            set
            {
                info[3] = department;
            }
        }
        public int employeeID
        {
            get
            {
                return Convert.ToInt32(info[4]);
            }
            set
            {
                info[4] = Convert.ToString(employeeID);
            }
        }*/
    }
}
=======
{
    public class Computer
    {

        public int LastID = 1;
        public int CompID = 0;
        public string[] setting = new string[21];
        public string[] condition = new string[21];

        public Computer()
        {
            CompID = LastID;
            LastID++;
        }

        public Computer(int CompID)
        {
            LastID++;
        }

        public string deattachPeriphery()
        {
            CompID = -1;
            return "Periphery was deattached";
        }
        public Computer()
        {
            CompID = LastID;
            LastID++;
        }
    }
        public class Periphery
        {
            public int LastID = 1;
            public int PerID = 0;
            public string[] setting = new string[21];
            public string[] condition = new string[21];

            public void addPeriphery()
            {
                PerID = LastID;
                LastID++;
            }

            public string addPeripheryID(int CompID)
            {
                LastID++;
                return "Periphery";
            }

            public string deattachPeriphery()
            {
                PerID = -1;
                return "Periphery was deattached";
            }

            public string editComputerInfo(int ID, string newSetting, int settingID)
            {
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
            int computerID = -1;
            string[] info = new string[5];
            //info[0] = ФИО
            //info[1] = Год рождения
            //info[2] = Должность
            //info[3] = Отдел
            //info[4] = Индивидуальный номер
            string condition = "working";
            public Employee(int ID)
            {
                info[4] = Convert.ToString(ID);
            }
            public void attachComputer(int ID)
            {
                computerID = ID;
            }
            public void deattachComputer()
            {
                computerID = -1;
            }
            public void editEmployeeInfo(int ID, string newInfo, int infoID)
            {
                if (infoID >= 1 || infoID <= 5)
                {
                    info[infoID] = newInfo;
                }
            }
            public void deleteEmployee()
            {
                condition = "fired";
            }
            public string fullName
            {
                get
                {
                    return info[0];
                }
                set
                {
                    info[0] = fullName;
                }
            }
            public int yearOfBirth
            {
                get
                {
                    return Convert.ToInt32(info[1]);
                }
                set
                {
                    info[1] = Convert.ToString(yearOfBirth);
                }
            }
            public string title
            {
                get
                {
                    return info[2];
                }
                set
                {
                    info[2] = title;
                }
            }
            public string department
            {
                get
                {
                    return info[3];
                }
                set
                {
                    info[3] = department;
                }
            }
            public int employeeID
            {
                get
                {
                    return Convert.ToInt32(info[4]);
                }
                set
                {
                    info[4] = Convert.ToString(employeeID);
                }
            }
        }
    
}

/*
addEmployee() - добавляет сотрудника с автоматическим ID.
addEmployee(int ID) - добавляет сотрудника с определенным ID.
attachComputer(int computerID, int employeeId ) - прикрепляет компьютер к сотруднику.
deattachComputer(int computerID, int employeeId ) -открепляет компьютер от сотрудника.
editEmployeeInfo(int ID, String info[int InfoID]) - изменяет информацию о сотруднике.
deleteEmployee(int ID) - меняет состояние сотрудника на "уволенный".
<<<<<<< HEAD
*/
>>>>>>> 91f4b8521be931c28fcfe262e371c1175cfb5914
