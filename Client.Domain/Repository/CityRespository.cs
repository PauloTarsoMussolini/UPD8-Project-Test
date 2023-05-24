using Client.Domain.Entities;
using Client.Domain.Interfaces.Repositories;

namespace Client.Domain.Repository
{
    public class CityRespository : ICityRepository
    {
        //private readonly ICityRepository _CityRepository;

        //public CityRespository(ICityRepository CityRepository)
        //{
        //    _CityRepository = CityRepository;
        //}
        public Task<List<CityModel>> GetListAsync(string uf)
        {
            throw new NotImplementedException();
        }
    }
}
