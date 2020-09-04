using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_DataAccessLayer;
using SIS_DataModelLayer;

namespace SIS_BusinessLogicLayer
{
    public static class Services
    {

      static IRepository irepository;

       static Services()
        {

            irepository = new StudentRepository();

        }

        public static List<tblStudent> ViewStudent()
        {

            return irepository.ViewAll().ToList();

        }

        public static StudentModel InsertStudent(StudentModel studentobj)
        {
            tblStudent tblobj = new tblStudent();
            tblStudentHistory tblhistoryobj = new tblStudentHistory();
            tblobj.Address = studentobj.Address;
            tblobj.City = studentobj.City;
            tblobj.ContactNo = studentobj.ContactNo;
            tblobj.EmailID = studentobj.EmailID;
            tblobj.EnrollNo = studentobj.EnrollNo;
            tblobj.FirstName = studentobj.FirstName;
            tblobj.Gender = studentobj.Gender;
            tblobj.LastName = studentobj.LastName;
            tblobj.State = studentobj.State;
            tblobj.DOB = studentobj.DOB;
            tblobj.DegreeYear = studentobj.DegreeYear;
            
            
            tblhistoryobj.CollegeCode = studentobj.CollegeCode;
            tblhistoryobj.DepartmentCode = studentobj.DepartmentCode;
            tblhistoryobj.LogDate = studentobj.LogDate;
            tblhistoryobj.Semester = studentobj.Semester;
           
           


            return irepository.InsertStudent(tblobj,tblhistoryobj);

        }

        public static StudentModel UpdateStudent(StudentModel studentobj)
        {
            tblStudent tblobj = new tblStudent();
            tblStudentHistory tblhistoryobj = new tblStudentHistory();
            tblobj.Address = studentobj.Address;
            tblobj.City = studentobj.City;
            tblobj.ContactNo = studentobj.ContactNo;
            tblobj.EmailID = studentobj.EmailID;
            tblobj.EnrollNo = studentobj.EnrollNo;
            tblobj.FirstName = studentobj.FirstName;
            tblobj.Gender = studentobj.Gender;
            tblobj.LastName = studentobj.LastName;
            tblobj.State = studentobj.State;
            tblobj.DOB = studentobj.DOB;
            tblobj.DegreeYear = studentobj.DegreeYear;


            tblhistoryobj.CollegeCode = studentobj.CollegeCode;
            tblhistoryobj.DepartmentCode = studentobj.DepartmentCode;
            tblhistoryobj.LogDate = studentobj.LogDate;
            tblhistoryobj.Semester = studentobj.Semester;

            return irepository.UpdateStudent(tblobj, tblhistoryobj);
        }


    }
}
