using Client.Application.ViewModel.Request.Client;
using Client.Domain.Validations.Base;

namespace Client.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<Response> CreateAsync(ClientRequest client);

        //Task<Response<List<ClientRequest>>> GetListAsync(int Id = 0, string? name = null);

    }
}
