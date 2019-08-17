using SutdentManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            private set { ClassDAO.instance = value; }
        }

        private ClassDAO() { }

        public DataTable findClass(string idClass = "",string className="")
        {
            return GetDataProvide.Instance.ExcuteDataPro(idClass, className);
        }

        public DataTable getClass()
        {
            return GetDataProvide.Instance.getClass();
        }

        public void insertClass(Class aclass)
        {
            GetDataProvide.Instance.insertClass(aclass);
        }

        public void updateClass(string id, int number)
        {
            GetDataProvide.Instance.repairClass(id, number);
        }

        public void deleteClass(string id)
        {
            GetDataProvide.Instance.deleteClass(id);
        }

    }
}
