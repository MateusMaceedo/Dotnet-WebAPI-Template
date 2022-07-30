using System;
using System.Data;

namespace Template_Modelo.Domain.Interfaces.DataConnector
{
    public interface IDbConnector : IDisposable
    {
        IDbConnection DbConnection { get; }
        IDbTransaction DbTransaction { get; set; }
        IDbTransaction BeginTransaction(IsolationLevel isolation);
    }
}
