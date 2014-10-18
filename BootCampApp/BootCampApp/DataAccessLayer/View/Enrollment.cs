using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampApp.DataAccessLayer.View
{
    class Enrollment
    {
        public int Id { set; get; }
        public string StudentName { set; get; }
        public string Email { get; set; }
        public string CourseTitle  { set; get; }
        
    }
}
