using DesignPatterns.Creational.AbstractFactory.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal interface IAbstractFactory
    {
        public IAbstractProductA CreateProductA();
        public IAbstractProductB CreateProductB();
    }
}
