/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 13.01.2023
 * Time: 22:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("task_1");
			Console.WriteLine("sizeof(bool)={0}\n",sizeof(bool));
			Console.WriteLine("sizeof(char)={0}\n",sizeof(char));
			Console.WriteLine("sizeof(char)={0}\n",sizeof(char));
			Console.WriteLine("sizeof(byte)={0}\n",sizeof(byte));
			Console.WriteLine("sizeof(int)={0}\n",sizeof(int));
			Console.WriteLine("sizeof(uint)={0}\n",sizeof(uint));
			Console.WriteLine("sizeof(short)={0}\n",sizeof(short));
			Console.WriteLine("sizeof(ushort)={0}\n",sizeof(ushort));
			Console.WriteLine("sizeof(long)={0}\n",sizeof(long));
			Console.WriteLine("sizeof(ulong)={0}\n",sizeof(ulong));
			Console.WriteLine("sizeof(float)={0}\n",sizeof(float));
			Console.WriteLine("sizeof(double)={0}\n",sizeof(double));
			Console.WriteLine("sizeof(decimal)={0}\n",sizeof(decimal));
			Console.WriteLine("task_2");
			int a=10,b=3;
			Console.WriteLine("{0}\n",(double)a/(double)b);
			Console.WriteLine("task_3");
			Random r = new Random();
			char c = (char)r.Next('A', 'z');
			Console.WriteLine("{0} {1} {2}",(char)(c-1),c,(char)(c+1));

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}