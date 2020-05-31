using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class StudentRecord
    {
        public int StudentId { get; set; }
        public string StudentName;

        public StudentRecord(int i, string Name)
        {
            StudentId = i;
            StudentName = Name;
        }
        public override string ToString()
        {
            return StudentId + " " + StudentName + " ";
        }

        //public int GetStudentId()
        //{
        //    return StudentId;
        //}

        //public void SetStudentId(int i)
        //{
        //    StudentId = i;
        //}
    }
}
