/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 18.01.2023
 * Time: 19:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace task_9
{
	class Program
	{
		class Polynomial
          {
            private readonly double[] _coefficients;
    
            public Polynomial()
            {
                _coefficients = null;
            }
 
            public Polynomial(params double[] coefficients)
            {
                _coefficients = coefficients;
            }
 
           /* public Polynomial(params float[] coefficients)
            {
            	for(int i=0;i<coefficients.Length;i++)
            	{
            		_coefficients[i] = (double)coefficients[i];
            	}
            }
            */
           
           
            public double this[int n]
            {
                get { return _coefficients[n]; }
                set { _coefficients[n] = value; }
            }

            public int Order
            {
                get { return _coefficients.Length; }
            }
 
            public override string ToString()
            {
                return string.Format("Coefficients:*" + string.Join(";*", _coefficients));
            }

            public static Polynomial operator +(Polynomial pFirst, Polynomial pSecond)
            {
                int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
                var result = new double[itemsCount];
                for (int i = 0; i < itemsCount; i++)
                {
                    double a = 0;
                    double b = 0;
                    if (i < pFirst._coefficients.Length)
                    {
                        a = pFirst[i];
                    }
                    if (i < pSecond._coefficients.Length)
                    {
                        b = pSecond[i];
                    }
                    result[i] = a + b;
                }
                return new Polynomial(result);
            }
  
        static void Main(string[] args)
        {
            Polynomial p1 = new Polynomial(2, 1);
            Polynomial p2 = new Polynomial(4, 3, 2, 1);
            Console.WriteLine(p1 + p2);
            Console.ReadLine();
        }
	}
	}}