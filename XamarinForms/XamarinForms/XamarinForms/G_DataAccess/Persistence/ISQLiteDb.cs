using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinForms.G_DataAccess.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
