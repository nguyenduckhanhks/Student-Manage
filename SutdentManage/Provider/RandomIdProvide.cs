using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage.DAO
{
    class RandomIdProvide
    {
        private static RandomIdProvide instance;

        public static RandomIdProvide Instance
        {
            get { if (instance == null) instance = new RandomIdProvide(); return RandomIdProvide.instance; }
            private set { RandomIdProvide.instance = value; }
        }

        private RandomIdProvide() { }

        public string CreateId()
        {
            string s = "";
          
            System.Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                s = s + (char)random.Next(97, 123);
            }

            return s;
        }
    }
}
