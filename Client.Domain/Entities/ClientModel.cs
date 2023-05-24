using Client.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Domain.Entities
{
    public class ClientModel : EntityBase
    {
        public ClientModel(string cpf, string name, GenderEnum gender, String address, int addressCityId )
        {
            Cpf = cpf;
            Name = name;
            Gender = gender;
            Address = address;
            AddressCityId = addressCityId;          
        }
        public string Cpf { get; private set; }
        public string Name { get; private set; }
        public DateTime? BornDate { get; set; }
        public GenderEnum Gender { get; set; }
        public string Address { get; private set; }
        public int AddressCityId { get; private set; }
    }
}
