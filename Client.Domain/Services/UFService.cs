using Client.Domain.Entities;
using Client.Domain.Interfaces.Services;
using Client.Domain.Validations.Base;
using Client.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Domain.Services
{
    internal class UFService : IUFService
    {
        private readonly IUFService _ufService;

        public UFService(IUFService ufService)
        {
            _ufService = ufService;
        }

        async Task<List<UFModel>> IUFService.GetListAsync()
        {
            return await _ufService.GetListAsync();
        }
    }
}
