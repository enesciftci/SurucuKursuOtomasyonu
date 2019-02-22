using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Entities.Abstract;

namespace SurucuKursuOtomasyonu.Entities.Concrete
{
   public class RegistrationSeason:IEntity
    {
        public int RegistrationSeasonId { get; set; }
        public string Season { get; set; }
    }
}
