using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage.DataProvide
{
    public interface DataProvider
    {
        DataTable ExcuteQuery(string query);
    }
}
