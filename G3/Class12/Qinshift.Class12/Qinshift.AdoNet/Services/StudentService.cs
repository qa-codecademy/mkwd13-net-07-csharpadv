using Microsoft.Data.SqlClient;
using Qinshift.AdoNet.Models;

namespace Qinshift.AdoNet.Services
{
    // SqlConnection => used to establish connection to a database
    // SqlCommand => execute SQL queries, stored procedures, and other database commands
    // SqlDataReader => read data from a database
    public class StudentService
    {
        private readonly string _connectionString;

        public StudentService(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        ///     Retrieves all student records from the database. HAHA
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
                        Gender = reader.GetString(5)[0],
                        NationalIdNumber = reader.GetInt64(6),
                        StudentCardNumber = reader.GetString(7)
                    };
                    students.Add(student);
                }
            }

            return students;
        }

        /// <summary>
        ///     Inserts a new student record into the database.
        /// </summary>
        /// <param name="student">The <see cref="Student"/> object containing the student data to insert.</param>
        public void InsertStudent(Student student)
        {
            // 1. Establish the conneciton to the Database
            using (SqlConnection sqlConnection = new(_connectionString))
            {
                sqlConnection.Open();

                // 2. Write the SQL query
                string query = $@"
                    INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)
                    VALUES(@FirstName, @LastName, @DOB, @EnrolledDate, @Gender, @NationalIdNumber, @StudentCardNumber)
                ";

                // ===> The issue here occured because of the ' before and after the placeholders values
                //string query = $@"
                //    INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)
                //    VALUES('@FirstName', '@LastName', '@DOB', '@EnrolledDate', '@Gender', @NationalIdNumber, '@StudentCardNumber')
                //";

                // 3. Create sql command 
                using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // 4. Map the insert values
                sqlCommand.Parameters.AddWithValue("@LastName", student.LastName);
                sqlCommand.Parameters.AddWithValue("@FirstName", (object?)student.FirstName ?? DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@EnrolledDate", student.EnrolledDate);
                sqlCommand.Parameters.AddWithValue("@DOB", student.DateOfBirth);
                sqlCommand.Parameters.AddWithValue("@Gender", student.Gender);
                sqlCommand.Parameters.AddWithValue("@NationalIdNumber", student.NationalIdNumber);
                sqlCommand.Parameters.AddWithValue("@StudentCardNumber", student.StudentCardNumber);

                // 5. Execute the query
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Rows Affected " + rowsAffected);
            }
        }

        /// <summary>
        ///     Inserts a new student record into the database.
        ///     VULNERABLE TO SQL INJECTION !
        /// </summary>
        public void InsertStudentMalicious(Student student)
        {
            // 1. Establish the conneciton to the Database
            using (SqlConnection sqlConnection = new(_connectionString))
            {
                sqlConnection.Open();

                // BAD EXAMPLE => POSSIBLE SQL INJECTION VULNERABILITY
                // SQL INJECTION => Malicious users can manipulate the input data to execute unintended SQL commands, potentially compromising your database and data.

                // 2. Write the SQL query
                string query = $@"
                    INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)
                    VALUES('{student.FirstName}', '{student.LastName}', '{student.DateOfBirth:yyyy-MM-dd}', '{student.EnrolledDate:yyyy-MM-dd}', '{student.Gender}', {student.NationalIdNumber}, '{student.StudentCardNumber}')
                ";

                // 3. Create sql command 
                using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // 4. Execute the query
                sqlCommand.ExecuteNonQuery();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\t============ Bye Bye Table... :) ============\n\n");
                Console.ResetColor();
            }
        }

        /// <summary>
        ///     Retrieves a student record by their unique ID.
        /// </summary>
        /// <param name="id">The ID of the student to retrieve.</param>
        /// <returns>
        ///     A <see cref="Student"/> object if a student with the specified ID exists; otherwise <i>null</i>.
        /// </returns>
        public Student? GetStudentById(int id)
        {
            Student? student = null;

            // 1. Establish the conneciton to the Database
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // 2. Write the SQL query
                string query = @"
                    SELECT s.ID, s.FirstName, s.LastName, s.DateOfBirth, s.EnrolledDate, s.Gender, s.NationalIdNumber, s.StudentCardNumber 
                    FROM dbo.Student s
                    WHERE s.ID = @StudentId
                ";

                // 3. Create sql command 
                using SqlCommand command = new SqlCommand(query, connection);

                // 4. Map the parameters
                command.Parameters.AddWithValue("@StudentId", id);

                // 5. Execute the sql command
                using SqlDataReader reader = command.ExecuteReader();

                // 6. Read the data from the executed query
                if (reader.Read())
                {
                    // 7. Map the student info
                    student = new Student
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        DateOfBirth = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                        EnrolledDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                        Gender = reader.IsDBNull(5) ? null : reader.GetString(5)[0],
                        NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetInt64(6),
                        StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetString(7)
                    };
                }
            }

            return student;
        }
    }
}
