using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace T1808A_UWP_SQLite.Utils
{
    public class SQLiteUtil
    {
        private const string DatabaseName = "demo.db";

        private static SQLiteUtil _instance;
        public SQLiteConnection Connection { get; }

        public static SQLiteUtil GetIntances()
        {
            if (_instance == null)
            {
                _instance = new SQLiteUtil();
            }
            return _instance;
        }

        private SQLiteUtil()
        {
            Connection = new SQLiteConnection(DatabaseName);
            CreateTables();
        }

        private void CreateTables()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS Customer (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ),City VARCHAR( 140 ),Contact VARCHAR( 140 ));";
            using (var statement = Connection.Prepare(sql))
            {
                statement.Step();
            }
            sql = @"CREATE TABLE IF NOT EXISTS Student (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ));";
            using (var statement = Connection.Prepare(sql))
            {
                statement.Step();
            }
        }

        public void InsertDemo()
        {
            try
            {
                using (var custstmt = Connection.Prepare("INSERT INTO Customer (Name, City, Contact) VALUES (?, ?, ?)"))
                {
                    custstmt.Bind(1, "Tung");
                    custstmt.Bind(2, "hangoai");
                    custstmt.Bind(3, "blo");
                    custstmt.Step();
                }

            }
            catch (Exception ex)
            {
                // TODO: Handle error}

            }
        }
    }
}
