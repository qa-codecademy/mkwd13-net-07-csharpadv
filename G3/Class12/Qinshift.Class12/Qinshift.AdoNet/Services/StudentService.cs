using Microsoft.Data.SqlClient;
using Qinshift.AdoNet.Models;

namespace Qinshift.AdoNet.Services
{
    public class StudentService
    {
        private readonly string _connectionString;

        public StudentService(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        ///     Retrieves all student records from the database.
        /// </summary>
        /// <returns>A list of <see cref="Student"/> objects representing all students in the database.</returns>
        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            // 1. Establish the conneciton to the Database

            // BAD WAY
            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();
            //.......
            //connection.Close();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                // 2. Write the SQL query
                //string query = @"
                //    SELECT *
                //    FROM dbo.Student
                //";
                string query = @"
                    SELECT s.ID, s.FirstName, s.LastName, s.DateOfBirth, s.EnrolledDate, s.Gender, s.NationalIdNumber, s.StudentCardNumber 
                    FROM [dbo].[Student] s
                ";

                // 3. Create sql command 
                using SqlCommand command = new SqlCommand(query, sqlConnection);

                // 4. Execute the sql command
                using SqlDataReader reader = command.ExecuteReader();

                // 5. Read the data from the executed query
                while (reader.Read())
                {
                    // 6. Map manually the retrieved columns to Student object
                    var student = new Student
                    {
                        // IMPORTANT: The order of the columns is the one written in the SELECT query
                        Id = reader.GetInt32(0),
                        FirstName = reader.IsDBNull(1) ? "N/A" : reader.GetString(1),
                        LastName = reader.GetString(2),
                        DateOfBirth = reader.GetDateTime(3),
                        EnrolledDate = reader.GetDateTime(4),
                        Gender = reader.GetChar(5),
                        NationalIdNumber = reader.GetInt64(6),
                        StudentCardNumber = reader.GetString(7)
                    };
                    students.Add(student);
                }
            }

            return students;
        }
    }
}
