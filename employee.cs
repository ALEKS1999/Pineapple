using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pineapple
{
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
