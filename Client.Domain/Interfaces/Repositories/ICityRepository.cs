using Client.Domain.Entities;

namespace Client.Domain.Interfaces.Repositories
{
    public interface ICityRepository
    {
        Task<List<CityModel>> GetListAsync(string uf);
    }
}
