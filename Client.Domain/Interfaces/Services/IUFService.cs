using Client.Domain.Entities;

namespace Client.Domain.Interfaces.Services
{
    internal interface IUFService
    {
        Task<List<UFModel>> GetListAsync();
    }
}
