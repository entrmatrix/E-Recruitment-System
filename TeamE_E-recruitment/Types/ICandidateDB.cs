using System;
using System.Collections.Generic;

namespace E_Recruitment.Types
{
    public  interface ICandidateDB
    {
        int delete(int CandidateID);
        List<ICandidateProfile> getCandidates();
        int save(ICandidateProfile cand);
        int updateCandidates(ICandidateProfile cand);
        List<int> Vacancies();
    }
}
