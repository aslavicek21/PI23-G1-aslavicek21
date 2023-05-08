using DBLayer;
using EvaluationManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager {

    public static class StudentRepository {
        public static Student CreateObject(SqlDataReader reader) {
            Student student = new Student();
            student.Id = Convert.ToInt32(reader["Id"].ToString());
            student.FirstName = reader["FirstName"].ToString();
            student.LastName = reader["LastName"].ToString();
            int.TryParse(reader["Grade"].ToString(), out int grade);
            student.Grade = grade;

            return student;
        }
        public static Student GetStudent(int id) {
            Student student = null;
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM Students WHERE Id = {id}");
            if (reader.HasRows) {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student;
        }
        public static List<Student> GetStudents() {
            List<Student> students = new List<Student>();
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader($"SELECT * FROM Students");
            while (reader.Read()) { 
                if (reader.HasRows) {
                    students.Add(CreateObject(reader));
                }
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }
        
    }
}