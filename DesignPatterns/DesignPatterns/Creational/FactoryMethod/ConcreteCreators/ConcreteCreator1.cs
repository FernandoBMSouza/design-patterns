using DesignPatterns.Creational.FactoryMethod.ConcreteProducts;

namespace DesignPatterns.Creational.FactoryMethod.ConcreteCreators
{
    internal class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
