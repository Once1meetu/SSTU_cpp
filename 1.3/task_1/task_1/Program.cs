/*
 * Created by SharpDevelop.
 * User: Роман
 * Date: 13.01.2023
 * Time: 22:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGTU_OOP_C_SHARP_2022
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Задание_1.Вывод строки на экран с использованием " +
"\nesp-последовательности.\n ");
//Пункт 1.
Console.WriteLine("1.\nЭто строка,\n\tиначе - \"стринг\",\n\t\tиначе - " +
"\"строковый литерал\"/n");
//Пункт 2.
Console.WriteLine("2.\nЭто звуковой\nсигнал!\a\n");
//Пункт 3.
Console.WriteLine("3.\nЭто строка?\n\"Да!\"\n");
//Пункт 4.
Console.WriteLine("4.\n\" - это двойные кавычки\n\' - это апостроф\n");
//Пункт 5.
Console.WriteLine("5.\nЭто \"строка\"?\nЭто \"строка\"!\b\n");
//Пункт 6.
Console.WriteLine("6.\nЭто строка?\nЭто\rДа строка!\n");
//Пункт 7.
Console.WriteLine("7.\n\\\\Это комментарий?\n//Нет, это комментарий\n");
//Пункт 8.
Console.WriteLine("8.\nC:\\Program Files\\Far\nD\rF:\\Program Files\\Far\n");
//Пункт 9.
Console.WriteLine("9.\n\x426\x435\x43D\x430\x3D\n\x3D\x31\x30\x30\x24\n");
//Пункт 10.
Console.WriteLine("10.\n\u0426\u0435\u043D\u0430\u003D\n\u003D\u0031" +
"\u0030\u0030\u0024");
Console.ReadKey();
}
}
}