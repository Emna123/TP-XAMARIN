using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Tp.Models;

namespace Tp.Repos
{
    public class UserRepo
    {
        SQLiteAsyncConnection connection;
        public string StatusMessage { get; set; }
        public UserRepo(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<User>();
        }
        public async Task AddNewUserAsunc(string email, string password)
        {
            int result = 0;
            try
            {
                result = await connection.InsertAsync(new User { email = email, password = password });
                StatusMessage = $"successful registration";
            }
            catch (Exception ex)
            {
                StatusMessage = $"cannot add this user.\n Error: {ex.Message}";
            }
        }
        public async Task<List<User>> GetUsersAsync()
        { try
            {
                return await connection.Table<User>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = $"connection problem .\n Error: {ex.Message}";
            }
            return new List<User>();
        }
    } 
}
