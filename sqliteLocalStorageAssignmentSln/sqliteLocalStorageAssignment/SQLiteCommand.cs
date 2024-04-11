
namespace sqliteLocalStorageAssignment
{
    internal class SQLiteCommand : IDisposable
    {
        public SQLiteCommand(string createTableSql, SQLiteConnection connection)
        {
        }

        public object Parameters { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal IDisposable ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}