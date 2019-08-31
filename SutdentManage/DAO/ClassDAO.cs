using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage.DAO
{
    class ClassDAO
    {
        private static ClassDAO instance;
        public static ClassDAO Instance
        {
            get { if (instance == null) instance = new ClassDAO(); return ClassDAO.instance; }
        }
        private ClassDAO() { }

        public void addClass(string name, int numberOfStudent)
        {
            Aclass insert = new Aclass();

            insert.id = RandomIdProvide.Instance.CreateId(); ;
            insert.name = name;
            insert.numberOfStudents = numberOfStudent;

            Data.DataStudent.Aclasses.InsertOnSubmit(insert);
            Data.DataStudent.SubmitChanges();
        }
        public void repairClass(string id, string name, int numberOfStudent)
        {
            Aclass repair = Data.DataStudent.Aclasses.Where(p => p.id.Equals(id)).SingleOrDefault();

            repair.id = id;
            repair.name = name;
            repair.numberOfStudents = numberOfStudent;

            Data.DataStudent.SubmitChanges();
        }
        public void deleteClass(string id)
        {
            Aclass delete = Data.DataStudent.Aclasses.Where(p => p.id.Equals(id)).SingleOrDefault();
            Data.DataStudent.Aclasses.DeleteOnSubmit(delete);
            Data.DataStudent.SubmitChanges();
        }
    }
}
