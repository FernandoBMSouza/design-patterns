using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactories
{
    internal class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
