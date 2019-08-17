using SutdentManage.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage.DTO
{
    class Student
    {
        string id;

        string idClass;

        string name;

        string dateOfBirt;

        string telephone;

        string email;

        int male;

        float mathPoint;

        float physicaPoint;

        float chemicalPoint;

        public string Id { get => id; set => id = value; }
        public string IdClass { get => idClass; set => idClass = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirt { get => dateOfBirt; set => dateOfBirt = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public int Male { get => male; set => male = value; }
        public float MathPoint { get => mathPoint; set => mathPoint = value; }
        public float PhysicaPoint { get => physicaPoint; set => physicaPoint = value; }
        public float ChemicalPoint { get => chemicalPoint; set => chemicalPoint = value; }

        public Student(string idClass, string name, string dateOfBirth, string telephone, string email, string male, float math, float physical, float chemical)
        {
            this.id = RandomIdProvide.Instance.CreateId();
            this.idClass = idClass;
            this.name = name;
            this.dateOfBirt = dateOfBirth;
            this.telephone = telephone;
            this.email = email;
            if (male == "Male")
                this.male = 1;
            else this.male = 0;
            this.mathPoint = math;
            this.physicaPoint = physical;
            this.chemicalPoint = chemical;
        }
    }
}
