using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Pages
    {
        public static OwnerPage OwnerPage => new OwnerPage(Base.driver);

        public static PetPage PetPage => new PetPage(Base.driver);

        public static SpecialityPage SpecialityPage => new SpecialityPage(Base.driver);
    }
}
