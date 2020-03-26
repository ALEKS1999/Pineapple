using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
