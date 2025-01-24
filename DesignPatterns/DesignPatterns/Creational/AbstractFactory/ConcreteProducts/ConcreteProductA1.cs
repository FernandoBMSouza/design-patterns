using DesignPatterns.Creational.AbstractFactory.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts
{
    internal class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
