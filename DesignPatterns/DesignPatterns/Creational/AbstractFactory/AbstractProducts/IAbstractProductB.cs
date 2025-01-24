
namespace DesignPatterns.Creational.AbstractFactory.AbstractProducts
{
    internal interface IAbstractProductB
    {
        public string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
