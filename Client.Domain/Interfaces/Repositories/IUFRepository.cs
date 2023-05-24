using Client.Domain.Entities;

namespace Client.Domain.Interfaces.Repositories
{
    public interface IUFRepository
    {
        Task<List<UFModel>> GetListAsync();
    }
}
