using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        IBuilder BuildName();
        IBuilder BuildAge();
        IBuilder BuildStructure();
        IBuilder BuildHairColor();
        IBuilder BuildClothes();
        IBuilder BuildInventory();

        Person GetPerson();
    }
}
