using CoffeeMachine.Models;

namespace CoffeeMachine.Service
{
    public interface ITransactionHandler
    {
        decimal AvailableFunds { get; }
        CoffeeOrder CoffeeOrder { get; }

        void AddCoffeeOrder(CoffeeOrder coffeeOrder);
        CoffeeOrder Vend();
        void AddFunds(Denomination denomination);
        decimal DispenseChange();
        decimal CompleteOrder();
    }
}
