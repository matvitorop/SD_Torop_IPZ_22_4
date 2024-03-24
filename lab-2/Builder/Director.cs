using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public Director (IBuilder builder)
        {
            _builder = builder;
        }

        public Director SetBuilder(IBuilder builder)
        {
            _builder = builder;
            return this;
        }

        public Person GetFullPerson()
        {
            return this._builder.BuildName().BuildAge().BuildStructure().BuildHairColor().BuildClothes().BuildInventory().GetPerson();
        }
        public Person GetMVPPerson()
        {
            return this._builder.BuildName().GetPerson();
        }
    }
}
