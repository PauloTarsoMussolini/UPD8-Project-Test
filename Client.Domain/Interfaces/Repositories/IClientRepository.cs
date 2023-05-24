using Client.Domain.Entities;

namespace Client.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task<List<ClientModel>> GetListAsync(int Id=0, string? name = null);
        Task<ClientModel> GetByIdAsync(int Id);
        Task CreateAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(int Id);
        Task<bool> ExistsByIdAsync(int Id);

    }
}
