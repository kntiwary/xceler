using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using xceler.DALSQLite;


[assembly: Dependency(typeof(xceler.Droid.SQLite))]
namespace xceler.Droid
{
        public class SQLite : ISQLite
        {
            public global::SQLite.SQLiteAsyncConnection GetConnection(string DBName)
            {
                string sqliteFilename = DBName;
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string path = Path.Combine(documentsPath, sqliteFilename);
                return new SQLiteAsyncConnection(path);

            }
        }

}
