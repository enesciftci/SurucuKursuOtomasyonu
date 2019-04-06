using SurucuKursuOtomasyonu.Entities.Abstract;

namespace SurucuKursuOtomasyonu.Entities.Concrete
{
    public class RegistrationSeason : IEntity
    {
        public int RegistrationSeasonId { get; set; }
        public string Season { get; set; }
    }
}