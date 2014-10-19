using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCampApp.DataAccessLayer.DataAccessObject;
using BootCampApp.DataAccessLayer.GateWay;
using BootCampApp.DataAccessLayer.View;

namespace BootCampApp.BusinessLogicLayer
{
    class ResultBll
    {
        ResultGateWay aResultGateWay;

        public ResultBll()
        {
            aResultGateWay = new ResultGateWay();
        }


        public string Save(Result aResult)
        {

            if (aResult.RegNo == string.Empty)
            {
                return "please fill up all field";
            }
            else
            {
                if (HasThisScoringValid(aResult))
                {
                    aResultGateWay.Save(aResult);
                    return "Scoring Successfull";
                    
                }
                else
                {
                    return "Course Not Yet Enrolled";
                }
            }

        }
        private bool HasThisScoringValid(Result aResult)
        {

            aResultGateWay = new ResultGateWay();

            List<StudentCourseView> studentList = aResultGateWay.GetAllStudent();

            foreach (StudentCourseView result in studentList)
            {
                if ((aResult.RegNo == result.RegNo) && (aResult.CourseId == result.CourseId))
                {
                    return true;
                }
            }
            return false;

        }

        public List<CourseResultView> GetAllResult()
        {
            return aResultGateWay.GetAllResult();
        }
    }
}
