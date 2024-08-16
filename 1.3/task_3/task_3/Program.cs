/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 13.01.2023
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string s;
			double d;
			Console.WriteLine("Enter real number");
			s=Console.ReadLine();
			d=double.Parse(s);
			Console.WriteLine("Enter string");
			s=Console.ReadLine();
			Console.Clear();
			Console.BackgroundColor=ConsoleColor.DarkCyan; 
			Console.WindowHeight=Convert.ToInt32(4.0/3.0*Console.WindowHeight);
			DateTime my_date=DateTime.Now;
			Console.WriteLine("{0:F}",my_date);
			Console.SetCursorPosition(0,Console.WindowHeight/2);
			Console.WriteLine("{0}=",s);
			Console.SetCursorPosition(Console.WindowWidth/2,Console.WindowHeight/2);
			Console.WriteLine("{0:F2}",d);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}