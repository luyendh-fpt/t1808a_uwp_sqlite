using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1808A_UWP_SQLite.Entities;
using T1808A_UWP_SQLite.Utils;

namespace T1808A_UWP_SQLite.Models
{
    class StudentModel
    {
        public bool Insert(Student student)
        {
            try
            {
                using (var stt = SQLiteUtil.GetIntances().Connection.Prepare("INSERT INTO Student (Name) VALUES (?)"))
                {
                    stt.Bind(1, student.Name);
                    stt.Step();
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}
