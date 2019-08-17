using SutdentManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage.DAO
{
    class StudentDAO
    {
        private static StudentDAO instance;

        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return StudentDAO.instance; }
            private set { StudentDAO.instance = value; }
        }

        private StudentDAO() { }

        public DataTable getStudents()
        {
            return GetDataProvide.Instance.ExcuteDataPro();
        }

        public DataTable findStudent(string studentName)
        {
            return GetDataProvide.Instance.ExcuteDataPro(studentName);
        }

        public void repairStudent(string id, string newClass)
        {
            GetDataProvide.Instance.updateStudent(id, newClass);
        }

        public void deleteStudent(string id, string classOfStudent)
        {
            GetDataProvide.Instance.deleteStudent(id, classOfStudent);
        }

        public void insertStudent(Student student)
        {
            GetDataProvide.Instance.insertStudent(student);
        }
    }
}
