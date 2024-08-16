/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 14.01.2023
 * Time: 7:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_7
{
	class Program
{
static sbyte[] maximums(sbyte[,] Massive)
{
	sbyte[] Massive1=new sbyte[Massive.GetLength(0)];
	for(sbyte j=0; j<Massive.GetLength(0); j++)
	{
		sbyte max=sbyte.MinValue;
		for (sbyte i=0; i<Massive.GetLength(1); i++)if (Massive[j,i]>max) max=Massive[j,i];
		Massive1[j]=(sbyte)max;
	}
	if (Massive.GetLength(0)>100) throw new Exception("Массив большой");
	return Massive1;
}

static void show (sbyte[,] Massive)
{
	for(sbyte j=0; j<Massive.GetLength(0); j++)
	{
		for (sbyte i=0; i<Massive.GetLength(1); i++)
		{
			Console.Write("\t"+Massive[j,i]);
		}
		Console.WriteLine();
	}
}

static void show (sbyte[] Massive)
{
	foreach (sbyte i in Massive) Console.Write("\t"+i);
	Console.WriteLine();
}
	
static void Main()
{
	const sbyte N = 100;
	int n,m;
	string buf;
	do
	{
		Console.WriteLine("\nEnter n,m (1-" + N + "): ");
		buf = Console.ReadLine();
		n = Convert.ToInt32(buf);
		buf = Console.ReadLine();
		m = Convert.ToInt32(buf);
	}
	while (n <= 0 || m <= 0 || n > N || m > N);
	
	sbyte[,] A = new sbyte[n,m];
	Random r = new Random();
	for(sbyte j=0; j<A.GetLength(0); j++)
	{
		for (sbyte i=0; i<A.GetLength(1); i++)
		{
			A[j,i]=(sbyte)r.Next(sbyte.MinValue,sbyte.MaxValue+1);
		}
	}
	
	Console.WriteLine("Исходный массив:");
	show (A);
	
	try 
	{
		sbyte[] B = maximums(A);
		Console.WriteLine("Result:");
		show(B);
	}
	catch (Exception wtf) {Console.WriteLine(wtf.Message);}
	Console.ReadKey();
}
}
}