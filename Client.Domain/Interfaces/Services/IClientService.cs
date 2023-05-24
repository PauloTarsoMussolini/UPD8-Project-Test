using Client.Domain.Entities;
using Client.Domain.Interfaces.Repositories;
using Client.Domain.Validations.Base;
using Client.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Domain.Interfaces.Services
{
    public interface IClientService
    {
         Task<Response<List<ClientModel>>> GetListAsync(int Id = 0, string? name = null);
        Task<Response<ClientModel>> GetByIdAsync(int Id);
        Task<Response> CreateAsync(ClientModel client);
        Task<Response> UpdateAsync(ClientModel client);
        Task<Response> DeleteAsync(int Id);
        //Task<bool> ExistByIdAsync(int Id);
    }
}
