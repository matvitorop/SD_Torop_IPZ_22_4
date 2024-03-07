using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KISS
{
    public class Money
    {
        private int mainPart;
        private int fractionalPart;

        public Money(int mainPart, int fractionalPart)
        {
            this.mainPart = mainPart;
            this.fractionalPart = fractionalPart;
        }

        public int getMainPart()
        {
            return mainPart;
        }

        public int getFractionalPart()
        {
            return fractionalPart;
        }

        public bool setMainPart(int newMainPart)
        {
            if (mainPart != newMainPart)
            {
                mainPart = newMainPart;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setFractionalPart(int newFractionalPart)
        {
            if (fractionalPart != newFractionalPart) 
            {
                fractionalPart = newFractionalPart;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void PrintAmount()
        {
            Console.WriteLine($"Total summ = {getMainPart()}.{getFractionalPart()}");
        }

    }
}
