using System;
using SQLite;

namespace SQLBookStore.Classes
{
    public class Book
    {
        public Book()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
