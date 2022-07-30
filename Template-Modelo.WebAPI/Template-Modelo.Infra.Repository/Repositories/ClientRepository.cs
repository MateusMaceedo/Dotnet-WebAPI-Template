using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.DataConnector;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Models;
using System.Linq;

namespace Template_Modelo.Infra.Repository.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDbConnector _dbConnector;

        public ClientRepository(IDbConnector dbConnector)
        {
            _dbConnector = dbConnector;
        }

        const string baseSql = @"SELECT [Id]
                                      ,[Name]
                                      ,[Email]
                                      ,[PhoneNumber]
                                      ,[Adress]
                                      ,[CreatedAt]
                                  FROM [dbo].[Client]
                                  WHERE 1 = 1 ";

        public async Task CreatAsync(ClientModel client)
        {
            string sql = @"INSERT INTO [dbo].[Client]
                                   ([Id]
                                   ,[Name]
                                   ,[Email]
                                   ,[PhoneNumber]
                                   ,[Adress]
                                   ,[CreatedAt])
                             VALUES
                                   (@Id
                                   ,@Name
                                   ,@Email
                                   ,@PhoneNumber
                                   ,@Adress
                                   ,@CreatedAt)";

            await _dbConnector.DbConnection.ExecuteAsync(sql, new
            {
                Id = client.Id,
                Name = client.Name,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber,
                Adress = client.Adress,
                CreatedAt = client.CreatedAt
            }, _dbConnector.DbTransaction);
        }

        public async Task DeleteAsync(string clientId)
        {
            string sql = $"DELETE FROM [dbo].[Client] WHERE id = @id";

            await _dbConnector.DbConnection.ExecuteAsync(sql, new { Id = clientId }, _dbConnector.DbTransaction);
        }

        public async Task<bool> ExistsByIdAsync(string clientId)
        {
            string sql = $"SELECT 1 FROM Client WHERE Id = @Id";

            var clients = await _dbConnector.DbConnection.QueryAsync<bool>(sql, new { Id = clientId }, _dbConnector.DbTransaction);

            return clients.FirstOrDefault();
        }

        public async Task<ClientModel> GetByIdAsync(string clientId)
        {
            string sql = $"{baseSql} AND Id = @Id";

            var clients = await _dbConnector.DbConnection.QueryAsync<ClientModel>(sql, new { Id = clientId }, _dbConnector.DbTransaction);

            return clients.FirstOrDefault();
        }

        public async Task<List<ClientModel>> ListByFilterAsync(string clientId = null, string name = null)
        {
            string sql = $"{baseSql} ";

            if (!string.IsNullOrWhiteSpace(clientId))
                sql += "AND Id = @Id";

            if (!string.IsNullOrWhiteSpace(name))
                sql += "AND Name like @Name";

            var clients = await _dbConnector.DbConnection.QueryAsync<ClientModel>(sql, new { Id = clientId, Name = "%" + name + "%" }, _dbConnector.DbTransaction);

            return clients.ToList();
        }

        public async Task UpdateAsync(ClientModel client)
        {
            string sql = @"UPDATE [dbo].[Client]
                               SET [Name] = @Name
                                  ,[Email] = @Email
                                  ,[PhoneNumber] = @PhoneNumber
                                  ,[Adress] = @Adress
                             WHERE Id = @Id";

            await _dbConnector.DbConnection.ExecuteAsync(sql, new
            {
                Id = client.Id,
                Name = client.Name,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber,
                Adress = client.Adress,
            }, _dbConnector.DbTransaction);
        }
    }
}
