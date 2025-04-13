using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal abstract class Worker
	{
		protected string Name { get; set; }

		protected int Age { get; set; }

		protected string Desctiption = " "; 

		protected Worker(string name, int age, string description)
		{
			Name = name;
			Age = age;
			Desctiption = description;
			
		}


		public virtual void Print() => Console.WriteLine($"Name: {Name}\nAge: {Age}\nPosada:\nDescription: {Desctiption}");
	}

	internal class President : Worker
	{

		public President(string name, int age, string description) : base(name, age, description)
		{

		}
		public override void Print() => Console.WriteLine($"Name: {Name}\nAge: {Age}\nPosada: President\nDescription: {Desctiption}"); 
	}

	internal class Security : Worker
	{

		public Security(string name, int age, string description) : base(name, age, description)
		{

		}
		public override void Print() => Console.WriteLine($"Name: {Name}\nAge: {Age}\nPosada: Security\nDescription: {Desctiption}");
	}

	internal class Manager : Worker
	{

		public Manager(string name, int age, string description) : base(name, age, description)
		{

		}
		public override void Print() => Console.WriteLine($"Name: {Name}\nAge: {Age}\nPosada: Manager\nDescription: {Desctiption}");
	}

	internal class Engineer : Worker
	{

		public Engineer(string name, int age, string description) : base(name, age, description)
		{

		}
		public override void Print() => Console.WriteLine($"Name: {Name}\nAge: {Age}\nPosada: Engineer\nDescription: {Desctiption}");
	}
}
