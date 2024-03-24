using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Builder
{
    public class HeroBuilder : IBuilder
    {

        private Person person = new Person();
        private void reset()
        {
            this.person = new Person();
        }
        public IBuilder BuildName()
        {
            this.person.Name = "Jack";
            return this;
        }
        public IBuilder BuildAge()
        {
            this.person.Age = 25;
            return this;
        }
        public IBuilder BuildStructure()
        {
            this.person.Structure = "Very muscle";
            return this;
        }
        public IBuilder BuildHairColor()
        {
            this.person.HairColor = "White";
            return this;
        }
        public IBuilder BuildClothes()
        {
            this.person.Clothes = "Metal armor";
            return this;
        }
        public IBuilder BuildInventory()
        {
            this.person.Inventory = "Blade, Dog";
            return this;
        }
        public Person GetPerson()
        {
            Person person = this.person;
            reset();
            return person;
        }

    }
}
