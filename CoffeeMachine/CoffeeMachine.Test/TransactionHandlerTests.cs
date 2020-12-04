using System;
using CoffeeMachine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachine.Service.Test
{
    [TestClass]
    public class TransactionHandlerTests
    {
        private readonly ITransactionHandler _transactionHandler;
        private readonly Random _rnd;

        public TransactionHandlerTests()
        {
            _transactionHandler = new TransactionHandler();
            _rnd = new Random();
        }

        [TestMethod]
        public void AddCoffeeOrder_WhenNoCoffeeOrderInTransactionHandler_AddsCoffeeOrder()
        {
            var coffeeOrder = CreateCoffeeOrder();

            _transactionHandler.AddCoffeeOrder(coffeeOrder);

            Assert.AreEqual(coffeeOrder, _transactionHandler.CoffeeOrder);
        }

        [TestMethod]
        public void AddCoffeeOrder_WhenCoffeeOrderInTransactionHandler_ReplacesCoffeeOrder()
        {
            var coffeeOrder = CreateCoffeeOrder();

            _transactionHandler.AddCoffeeOrder(coffeeOrder);

            var newCoffeeOrder = CreateCoffeeOrder();

            _transactionHandler.AddCoffeeOrder(newCoffeeOrder);

            Assert.AreEqual(newCoffeeOrder, _transactionHandler.CoffeeOrder);
            Assert.AreNotEqual(coffeeOrder, _transactionHandler.CoffeeOrder);
        }

        [TestMethod]
        public void AddCoffeeOrder_WhenCoffeeOrderIsNull_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _transactionHandler.AddCoffeeOrder(null);
            });
        }

        [TestMethod]
        public void Vend_WhenCoffeeOrderInTransactionHandlerAndSufficientFunds_ReturnsCoffeeOrder()
        {
            var coffeeOrder = CreateCoffeeOrder();

            _transactionHandler.AddCoffeeOrder(coffeeOrder);
            _transactionHandler.AddFunds(Denomination.Twenty);

            var vendedCoffeeOrder = _transactionHandler.Vend();

            Assert.AreEqual(coffeeOrder, vendedCoffeeOrder);
        }

        [TestMethod]
        public void Vend_WhenCoffeeOrderInTransactionHandlerAndSufficientFunds_NullsCoffeeOrder()
        {
            var coffeeOrder = CreateCoffeeOrder();

            _transactionHandler.AddCoffeeOrder(coffeeOrder);
            _transactionHandler.AddFunds(Denomination.Twenty);

            _transactionHandler.Vend();

            Assert.IsNull(_transactionHandler.CoffeeOrder);
        }

        [TestMethod]
        public void Vend_WhenCoffeeOrderInTransactionHandlerAndSufficientFunds_DeductsFromAvailableFunds()
        {
            var coffeeOrder = CreateCoffeeOrder();

            _transactionHandler.AddCoffeeOrder(coffeeOrder);
            _transactionHandler.AddFunds(Denomination.Twenty);

            var expectedAvailableFunds = _transactionHandler.AvailableFunds - coffeeOrder.Price;

            _transactionHandler.Vend();

            Assert.AreEqual(expectedAvailableFunds, _transactionHandler.AvailableFunds);
        }

        [TestMethod]
        public void Vend_WhenCoffeeOrderInTransactionHandlerAndInsufficientFunds_ThrowsInsufficientFundsException()
        {
            var coffeeOrder = CreateCoffeeOrder();

            _transactionHandler.AddCoffeeOrder(coffeeOrder);

            Assert.ThrowsException<InsufficientFundsException>(() =>
            {
                _transactionHandler.Vend();
            });
        }

        [TestMethod]
        public void Vend_WhenCoffeeOrderNotInTransactionHandler_ThrowsInvalidOperationException()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _transactionHandler.Vend();
            });
        }

        [TestMethod]
        public void AddFunds_DenominationNotNull_UpdatesAvailableFunds()
        {
            foreach (var denomination in Denomination.GetAll())
            {
                AddRandomFunds();

                var originalFunds = _transactionHandler.AvailableFunds;

                _transactionHandler.AddFunds(denomination);

                var priceDifference = _transactionHandler.AvailableFunds - originalFunds;

                Assert.AreEqual(denomination.Value, priceDifference);

                _transactionHandler.CompleteOrder();
            }
        }

        [TestMethod]
        public void AddFunds_DenominationIsNull_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _transactionHandler.AddFunds(null);
            });
        }

        [TestMethod]
        public void DispenseChange_ReturnsAvailableFunds()
        {
            AddRandomFunds();

            var expectedChange = _transactionHandler.AvailableFunds;

            var actualChange = _transactionHandler.DispenseChange();

            Assert.AreEqual(expectedChange, actualChange);
        }

        [TestMethod]
        public void DispenseChange_ResetsAvailableFunds()
        {
            AddRandomFunds();
            
            _transactionHandler.DispenseChange();

            Assert.AreEqual(0, _transactionHandler.AvailableFunds);
        }

        [TestMethod]
        public void CompleteOrder_ReturnsAvailableFunds()
        {
            AddRandomFunds();

            var expectedChange = _transactionHandler.AvailableFunds;

            var actualChange = _transactionHandler.CompleteOrder();

            Assert.AreEqual(expectedChange, actualChange);
        }

        [TestMethod]
        public void CompleteOrder_ResetsAvailableFunds()
        {
            AddRandomFunds();

            _transactionHandler.CompleteOrder();

            Assert.AreEqual(0, _transactionHandler.AvailableFunds);
        }

        [TestMethod]
        public void CompleteOrder_NullsCoffeeOrder()
        {
            AddRandomFunds();

            _transactionHandler.CompleteOrder();

            Assert.IsNull(_transactionHandler.CoffeeOrder);
        }

        private CoffeeOrder CreateCoffeeOrder()
        {
            var sizes = Enum.GetValues(typeof(CoffeeSize));
            var size = (CoffeeSize)sizes.GetValue(_rnd.Next(sizes.Length));

            var creamQty = _rnd.Next(5);
            var sugarQty = _rnd.Next(5);
            var price = _rnd.Next(1, 5);

            var coffeeOrder = new CoffeeOrder(size.ToString(), creamQty, sugarQty, price);

            return coffeeOrder;
        }

        private void AddRandomFunds(decimal minimum = 10)
        {
            var denominationAddQty = _rnd.Next(1, 10);

            for (int i = 0; i < denominationAddQty || _transactionHandler.AvailableFunds < minimum; i++)
            {
                var denominations = Denomination.GetAll();

                var denominationQty = denominations.Count;

                var index = _rnd.Next(denominationQty);

                var denomination = denominations[index];

                _transactionHandler.AddFunds(denomination);
            }
        }
    }
}
