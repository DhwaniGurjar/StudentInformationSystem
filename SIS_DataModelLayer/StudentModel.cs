using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_DataModelLayer
{
   public class StudentModel 
    {


       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string EnrollNo { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string EmailID { get; set; }
        public System.DateTime DOB { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int DegreeYear { get; set; }

      
        public Nullable<System.Guid> StudentID { get; set; }
        public Nullable<int> CollegeCode { get; set; }
        public Nullable<int> DepartmentCode { get; set; }
        public Nullable<int> Semester { get; set; }
        public System.DateTime LogDate { get; set; }
    

   

    }
}
