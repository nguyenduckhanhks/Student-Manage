using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage
{
    class Data
    {
        private static Data instance;
        private static StudentManageDataContext dataStudent;
        public static Data Instance
        {
            get { if (instance == null) instance = new Data(); return Data.instance; }
            private set { Data.instance = value; }
        }

        private Data() { }

        public static StudentManageDataContext DataStudent
        {
            get { if (dataStudent == null) dataStudent = new StudentManageDataContext(); return dataStudent; }
            private set { dataStudent = value; }
        }

    }
}
