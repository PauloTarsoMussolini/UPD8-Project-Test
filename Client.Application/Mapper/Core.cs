using AutoMapper;
using Client.Application.ViewModel.Request.Client;
using Client.Application.ViewModel.Response.Client;
using Client.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Application.Mapper
{
    public class Core : Profile
    {
        public Core() {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<ClientRequest, ClientModel>();
            CreateMap<ClientModel, ClientResponse >();
        }

    }
}
