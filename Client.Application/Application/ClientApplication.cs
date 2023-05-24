using AutoMapper;
using Client.Application.Interfaces;
using Client.Application.ViewModel.Request.Client;
using Client.Domain.Entities;
using Client.Domain.Interfaces.Services;
using Client.Domain.Validations.Base;

namespace Client.Application.Application
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientApplication(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        async public Task<Response> CreateAsync(ClientRequest client)
        {
            var clientModel = _mapper.Map<ClientModel>(client);
            return await _clientService.CreateAsync(clientModel);
        }
    }
}
