using System;
using System.IO;
using System.Windows.Forms;
using CoffeeMachine.Models;
using CoffeeMachine.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeMachine.Client
{
    static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var serviceProvider = ConfigureServices();
			var frmMain = serviceProvider.GetService<frmMain>();

			Application.Run(frmMain);
		}

		static IServiceProvider ConfigureServices()
		{
			var services = new ServiceCollection();

			var path = Path.Combine(Directory.GetCurrentDirectory(), "coffee-machine-configuration.json");
			var config = new CoffeeMachineConfiguration(path);

			services
				.AddSingleton(config)
				.AddSingleton<frmMain>()
				.AddTransient<ITransactionHandler, TransactionHandler>()
				.AddTransient<ICoffeeOrderHandler, CoffeeOrderHandler>();

			return services.BuildServiceProvider();
		}
	}
}
