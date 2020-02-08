using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinForms.G_DataAccess.Persistence;
using XamarinForms.iOS.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace XamarinForms.iOS.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}

