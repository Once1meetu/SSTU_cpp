/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 14.01.2023
 * Time: 2:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Найдём корни квадратного уравнения ах^2+bx+c=0. Введите коэффициенты. ");
			Console.Write("a=");
			string s;
			double a,b,c,d;
			a=b=c=d=0;
			try
			{
				s=Console.ReadLine();
				a=double.Parse(s);
				Console.Write("b=");
				s=Console.ReadLine();
				b=double.Parse(s);
				Console.Write("c=");
				s=Console.ReadLine();
				c=double.Parse(s);
			}
			catch(FormatException){Console.WriteLine("Нужны числа, а не буквы/знаки");}
			d=Math.Sqrt(b*b-4.0f*a*c);
			try
			{
				if (double.IsNaN(d)) throw new Exception("Действительных корней нет.");
				Console.WriteLine("х1={0},x2={1}",-b+d/(2.0f*a),-b-d/(2.0f*a));
			}
			catch(ArithmeticException){Console.WriteLine("Уравнение не квадратное.");}
			catch(Exception exc){Console.WriteLine(exc.Message);}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}