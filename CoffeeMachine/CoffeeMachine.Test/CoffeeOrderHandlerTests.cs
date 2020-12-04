using System;
using System.IO;
using CoffeeMachine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachine.Service.Test
{
    [TestClass]
    public class CoffeeOrderHandlerTests
    {
        private const string ConfigFileName = "coffee-machine-configuration.json";

        private readonly CoffeeMachineConfiguration _config;
        private readonly ICoffeeOrderHandler _coffeeOrderHandler;
        private readonly Random _rnd;

        public CoffeeOrderHandlerTests()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), ConfigFileName);

            _config = new CoffeeMachineConfiguration(path);
            _coffeeOrderHandler = new CoffeeOrderHandler(_config);
            _rnd = new Random();
        }

        [DataTestMethod]
        [DataRow(Extra.Cream)]
        [DataRow(Extra.Sugar)]
        public void Constructor_InitializesExtraQtyByExtra(Extra extra)
        {
            Assert.IsTrue(_coffeeOrderHandler.ExtraQtyByExtra[extra] == 0);
        }

        [DataTestMethod]
        [DataRow(Extra.Cream)]
        [DataRow(Extra.Sugar)]
        public void AddExtra_WhenLessThanMaxQty_UpdatesExtraQtyByExtra(Extra extra)
        {
            var expectedQty = _coffeeOrderHandler.ExtraQtyByExtra[extra] + 1;

            _coffeeOrderHandler.AddExtra(extra);

            var actualQty = _coffeeOrderHandler.ExtraQtyByExtra[extra];

            Assert.AreEqual(expectedQty, actualQty);
        }

        [DataTestMethod]
        [DataRow(Extra.Cream)]
        [DataRow(Extra.Sugar)]
        public void AddExtra_WhenMaxQty_ThrowsInvalidOperationException(Extra extra)
        {
            MaxOutExtra(extra);

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _coffeeOrderHandler.AddExtra(extra);
            });
        }

        [DataTestMethod]
        [DataRow(Extra.Cream)]
        [DataRow(Extra.Sugar)]
        public void RemoveExtra_WhenGreaterThanZero_UpdatesExtraQtyByExtra(Extra extra)
        {
            MaxOutExtra(extra);

            var expectedQty = _coffeeOrderHandler.ExtraQtyByExtra[extra] - 1;

            _coffeeOrderHandler.RemoveExtra(extra);

            var actualQty = _coffeeOrderHandler.ExtraQtyByExtra[extra];

            Assert.AreEqual(expectedQty, actualQty);
        }

        [DataTestMethod]
        [DataRow(Extra.Cream)]
        [DataRow(Extra.Sugar)]
        public void RemoveExtra_WhenZeroQty_ThrowsInvalidOperationException(Extra extra)
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _coffeeOrderHandler.RemoveExtra(extra);
            });
        }

        [DataTestMethod]
        [DataRow(CoffeeSize.Large, 2, 1)]
        [DataRow(CoffeeSize.Medium, 0, 3)]
        [DataRow(CoffeeSize.Small, 1, 0)]
        public void PlaceOrder_ReturnsCoffeeOrder(CoffeeSize size, int creamQty, int sugarQty)
        {
            _coffeeOrderHandler.Size = size;

            AddExtra(Extra.Cream, creamQty);
            AddExtra(Extra.Sugar, sugarQty);

            var coffeeOrder = _coffeeOrderHandler.PlaceOrder();

            Assert.AreEqual(size.ToString(), coffeeOrder.Size);
            Assert.AreEqual(creamQty, coffeeOrder.CreamQty);
            Assert.AreEqual(sugarQty, coffeeOrder.SugarQty);
        }

        [TestMethod]
        public void PlaceOrder_ResetsCoffeeOrderHandler()
        {
            AddRandomExtra(Extra.Cream);
            AddRandomExtra(Extra.Sugar);

            _coffeeOrderHandler.Size = CoffeeSize.Large;

            _coffeeOrderHandler.PlaceOrder();

            var freshCoffeeOrderHandler = new CoffeeOrderHandler(_config);

            Assert.AreEqual(freshCoffeeOrderHandler.Size, _coffeeOrderHandler.Size);
            Assert.AreEqual(freshCoffeeOrderHandler.ExtraQtyByExtra[Extra.Cream], _coffeeOrderHandler.ExtraQtyByExtra[Extra.Cream]);
            Assert.AreEqual(freshCoffeeOrderHandler.ExtraQtyByExtra[Extra.Sugar], _coffeeOrderHandler.ExtraQtyByExtra[Extra.Sugar]);
        }

        private void MaxOutExtra(Extra extra)
        {
            var maxQty = _config.Extras[extra].MaxQty;

            while (_coffeeOrderHandler.ExtraQtyByExtra[extra] < maxQty)
            {
                _coffeeOrderHandler.AddExtra(extra);
            }
        }

        private void AddRandomExtra(Extra extra)
        {
            var maxQty = _config.Extras[extra].MaxQty;
            var qty = _rnd.Next(maxQty);

            for (int i = 0; i < qty; i++)
            {
                _coffeeOrderHandler.AddExtra(extra);
            }
        }

        private void AddExtra(Extra extra, int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                _coffeeOrderHandler.AddExtra(extra);
            }
        }
    }
}
