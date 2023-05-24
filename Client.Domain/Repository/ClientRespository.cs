using Client.Domain.Entities;
using Client.Domain.Interfaces.Repositories;
using Client.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Domain.Repository
{
    public class ClientRespository : IClientRepository
    {
        private readonly IClientRepository _clientRepository;

        public ClientRespository(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Task CreateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> GetListAsync(int Id = 0, string? name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
