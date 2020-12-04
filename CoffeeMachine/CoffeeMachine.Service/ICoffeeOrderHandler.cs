using System.Collections.Generic;
using CoffeeMachine.Models;

namespace CoffeeMachine.Service
{
    public interface ICoffeeOrderHandler
    {
        CoffeeSize Size { get; set; }
        IReadOnlyDictionary<Extra, int> ExtraQtyByExtra { get; }

        void AddExtra(Extra extra);
        void RemoveExtra(Extra extra);
        CoffeeOrder PlaceOrder();
    }
}
