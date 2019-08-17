using SutdentManage.DataProvide;
using SutdentManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutdentManage.DAO
{
    class GetDataProvide : DataProvider
    {
        private static GetDataProvide instance;

        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";
        public static GetDataProvide Instance
        {
            get { if (instance == null) instance = new GetDataProvide(); return GetDataProvide.instance; }
            private set { GetDataProvide.instance = value; }
        }

        private GetDataProvide() { }
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            connection.Close();

            return dataTable;
        }

        public void ExcuteDataPro(string nameOfClass, int numberOfClass) //insert class
        {
            ExcuteQuery("exec dbo.insertClass @id = '" + RandomIdProvide.Instance.CreateId() + "',@name = '" + nameOfClass + "',@numberOfStudents = " + numberOfClass.ToString() + @"");
        }

        public DataTable ExcuteDataPro()  //get students
        {
            return ExcuteQuery("select * from dbo.students");
        }

        public DataTable ExcuteDataPro(string studentName) // find student
        {
            return ExcuteQuery("select * from dbo.students where name = '" + studentName + "'");
        }

        public DataTable ExcuteDataPro(string idClass = "",string className = "") //find class
        {
            if(idClass != "") return ExcuteQuery("select * from dbo.class where id = '" + idClass + "'");
            return ExcuteQuery("select * from dbo.class where name = '" + className + "'");
        }

        public void insertStudent(Student student)
        {
            ExcuteQuery(@"exec dbo.insertStudent @id = '" + student.Id + "', @idClass = '" + student.IdClass + "',@name = '" + student.Name + "',@dateOfbirth = '" + student.DateOfBirt + "',@telephone = '" + student.Telephone + "', @email = '" + student.Email + "', @male = " + student.Male.ToString() + ", @mathPoint = " + student.MathPoint.ToString() + ",@physicalPoint = " + student.PhysicaPoint.ToString() + ",@chemicalPoint = " + student.ChemicalPoint.ToString() + "");
        }

        public void updateStudent(string id, string newClass)
        {
            DataTable table = ExcuteQuery("select * from dbo.class where name = '" + newClass + "'");
            if (table.Rows.Count > 0)
            {
                ExcuteQuery("exec dbo.updateStudents @id = '" + id + "', @idClass = '" + table.Rows[0]["id"] + "'");
            }
        }

        public  void deleteStudent(string id, string classOfStudent)
        {
            DataTable table = ExcuteQuery("select * from dbo.class where name = '" + classOfStudent + "'");
            if (table.Rows.Count > 0)
            {
                ExcuteQuery("exec dbo.deleteStudent @id = '" + id + "'");
            }
        }

        public DataTable getClass()
        {
            return ExcuteQuery("select * from dbo.class");
        }

        public void insertClass(Class aclass)
        {
            ExcuteQuery("exec dbo.insertClass @id = '" + aclass.Id + "',@name = '" + aclass.Name + "',@numberOfStudents = " + aclass.NumberOfStudents + @"");
        }

        public void repairClass(string id, int numberOfClass)
        {
            ExcuteQuery("exec dbo.updateClass @id = '"+id+"', @number = "+numberOfClass+"");
        }

        public void deleteClass(string id)
        {
            ExcuteQuery("exec dbo.deleteClass @id = '" + id + "'");
        }
    }
}
