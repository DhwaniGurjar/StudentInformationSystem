using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_DataModelLayer;

namespace SIS_DataAccessLayer
{
    public interface IRepository
    {
      List<tblStudent> ViewAll();
      StudentModel InsertStudent(tblStudent tblobj,tblStudentHistory tblhisobj);

        
        StudentModel UpdateStudent(tblStudent tblobj1, tblStudentHistory tblhisobj);
       
    }
}
