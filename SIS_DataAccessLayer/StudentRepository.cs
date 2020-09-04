using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_DataModelLayer;
using SIS_DataAccessLayer;
using SIS_DataAccessLayer;


namespace SIS_DataAccessLayer
{
   public class StudentRepository : IRepository
    {



       public List<SIS_DataAccessLayer.tblStudent> ViewAll()
       {

           using (StudentInformationSystemEntities db = new StudentInformationSystemEntities())
           {
               return db.tblStudent.ToList();
           }


       }

       public StudentModel  InsertStudent(tblStudent tblstudobj , tblStudentHistory tblhisobj)
       {

           using (StudentInformationSystemEntities db = new StudentInformationSystemEntities())
           {
               tblstudobj.ID = Guid.NewGuid();
               tblhisobj.ID = Guid.NewGuid();

               db.tblStudent.Add(tblstudobj);
              int j =  db.SaveChanges();
              
              var studid = (from t in db.tblStudent orderby t.ID
                             select t ).ToList().Last();
              
             

               tblhisobj.StudentID = studid.ID;

               db.tblStudentHistory.Add(tblhisobj);
               int i =  db.SaveChanges();
               if (i == 1&&j==0)

                   return new StudentModel();
               else return null; ;
           }

       }
        public bool UpdateStudent(tblStudent tblstudentobj, tblStudentHistory tblhisobj)
        {
            bool result = false;
            using (StudentInformationSystemEntities db = new StudentInformationSystemEntities())

            {

                StudentModel _student = db.tblStudent.Where(x => x.ID == tblstudentobj.ID).Select(x => x).FirstOrDefault();
                db.tblStudent.Attach(_student);
                db.SaveChanges();
                result = true;
                            }
            return result;
        }

        public bool DeleteStudent(tblStudent tblstudobj, tblStudentHistory tblstudhisobj
            {

            bool result = false;
            using (StudentInformationSystemEntities db = new StudentInformationSystemEntities())
            {
                StudentModel student = db.tblStudent.Where(x => x.ID == tblstudobj.ID).Select(x => x).FirstOrDefault();
                db.tblStudent.DeleteObject(student);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

    }
}
