/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 14.01.2023
 * Time: 21:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_6
{
	class Program
	{
		static bool f(int k)
		{
			if(k<180.0)return true;
			return false;
		}
		public static void Main(string[] args)
		{
			int[] ROST = new int[70]; 
			Random r= new Random();
			for (int k=0; k<70;k++)
			{
				ROST[k]=(int) r.Next(100,251);
			}
			foreach (int i in ROST) Console.Write("\t"+i);
			Console.WriteLine("\n\n\nResult:");
			int[] NR =Array.FindAll(ROST,f);
 			foreach (int i in NR) Console.Write("\t"+i);
 			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}