using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurucuKursuOtomasyonu.Entities.Abstract;

namespace SurucuKursuOtomasyonu.Entities.Concrete
{
   public class LicenceType:IEntity
    {
        public int LicenceTypeId { get; set; }
        public string LicenceName{ get; set; }
    }
}
