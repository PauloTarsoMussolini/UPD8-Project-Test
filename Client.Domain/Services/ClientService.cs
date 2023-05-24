using Client.Domain.Entities;
using Client.Domain.Interfaces.Repositories;
using Client.Domain.Interfaces.Services;
using Client.Domain.Validations;
using Client.Domain.Validations.Base;
using Client.Domain.Validations.Base;

namespace Client.Domain.Services
{
    public class ClientService : IClientService
    {

        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
  
        async Task<Response> IClientService.CreateAsync(ClientModel client)
        {
            var response = new Response();

            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }

            await _clientRepository.CreateAsync(client);
            return response;
        }

        async Task<Response> IClientService.UpdateAsync(ClientModel client)
        {
            var response = new Response();

            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
            {
                return errors;
            }
            var exists = await _clientRepository.ExistsByIdAsync(client.Id);

            if (!exists)
            {
                response.Report.Add(ReportErrors.Create($"Client {client.Id} don't exists"));
                return response;
            }

            await _clientRepository.UpdateAsync(client);
            return response;
        }

        async Task<Response> IClientService.DeleteAsync(int Id)
        {
            var response = new Response();

            var exists = await _clientRepository.ExistsByIdAsync(Id);

            if (!exists)
            {
                response.Report.Add(ReportErrors.Create($"Client {Id} don't exists"));
                return response;
            }

            await _clientRepository.DeleteAsync(Id);
            return response;
        }

        async Task<Response<List<ClientModel>>> IClientService.GetListAsync(int Id, string? name)
        {
            var response = new Response<List<ClientModel>>();

            var data = await _clientRepository.GetListAsync(Id, name);
            if (data == null)
            {
                response.Report.Add(ReportErrors.Create($"Client with this parameters not exists!"));
                return response;
            }
            response.Data = data;

            return response;
        }

        async Task<Response<ClientModel>> IClientService.GetByIdAsync(int Id)
        {
            var response = new Response<ClientModel>();

            var data = await _clientRepository.GetByIdAsync(Id);
            if (data == null)
            {
                response.Report.Add(ReportErrors.Create($"Client {Id} not exists!"));
                return response;
            }
            response.Data = data;
            return response;
        }
    }
}
