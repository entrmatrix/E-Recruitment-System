

/******************************  Header ******************************\
Project Name: E-Recruitment.
File name: Candidate_TestManager.cs
Description of the file: Used as Business Logic Layer.
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
using E_Recruitment.DALFactory;


namespace E_Recruitment.BLL
{
    public class Candidate_TestManager : ICandidate_TestManager
    {
        //Return Candidate profile along with their test status
        public List<ICandidate_Test> display_candidate_toHR()
        {
            try
            {
                ICandidate_TestDB objCandidate = Candidate_TestDBFactory.Create_Candidate_TestDB();
                return objCandidate.getCandidates_Test();
            }
            catch (Exception )
            {              
                return null;
            }
        }

    }
}
