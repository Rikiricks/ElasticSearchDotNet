using ElasticSearch.API.Models;

namespace ElasticSearch.API.Services
{
    public interface IElasticService
    {
        Task CreateIndexIfNotExistsAsync(string indexName);
        Task<bool> AddOrUpdate(User user);

        Task<bool> AddOrUpdateBulk(IEnumerable<User> users, string indexName);

        Task<User> Get(string key);

        Task<List<User>?> GetAll();

        Task<bool> Remove(string key);

        Task<long?> RemoveAll();
    }
}
