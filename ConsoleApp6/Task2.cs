using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Chainik : Pristri
	{
		public string Characteristics {  get; set; }

		public Chainik(string characteristics, string title, string description) : base(title, description)
		{
			Characteristics = characteristics;
		}

		public override void sound() => Console.WriteLine("SHHHHHHHHHHHHHHHHHHHHHH");

	}

	internal class Microwave : Pristri
	{
		public string Characteristics { get; set; }

		public Microwave(string characteristics, string title,string description) : base(title, description)
		{
			Characteristics = characteristics;
		}

		public override void sound() => Console.WriteLine("UUUUUUUUUUUUUUUUUUUUUUUUUUUU");
	}

	internal class Car : Pristri
	{
		public string Characteristics { get; set; }

		public Car(string characteristics, string title, string description) : base(title, description)
		{
			Characteristics = characteristics;
		}

		public override void sound() => Console.WriteLine("RRRRRRRRRRRRRRRRRRRRRRR");
	}

	internal class Parohod : Pristri
	{
		public string Characteristics { get; set; }

		public Parohod(string characteristics, string title, string description) : base(title, description)
		{
			Characteristics = characteristics;
		}

		public override void sound() => Console.WriteLine("RRRRRRRRRRRRRRRRRRRRRRR");
	}

	
}
