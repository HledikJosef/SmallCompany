using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace SmallCompany.DataLayer.Implementation
{
    public class UserStore : IUserStore<IdentityUser>, IUserPasswordStore<IdentityUser>
    {
        private readonly IConnectionStringProvider connectionStringProvider;

        public UserStore(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public async Task<IdentityResult> CreateAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            var query = "INSERT INTO Users (Id, UserName, NormalizedUserName, PasswordHash) VALUES (@Id, @UserName, @NormalizedUserName, @PasswordHash)";
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var result = await connection.ExecuteAsync(query, user);
                return result > 0 ? IdentityResult.Success : IdentityResult.Failed();
            }
        }

        public async Task<IdentityResult> DeleteAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            var query = "DELETE FROM Users WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var result = await connection.ExecuteAsync(query, new { user.Id });
                return result > 0 ? IdentityResult.Success : IdentityResult.Failed();
            }
        }

        public async Task<IdentityUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            var query = "SELECT * FROM Users WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                return await connection.QuerySingleOrDefaultAsync<IdentityUser>(query, new { Id = userId });
            }
        }

        public async Task<IdentityUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var query = "SELECT * FROM Users WHERE NormalizedUserName = @NormalizedUserName";
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                return await connection.QuerySingleOrDefaultAsync<IdentityUser>(query, new { NormalizedUserName = normalizedUserName });
            }
        }

        public Task<string> GetNormalizedUserNameAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string> GetUserIdAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id);
        }

        public Task<string> GetUserNameAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task SetNormalizedUserNameAsync(IdentityUser user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        public Task SetUserNameAsync(IdentityUser user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public Task SetPasswordHashAsync(IdentityUser user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        public Task<string> GetPasswordHashAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task<IdentityResult> UpdateAsync(IdentityUser user, CancellationToken cancellationToken)
        {
            var query = "UPDATE Users SET UserName = @UserName, NormalizedUserName = @NormalizedUserName, PasswordHash = @PasswordHash WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.ConnectionString))
            {
                var result = connection.ExecuteAsync(query, user);
                return result.Result > 0 ? IdentityResult.Success : IdentityResult.Failed();
            }
        }

        public void Dispose()
        {
            // Cleanup if needed
        }
    }
}
