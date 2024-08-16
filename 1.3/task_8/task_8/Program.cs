/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 16.01.2023
 * Time: 21:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_8
{
	class Program
	{
		public static void Main(string[] args)
		{
			{
			Console.WriteLine("Enter text line and a single word");
			string s1 = Console.ReadLine();
			string s2 = Console.ReadLine();
			char[] razd = " .;,!?".ToCharArray();
			string[] s = s1.Split(razd);
			int num = (int)(s.Length);
			string[] result = new string[num];
			int j = 0;
			if (s[0] == s2) Console.WriteLine("Искомое стоит первым, перед ним нет слов.");
			for (int i = 1; i < s.Length; i++)
			{
				if (s[i] == s2) result[j] = s[i - 1];
				j++;
			}
			Console.WriteLine("Result:");
			for (int i = 0; i < result.Length; i++)
				Console.Write("\t{0}",result[i]);
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		}
	}
}