using DesignPatterns.Creational.FactoryMethod.ConcreteProducts;

namespace DesignPatterns.Creational.FactoryMethod.ConcreteCreators
{
    internal class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
