using System;
using CoffeeMachine.Models;

namespace CoffeeMachine.Service
{
    public class TransactionHandler : ITransactionHandler
    {
        private decimal _availableFunds;
        private CoffeeOrder _coffeeOrder;

        public decimal AvailableFunds => _availableFunds;

        public CoffeeOrder CoffeeOrder => _coffeeOrder;

        public void AddCoffeeOrder(CoffeeOrder coffeeOrder)
        {
            if (coffeeOrder is null)
            {
                throw new ArgumentNullException(nameof(coffeeOrder));
            }

            _coffeeOrder = coffeeOrder;
        }

        public void AddFunds(Denomination denomination)
        {
            if (denomination is null)
            {
                throw new ArgumentNullException(nameof(denomination));
            }

            _availableFunds += denomination.Value;
        }

        public decimal DispenseChange()
        {
            var change = _availableFunds;

            _availableFunds = 0;

            return change;
        }

        public CoffeeOrder Vend()
        {
            if (_coffeeOrder is null)
            {
                throw new InvalidOperationException("No coffee order placed.");
            }

            if (_availableFunds < _coffeeOrder.Price)
            {
                throw new InsufficientFundsException(_availableFunds, _coffeeOrder.Price);
            }

            _availableFunds -= _coffeeOrder.Price;

            var coffeeOrder = _coffeeOrder;

            _coffeeOrder = null;

            return coffeeOrder;
        }

        public decimal CompleteOrder()
        {
            _coffeeOrder = null;

            return DispenseChange();
        }
    }
}
