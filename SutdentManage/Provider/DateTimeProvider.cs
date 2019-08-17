using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SutdentManage.Provider
{
    class DateTimeProvider
    {
        private static DateTimeProvider instance;

        public static DateTimeProvider Instance
        {
            get { if (instance == null) instance = new DateTimeProvider(); return DateTimeProvider.instance; }
            private set { DateTimeProvider.instance = value; }
        }

        private DateTimeProvider() { }

        public DateTime convertStringToDate(string date)
        {
            string month = "";
           
            for(int i = 0; i < 2; i++)
            {
                if (date[i] != '/') month = month + date[i].ToString();
            }
            string day = "";
            for (int i = 2; i < 5; i++)
            {
                if (date[i] != '/') day = day + date[i].ToString();
            }
            string year = "";
            for (int i = 5; i < 10; i++)
            {
                if (date[i] != '/') year = year + date[i].ToString();
            }
            int a = int.Parse(year);
            int b = int.Parse(month);
            int c = int.Parse(day);
            DateTime d = new DateTime(a,b,c);
            return d;
        }
    }
}
