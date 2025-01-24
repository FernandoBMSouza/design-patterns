using DesignPatterns.Creational.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactories
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
