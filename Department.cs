using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pineapple
{
    public class Department
    {
        int EmployeeID = -1;
        string[] info = new string[1];
        //info[0] = Отдел
        //info[1] = Индивидуальный номер

        public void addDepartment()
        {
            info[1] = Convert.ToString(ID);
        }
      
        public int addDepartment(int ID)
        {
            if (infoID = 1)
            {
                info[infoID] = newInfo;
            }
        }
        public void attachEmptoDepartment(int ID, Emp[] _Department)
        {
            EmployeeID = ID;
        }
        public void editDepartment(int ID)
        {
            if (infoID >= 0 || infoID <= 1)
            {
                info[infoID] = newInfo;
            }
        }
        public void deleteDepartment(int ID)
        {
            condition = "fired";
        }
        public string DepartmentName
        {
            get
            {
                return info[0];
            }
            set
            {
                info[0] = DepartmentName;
            }
        }
        public int DepartmentID
        {
            get
            {
                return Convert.ToInt32(info[1]);
            }
            set
            {
                info[1] = Convert.ToString(DepartmentID);
            }
        }



    }
    /* addDepartment() - добавляет новый отдел с автоматическим ID.
     addDepartment(int ID) - добавляет новый отдел с введенным ID.
     attachEmptoDepartment(int ID.Emp[]_Department) - прикрепляет сотрудника к отделу по ID.
     editDepartment(int ID) - изменяет данные выбранного по ID отдела.
     deleteDepartment(int ID) - изменяет состояние на “удаленный”.*/
}
