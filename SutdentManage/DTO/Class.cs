using SutdentManage.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage.DTO
{
    class Class
    {
        string id;

        string name;

        int numberOfStudents;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfStudents { get => numberOfStudents; set => numberOfStudents = value; }

        public Class(string name, int numberOfStudents)
        {
            this.id = RandomIdProvide.Instance.CreateId();
            this.name = name;
            this.numberOfStudents = numberOfStudents;
        }
        
    }
}
