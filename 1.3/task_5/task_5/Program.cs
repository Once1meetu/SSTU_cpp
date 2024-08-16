/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 14.01.2023
 * Time: 3:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_5
{
	class Program
	{
		static double logarifmiruem(double x, double y)
		{
			if (x==1) throw new Exception ("Основание логарифма 1. Это не имеет смысла.");
			if (x<=0) throw new Exception ("Ошибка! Основание логарифма неположительное.");
			if (y<0) throw new Exception ("Ошибка! Ищем логарифм неположительного числа.");
			return Math.Log(x,y);
		}
		public static void Main(string[] args)
		{
			string s;
			double a,b; a=b=0;
			Console.WriteLine("Логарифмируем. Введите основание логарифма.");
			s=Console.ReadLine();
			a=double.Parse(s);
			Console.WriteLine("Укажите, для какого числа ищем логарифм.");
			s=Console.ReadLine();
			b=double.Parse(s);
			try{Console.WriteLine("log({0},{1})={2}",b,a,logarifmiruem(b,a));}
			catch(Exception what){Console.WriteLine(what.Message);}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}