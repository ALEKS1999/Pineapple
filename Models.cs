using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Test1

namespace Pineapple
{
    public class Computer
    {
        public int LastID = 1;
        public int CompID = 0;
        public string[] setting = new string[4];
        public string[] condition = new string[2];

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

        public string editComp(string newSetting, int settingID)
        {
            if (settingID < 0 || settingID > 5) return "Wrong input";
            else
            {
                string oldSetting = setting[settingID];
                setting[settingID] = newSetting;
            }
        }

        public void worComp()
        {
            condition = "working";
        }

        public void repComp()
        {
            condition = "on repair";
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

        public string motherboard
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

        public string powersupply
        {
            get
            {
                return setting[3];
            }
            set
            {
                setting[3] = powersupply;
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
        }
    }
    public class Periphery
    {
        public int LastID = 1;
        public int PerID = 0;
        public int CompID = -1;
        public string[] setting = new string[3];
        public string condition;

        public void addPeriphery()
        {
            PerID = LastID;
            LastID++;
        }

        public void addPeripheryID(int Id)
        {
            PerID = Id;
            LastID++;
        }

        public void attachPeriphery(int Id)
        {
            CompID = -1;
        }
        public void deattachPeriphery()
        {
            CompID = -1;
        }

        public void worPeriphery()
        {
            condition = "working";
        }

        public void repPeriphery()
        {
            condition = "on repair";
        }

        public void decomPeriphery()
        {
            condition = "decommissioned";
        }

        public string editPeriphery(int PerID, string newSetting, int settingID)
        {
            if (settingID < 0 || settingID >= 4) return "Wrong input";
            else
            {
                string oldSetting = setting[settingID];
                setting[settingID] = newSetting;
                return "Success";
            }
        }

        public string name
        {
            get
            {
                return setting[0];
            }
            set
            {
                setting[0] = name;
            }
        }

        public string manufacturer
        {
            get
            {
                return setting[1];
            }
            set
            {
                setting[1] = manufacturer;
            }
        }

        public string type
        {
            get
            {
                return setting[2];
            }
            set
            {
                setting[2] = type;
            }
        }

        public string info
        {
            get
            {
                return setting[3];
            }
            set
            {
                setting[3] = info;
            }
        }
    }
    public class Department
    {
        string[] info = new string[2];
        //info[0] = ID
        //info[1] = Название
    }
}