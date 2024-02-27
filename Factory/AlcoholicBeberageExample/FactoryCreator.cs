using System.Dynamic;

namespace Factory.AlcoholicBeberageExample
{
    public class FactoryCreator
    {
        public const int WINE = 1;
        public const int BEER = 2;

        public static AlcoholicBeberage CreateBeberage(int beberageType)
        {
            switch (beberageType)
            {
                case WINE:
                    return new Wine();
                case BEER:
                    return new Beer();
                default:
                    return null;
            }
        }
    }
}