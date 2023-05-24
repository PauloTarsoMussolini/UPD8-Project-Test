using Client.Domain.Entities;
using Client.Domain.Interfaces.Services;
using Client.Domain.Validations.Base;

namespace Client.Domain.Services
{
    internal class CityService : ICItyService
    {
        private readonly ICItyService _cityService;

        public CityService(ICItyService cityService)
        {
            _cityService = cityService;
        }
   
        async Task<Response<List<CityModel>>> ICItyService.GetListAsync(string uf)
        {
            var response = new Response<List<CityModel>>();

            var data = await _cityService.GetListAsync(uf);
            if (data == null)
            {
                response.Report.Add(ReportErrors.Create($"No City with {uf} UF!"));
                return response;
            }
            response = data;

            return response;

        }
    }
}
