using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6 
{
	internal class Product : Money
	{
		public string Title { get; set; }

		public Product(int firstPrice, int secondPrice, string firstValueName, string secondValueName, string title) 
			: base(firstPrice, secondPrice, firstValueName, secondValueName)
		{
			Title = title;
		}

		public void changePrice(int price1, int price2)
		{
			FirstPrice = price1;
			SecondPrice = price2;
		}

		public void printPrice()
		{
			Console.WriteLine($"Price: {FirstPrice} {FirstValueName} {SecondPrice} {SecondValueName}");
		}
	}
}
