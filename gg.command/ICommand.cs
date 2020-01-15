using System;
using System.Data;

namespace gg.commmand
{
    public interface IDatabase
    {
        T Execute<T>(IQuery<T> query);
        void Execute(ICommand command);
    }

    public class Database : IDatabase
    {
        private readonly IDbConnection dbConnection;
        public Database(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
        public T Execute<T>(IQuery<T> query)
        {
            return query.Execute(dbConnection);
        }
        public void Execute(ICommand command)
        {
            command.Execute(dbConnection);
        }
    }


    public interface ICommand
    {
        void Execute(IDbConnection dbConnection);
    }
    public interface IQuery<T>
    {
        T Execute(IDbConnection dbConnection);
    }
}