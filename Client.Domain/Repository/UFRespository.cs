using Client.Domain.Entities;
using Client.Domain.Interfaces.Repositories;

namespace Client.Domain.Repository
{
    public class UFRespository : IUFRepository
    {
        private readonly IUFRepository _UFRepository;

        public UFRespository(IUFRepository UFRepository)
        {
            _UFRepository = UFRepository;
        }
        public Task<List<UFModel>> GetListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
