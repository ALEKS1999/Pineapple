using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pineapple
{
    public class Periphery
    {
        public int LastID = 1;
        public int PerID = 0;
        public string[] setting = new string[3];
        public string[] condition = new string[2];

        public void addPeriphery()
        {
            PerID = LastID;
            LastID++;
        }

        public void addPeripheryID(int PerID)
        {
            LastID++;
        }

        public string deattachPeriphery(int PerID)
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

        public int manufacturer
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
}
