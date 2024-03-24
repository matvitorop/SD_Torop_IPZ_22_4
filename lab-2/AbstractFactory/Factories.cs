using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        public ILaptop CreateLaptop();
        public INetbook CreateNetbook();
        public ISmartphone CreateSmartphone();
    }

    public class ArasakaFacroty : IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new ArasakaLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new ArasakaNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new ArasakaSmartphone();
        }
    }

    public class SasungFacroty : IAbstractFactory
    {
        public ILaptop CreateLaptop()
        {
            return new SasungLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new SasungNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new SasungSmartphone();
        }
    }


}
