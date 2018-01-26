using System;
using SQLite;

namespace xceler.DALSQLite
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection(string DBName);
       
    }
}
