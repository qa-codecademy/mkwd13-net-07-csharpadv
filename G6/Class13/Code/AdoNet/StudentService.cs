using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;

namespace AdoNet
{
    public class StudentService
    {
        private readonly string _connectionString;

        public StudentService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            //1. open a connection to the db
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString)) //SqlConnection - establish a connection to the db
            {
                sqlConnection.Open(); //we need to open the connection

                // 2. write the sql query (SELECT * FROM Student)
                //we need to write our query in our c# code
                string query = @"
                SELECT s.ID, s.FirstName, s.LastName, s.DateOfBirth, s.EnrolledDate, s.Gender, s.NationalIdNumber, s.StudentCardNumber
                FROM [dbo].[Student] s";

                //3. create sql command
                using SqlCommand command = new SqlCommand(query, sqlConnection); //we need to tell the command what to execute and which connection to use

                //4. Execute the sql command
                using SqlDataReader reader = command.ExecuteReader(); //execute the command, reads the data from the db

                //5. Read the data from the executed query
                while (reader.Read()) //read item by item until you read all items
                {
                    //6.manually map the data to a student object
                    Student student = new Student
                    {
                        Id = reader.GetInt32(0), //get the number value from the first column
                        FirstName = reader.IsDBNull(1) ? "unnamed" : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? "unnamed" : reader.GetString(2),
                        DateofBirth = reader.GetDateTime(3),
                        EnrolledDate = reader.GetDateTime(4),
                        Gender = reader.GetString(5)[0], //our string is an array of chars 
                        NationalIdNumber = reader.GetInt64(6),
                        StudentCardNumber = reader.GetString(7)
                    };
                    students.Add(student);
                }

                return students;

            }//sqlConnection.Close() will be called when using ends
        }

        public void InsertStudent(Student student)
        {
            //1. Create and open a connection to the db
            using(SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                //2. Write the sql query
                // John', 'Doe', '2000-01-01', '2025-01-01', 'M', 1234567890123, 'CA-2024-001'); DROP TABLE Student;--
                //SQL Injection - we shouldn't use this way of sending data directly into the query
                //string query = $"INSERT INTO dbo.Student(FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber" +
                //    $"VALUES({student.FirstName}, {student.LastName}, {student.DateofBirth}, {student.EnrolledDate}, {student.Gender},{student.NationalIdNumber}, {student.StudentCardNumber})";

                //safe way is to use parameters
                string query = $"INSERT INTO dbo.Student(FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)" +
                    "VALUES (@FirstName, @LastName, @DateOfBirth, @EnrolledDate, @Gender, @NationalIdNumber, @StudentCardNumber)";

                //3.Create sql command
                using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                //4. Map the inserted values for the params
                sqlCommand.Parameters.AddWithValue("@FirstName", student.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", student.LastName);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", student.DateofBirth);
                sqlCommand.Parameters.AddWithValue("@EnrolledDate", student.EnrolledDate);
                sqlCommand.Parameters.AddWithValue("@Gender", student.Gender);
                sqlCommand.Parameters.AddWithValue("@NationalIdNumber", student.NationalIdNumber);
                sqlCommand.Parameters.AddWithValue("@StudentCardNumber", student.StudentCardNumber);

                //5. Execute the query
                //when we execute an insert query there are no rows that we need to read
                //that's why here we don't need a reader
                int rowsAffected = sqlCommand.ExecuteNonQuery(); //this returns the number of rows affected
                Console.WriteLine(rowsAffected);

            }
        }
    }
}
