using Client.Domain.Enumerations;

namespace Client.Domain.Entities
{
    public class CityModel : EntityBase
    {
        public CityModel()
        {
            
        }
        public string UF { get; }
        public string Name { get;  }
    }
}
