using Client.Application.Enumarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Application.ViewModel.Response.Client
{
    public sealed  class ClientResponse
    {
        public int Id { get; set; }
        public string Cpf { get; private set; }
        public string Name { get; private set; }
        public DateTime? BornDate { get; set; }
        public GenderEnum Gender { get; set; }
        public string Address { get; private set; }
        public int AddressCityId { get; private set; }
    }
}
