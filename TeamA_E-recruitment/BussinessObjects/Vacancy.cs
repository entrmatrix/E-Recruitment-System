using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;
namespace BussinessObject
{
    public class Vacancy : IVacancy
    {
        int vacancyID;
        int noOfPositions;
        DateTime requiredDate;
        string skills;
        string domain;
        int experience;
        string location;
        int isApproved;
        int status;
        int vacancyRequestID;
        int recruitmentRequestID;

        public Vacancy(int vacancyID, int noOfPositions, string skills, string domain, int experience, DateTime requiredDate,string location, int status)
        {
            this.vacancyID = vacancyID;
            this.noOfPositions = noOfPositions;
            this.skills = skills;
            this.domain = domain;
            this.experience = experience;
            this.requiredDate = requiredDate;
            this.location = location;
            this.status=status;
        }

        public int RecruitmentRequestID
        {
            get { return recruitmentRequestID; }
            set { recruitmentRequestID = value; }
        }

        public int VacancyRequestID
        {
            get { return vacancyRequestID; }
            set { vacancyRequestID = value; }
        }

        public int IsApproved
        {
            get { return isApproved; }
            set { isApproved = value; }
        }

        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        public int VacancyID
        {
            get { return vacancyID; }
            set { vacancyID = value; }
        }
        public int NoOfPositions
        {
            get { return noOfPositions; }
            set { noOfPositions = value; }
        }
        public DateTime RequiredDate
        {
            get { return requiredDate; }
            set { requiredDate = value; }
        }
        public string Skills
        {
            get { return skills; }
            set { skills = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
