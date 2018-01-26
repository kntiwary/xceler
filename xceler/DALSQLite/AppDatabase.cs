using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using xceler.Model;

namespace xceler.DALSQLite
{
    public class AppDatabase
    {
        readonly SQLiteAsyncConnection database;
        public AppDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection("Xceler.db3");
            database.CreateTableAsync<User>().Wait();
        }
        public Task<int> InsertUserDetails(User item)
        {
            return database.InsertAsync(item);
        }
        public Task<List<User>> GetUserDetailsAsync()
        {
            return database.Table<User>().ToListAsync();
        }
    }
}
