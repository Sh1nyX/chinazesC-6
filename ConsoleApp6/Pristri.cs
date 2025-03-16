using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Pristri
	{
		protected string Title { get; set; }



		protected string Description { get; set; }

		protected Pristri(string title, string description)
		{ 
			Title = title;
			Description = description;
		}

		public virtual void sound() => Console.WriteLine("...");

		public virtual void show() => Console.WriteLine("...");

		public virtual void desc() => Console.WriteLine("...");
	}
}
