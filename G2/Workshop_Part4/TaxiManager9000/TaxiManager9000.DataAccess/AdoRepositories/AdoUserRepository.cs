

using Microsoft.Data.SqlClient;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.AdoRepositories
{
    public class AdoUserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public AdoUserRepository(string connString)
        {
            _connectionString = connString;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = new List<User>();
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("SELECT * FROM Users", conn);

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while(await reader.ReadAsync())
            {
                users.Add(new User
                {
                    Id = reader.GetFieldValue<int>(0),
                    Username = reader.GetFieldValue<string>(1),
                    Password = reader.GetFieldValue<string>(2),
                    Role = (Role)reader.GetFieldValue<int>(3)
                });
            }

            return users;
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("SELECT * FROM Users WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            if(await reader.ReadAsync())
            {
                return new User
                {
                    Id = reader.GetFieldValue<int>(0),
                    Username = reader.GetFieldValue<string>(1),
                    Password = reader.GetFieldValue<string>(2),
                    Role = (Role)reader.GetFieldValue<int>(3)
                };
            }
            return null;
        }

        public async Task Insert(User user)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(@"
                                            INSERT INTO Users (Username, Password, Role)
                                            VALUES (@Username, @Password, @Role)
                                            ", conn);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Role", (int)user.Role);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task Update(User user)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(@"
                                            UPDATE Users
                                            SET Username = @Username, 
                                                Password = @Password, 
                                                Role = @Role
                                            ", conn);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Role", (int)user.Role);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }
        public async Task Delete(int id)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("DELETE FROM Users WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", id);
            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }
    }
}
