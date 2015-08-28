using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
namespace BussinessObject
{
    public class Employee : IEmployee
    {
        int ctc;
        DateTime dateOFBirth;
        DateTime dateOfJoining;
        string designation;
        string division;
        int employeeID;
        string gender;
        bool isHR;
        string name;
        int projectID;
        int unitHeadID;
        string bussinessDomain;

        public Employee(string name, int employeeID, bool isHR, int unitHeadID, string bussinessDomain)
        {
            this.name = name;
            this.employeeID = employeeID;
            this.isHR = isHR;
            this.unitHeadID = unitHeadID;
            this.bussinessDomain = bussinessDomain;
        }

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int UnitHead
        {
            get { return unitHeadID; }
            set { unitHeadID = value; }
        }
        public bool IsHR
        {
            get { return isHR; }
            set { isHR = value; }
        }

        public string BussinessDomain
        {
            get { return bussinessDomain; }
            set { bussinessDomain = value; }
        }
                 
    }


}
