using System;
using System.Data;

namespace gg.commmand
{
    public interface ICommand
    {
        void Execute(IDbConnection dbConnection);
    }
    public interface IQuery<T>
    {
        T Execute(IDbConnection dbConnection);
    }
}