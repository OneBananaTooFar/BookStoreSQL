using System;
namespace SQLBookStore.Classes
{
    public class DataBaseHelper
    {
        public DataBaseHelper()
        {
        }

        public static bool Insert <T>(ref T data, string db_path)
        {

            using (var conn = new SQLite.SQLiteConnection(db_path))


            return false;

        }


    }
}
