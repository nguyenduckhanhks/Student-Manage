using System;
using System.Collections.Generic;
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
        }
        private StudentDAO() { }
        public void addStudent(string idClass, string name, DateTime dateOfBirth, string telephone, string email, string male, float math, float physic, float chemical)
        {
            string id = RandomIdProvide.Instance.CreateId();
            Astudent st = new Astudent();
            st.id = id;
            st.idClass = idClass;
            st.dateOfbirth = dateOfBirth;
            st.name = name;
            st.telephone = telephone;
            st.email = email;
            st.male = 1;
            if (male == "Female") st.male = 0;
            st.mathPoint = math;
            st.physicalPoint = physic;
            st.chemicalPoint = chemical;

            Data.DataStudent.Astudents.InsertOnSubmit(st);
            Data.DataStudent.SubmitChanges();
        }

        public void repairStudent(string id,string idclass, string name, DateTime dateOfBirth, string telephone, string email, string male, float math, float physic, float chemical)
        {

            Astudent st = Data.DataStudent.Astudents.Where(p => p.id.Equals(id)).SingleOrDefault();

            st.idClass = idclass;
            st.dateOfbirth = dateOfBirth;
            st.name = name;
            st.telephone = telephone;
            st.email = email;
            st.male = 1;
            if (male == "Female") st.male = 0;
            st.mathPoint = math;
            st.physicalPoint = physic;
            st.chemicalPoint = chemical;

            Data.DataStudent.SubmitChanges();
        }

        public void deleteStudent(string id)
        {

            Astudent st = Data.DataStudent.Astudents.Where(p => p.id.Equals(id)).SingleOrDefault();

            Data.DataStudent.Astudents.DeleteOnSubmit(st);
            Data.DataStudent.SubmitChanges();
        }
    }
}
