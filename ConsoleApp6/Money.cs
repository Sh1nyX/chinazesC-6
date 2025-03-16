using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Money
	{
		protected int FirstPrice {  get; set; }
		protected int SecondPrice { get; set; }
		protected string FirstValueName {  get; set; }
		protected string SecondValueName { get; set; }

		protected Money(int firstPrice, int secondPrice, string firstValueName, string secondValueName)
		{
			FirstPrice = firstPrice;
			SecondPrice = secondPrice;
			FirstValueName = firstValueName;
			SecondValueName = secondValueName;
		}
	}
}
