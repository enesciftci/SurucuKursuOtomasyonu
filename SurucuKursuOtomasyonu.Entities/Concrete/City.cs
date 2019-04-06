using SurucuKursuOtomasyonu.Entities.Abstract;

namespace SurucuKursuOtomasyonu.Entities.Concrete
{
    public class City : IEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}