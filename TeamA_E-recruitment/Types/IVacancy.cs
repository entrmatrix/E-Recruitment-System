using System;
namespace Types
{
    public interface IVacancy
    {
        int NoOfPositions { get; set; }
        DateTime RequiredDate { get; set; }
        string Skills { get; set; }
        int Status { get; set; }
        int VacancyID { get; set; }
        int Experience { get; set; }
        string Location { get; set; }
        string Domain { get; set; }
    }
}
