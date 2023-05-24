using Client.Domain.Entities;
using Client.Domain.Validations.Base;

namespace Client.Domain.Interfaces.Services
{
    public interface ICItyService
    {
        Task<Response<List<CityModel>>> GetListAsync(string uf);
    }
}
