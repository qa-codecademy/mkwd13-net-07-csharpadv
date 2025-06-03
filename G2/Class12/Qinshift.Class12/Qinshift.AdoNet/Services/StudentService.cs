using Microsoft.Data.SqlClient;
using Qinshift.AdoNet.Entities;
using System.Data;

namespace Qinshift.AdoNet.Services
{
    public class StudentService
    {
        private readonly string _connString;

        public StudentService(string connString)
        {
            _connString = connString;
        }

        public List<Student> GetAllStudents()
        {
            // 1. Open connection to database
            // 2. Create query
            // 3. Create query command
            // 4. Execute query command
            // 5. Read the students returned if there are any
            // 6. Map the data into list of students
            // 7. Return the list of students as result

            var students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();

                string query = "SELECT ID, FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber FROM Student";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                            DateOfBirth = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                            EnrolledDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                            Gender = reader.IsDBNull(5) ? null : reader.GetString(5)[0],
                            NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetInt64(6),
                            StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetString(7)
                        });
                    }
                }
            }
            return students;
        }

        public Student? GetStudentById(string id)
        {
            Student? student = null;

            using (SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();

                string query = $"SELECT ID, FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber FROM Student WHERE ID = {id}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = new Student()
                            {
                                Id = reader.GetFieldValue<int>(0),
                                FirstName = reader.IsDBNull(1) ? null : reader.GetFieldValue<string>(1),
                                LastName = reader.IsDBNull(2) ? null : reader.GetFieldValue<string>(2),
                                DateOfBirth = reader.IsDBNull(3) ? null : reader.GetFieldValue<DateTime>(3),
                                EnrolledDate = reader.IsDBNull(4) ? null : reader.GetFieldValue<DateTime>(4),
                                Gender = reader.IsDBNull(5) ? null : reader.GetFieldValue<string>(5)[0],
                                NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetFieldValue<long>(6),
                                StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetFieldValue<string>(7)
                            };
                        }
                    }
                }
            }
            return student;
        }

        public string GetTestSqlInjectionName(string id)
        {
            string? name = null;
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();

                string query = $"SELECT Name FROM ParametersDemoTable WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader.GetString(0);
                        }
                    }
                }
            }
            return name;
        }

        public void InsertStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                string query = @"INSERT INTO Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber) 
                                 VALUES (@FirstName, @LastName, @DateOfBirth, @EnrolledDate, @Gender, @NationalIdNumber, @StudentCardNumber)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    //command.Parameters.AddWithValue("@ID", student.Id);
                    command.Parameters.AddWithValue("@FirstName", (object?)student.FirstName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastName", (object?)student.LastName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@DateOfBirth", (object?)student.DateOfBirth ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EnrolledDate", (object?)student.EnrolledDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Gender", (object?)student.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@NationalIdNumber", (object?)student.NationalIdNumber ?? DBNull.Value);
                    command.Parameters.AddWithValue("@StudentCardNumber", (object?)student.StudentCardNumber ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
