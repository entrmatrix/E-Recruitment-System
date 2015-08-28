


/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Employee.cs
Description of the file: Used in Business Object Layer.
 * This source is subject to the to ABC Public License. 
 * http://www.abc.erecruitment.com/  
 * All other rights reserved.  
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  EITHER 
 * EXPRESSED  * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED  WARRANTIES OF
 * MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using E_Recruitment.Types;

namespace E_Recruitment.BO
{
   public class Employee : IEmployee
    {
       private int EmployeeID;
       private string EmployeeName;
       private int UnitHeadID;
       private int ProjectID;
       private bool IsHR;
       private DateTime DOB;
       private DateTime DOJ;
       private string Gender;
       private string Division;
       private float CTC;
       private string Designation;
       private string Password;
       private string Location;
       private int Experience;


       public Employee(int EmployeeID, string EmployeeName, int UnitHeadID, int ProjectID, bool IsHR, DateTime DOB, DateTime DOJ, string Gender, string Division, float CTC, string Designation, string Password, string Location, int Experience)
       {
           this.EmployeeID = EmployeeID;
           this.EmployeeName = EmployeeName;
           this.UnitHeadID = UnitHeadID;
           this.ProjectID = ProjectID;
           this.IsHR = IsHR;
           this.DOB = DOB;
           this.DOJ = DOJ;
           this.Gender = Gender;
           this.Division = Division;
           this.CTC = CTC;
           this.Designation = Designation;
           this.Password = Password;
           this.Location = Location;
           this.Experience = Experience;

       }

       public int get_EmployeeID
       {
           set { EmployeeID = value; }
           get { return EmployeeID; }
       }

       public string get_EmployeeName
       {
           set { EmployeeName = value; }
           get { return EmployeeName; }
       }

       public int get_UnitHeadID
       {
           set { UnitHeadID = value; }
           get { return UnitHeadID; }
       }

       public int get_ProjectID
       {
           set { ProjectID = value; }
           get { return ProjectID; }
       }

       public bool get_IsHR
       {
           set { IsHR = value; }
           get { return IsHR; }
       }

       public DateTime get_DOB
       {
           set { DOB = value; }
           get { return DOB; }
       }

       public DateTime get_DOJ
       {
           set { DOJ = value; }
           get { return DOJ; }
       }

       public string get_Gender
       {
           set { Gender = value; }
           get { return Gender; }
       }

       public string get_Division
       {
           set { Division = value; }
           get { return Division; }
       }
       public float get_CTC
       {
           set { CTC = value; }
           get { return CTC; }
       }
       public string get_Designation
       {
           set { Designation = value; }
           get { return Designation; }
       }
       public string get_Password
       {
           set { Password = value; }
           get { return Password; }
       }
       public string get_Location
       {
           set { Location = value; }
           get { return Location; }
       }
       public int get_Experience
       {
           set { Experience = value; }
           get { return Experience; }
       }


    }
}
