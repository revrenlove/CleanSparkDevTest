using System;
using System.Drawing;
using System.Windows.Forms;
using CoffeeMachine.Models;
using CoffeeMachine.Service;

namespace CoffeeMachine.Client
{
	public partial class frmMain : Form
	{
		private readonly ITransactionHandler _transactionHandler;
		private readonly ICoffeeOrderHandler _coffeeOrderHandler;

		private readonly CoffeeSize[] _sizes = (CoffeeSize[])Enum.GetValues(typeof(CoffeeSize));

		public frmMain(ITransactionHandler transactionHandler, ICoffeeOrderHandler coffeeOrderHandler)
		{
			_transactionHandler = transactionHandler;
			_coffeeOrderHandler = coffeeOrderHandler;

			InitializeComponent();
			InitialUISetup();
		}

        #region Event Handlers

        private void btnAddCoffee_Click(object sender, EventArgs e)
		{
			var coffeeOrder = _coffeeOrderHandler.PlaceOrder();
			_transactionHandler.AddCoffeeOrder(coffeeOrder);

			UpdateOrder();
			ClearAddCoffeeForm();
			SetStatus();
		}

		private void btnAddPayment_Click(object sender, EventArgs e)
		{
			_transactionHandler.AddFunds((Denomination)cbAmount.SelectedItem);
			UpdateCurrentPayment();
			SetStatus();
		}

		private void btnVend_Click(object sender, EventArgs e)
		{
            try
            {
				var coffeeOrder = _transactionHandler.Vend();

				UpdateCurrentPayment();
				UpdateOrder();
				SetStatus();

				MessageBox.Show(coffeeOrder.ToString(), "Here's your coffee! :)");
			}
			catch(InsufficientFundsException ex)
            {
				SetStatus(ex.Message);
            }
			catch(InvalidOperationException ex)
            {
				SetStatus(ex.Message);
			}			
		}

		private void btnDispenseChange_Click(object sender, EventArgs e)
		{
			if (_transactionHandler.AvailableFunds > 0)
            {
				var change = _transactionHandler.DispenseChange();
				UpdateCurrentPayment();
				SetStatus();

				MessageBox.Show(change.ToString("C"), "Here's your change. :)");
			}
		}

		private void btnComplete_Click(object sender, EventArgs e)
		{
			var change = _transactionHandler.CompleteOrder();

			UpdateCurrentPayment();
			UpdateOrder();
			ClearAddCoffeeForm();
			SetStatus();

			var message = "Have a nice day!";

			if (change > 0)
            {
				message = $"Your change is: {change:C}\n\n{message}";
            }

			MessageBox.Show(message, "Thank you!");
		}

		private void cbSize_SelectedValueChanged(object sender, EventArgs e)
        {
			_coffeeOrderHandler.Size = (CoffeeSize)((ComboBox)sender).SelectedValue;
        }

        private void btnRemoveCream_Click(object sender, EventArgs e)
        {
			UpdateExtra(_coffeeOrderHandler.RemoveExtra, Extra.Cream, lblCreamQty);
		}

        private void btnAddCream_Click(object sender, EventArgs e)
        {
			UpdateExtra(_coffeeOrderHandler.AddExtra, Extra.Cream, lblCreamQty);
		}

        private void btnRemoveSugar_Click(object sender, EventArgs e)
        {
			UpdateExtra(_coffeeOrderHandler.RemoveExtra, Extra.Sugar, lblSugarQty);
		}

        private void btnAddSugar_Click(object sender, EventArgs e)
        {
			UpdateExtra(_coffeeOrderHandler.AddExtra, Extra.Sugar, lblSugarQty);
		}

        #endregion

        private void UpdateExtra(Action<Extra> action, Extra extra, Label label)
        {
            try
            {
				action(extra);

				label.Text = _coffeeOrderHandler.ExtraQtyByExtra[extra].ToString();
				SetStatus();
			}
			catch(InvalidOperationException ex)
            {
				SetStatus(ex.Message);
			}
        }

		private void SetStatus(string text = "")
        {
			toolStripStatusLabel.Text = text;
		}

		private void ClearAddCoffeeForm()
        {
			lblCreamQty.Text = "0";
			lblSugarQty.Text = "0";

			cbSize.SelectedItem = CoffeeSize.Small;
		}

		private void UpdateCurrentPayment()
        {
			lblCurrentPayment.Text = _transactionHandler.AvailableFunds.ToString("C");

			SetPaymentColor();
		}

		private void SetPaymentColor()
        {
			if (_transactionHandler.CoffeeOrder != null &&
				_transactionHandler.CoffeeOrder.Price > _transactionHandler.AvailableFunds)
			{
				lblCurrentPayment.ForeColor = Color.Red;
			}
            else
            {
				lblCurrentPayment.ForeColor = Color.Black;
			}
		}

		private void UpdateOrder()
        {
			if (_transactionHandler.CoffeeOrder is null)
            {
				ClearOrder();
			}
            else
            {
				txtCurrentOrder.Text = _transactionHandler.CoffeeOrder.ToString();
				lblOrderTotal.Text = _transactionHandler.CoffeeOrder.Price.ToString("C");
			}

			SetPaymentColor();
		}

		private void ClearOrder()
        {
			txtCurrentOrder.Text = "";
			lblOrderTotal.Text = 0.ToString("C");
		}

		private void InitialUISetup()
		{
			cbSize.DataSource = Enum.GetValues(typeof(CoffeeSize));
			cbAmount.DataSource = Denomination.GetAll();

			ClearOrder();
			UpdateCurrentPayment();
		}
	}
}
