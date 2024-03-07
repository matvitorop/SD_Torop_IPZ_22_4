namespace OpenClosed
{
    interface IMoney
    {
        void PrintAmount();
    }
    public abstract class Money : IMoney
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
            mainPart = newMainPart;
            return true;
        }

        public bool setFractionalPart(int newFractionalPart)
        {
            fractionalPart = newFractionalPart;
            return true;
        }

        public abstract void PrintAmount();
    }
}
