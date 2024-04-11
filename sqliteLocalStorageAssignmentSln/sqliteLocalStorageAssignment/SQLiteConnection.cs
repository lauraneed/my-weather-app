
namespace sqliteLocalStorageAssignment
{
    internal class SQLiteConnection : IDisposable
    {
        private string v;

        public SQLiteConnection(string v)
        {
            this.v = v;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void CreateTable<T>()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal object Table<T>()
        {
            throw new NotImplementedException();
        }
    }
}