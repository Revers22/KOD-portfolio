using System;

namespace Homework_three
{
	class Program
	{
		static void Main()
		{
			// Задание 1
			Console.WriteLine("Введите температуру в градусах Цельсия: ");
			double cel = double.Parse(Console.ReadLine());
			double res = cel * 9 / 5 + 32;
			Console.WriteLine("Температура в градусах Фаренгейта: ");
			Console.WriteLine(res);
			Console.WriteLine("=======================");

			//Задание 2
			Console.Write("Введите первое число: ");
			double num1 = double.Parse(Console.ReadLine());
			Console.Write("Введите второе число: ");
			double num2 = double.Parse(Console.ReadLine());
			Console.Write("Введите третье число: ");
			double num3 = double.Parse(Console.ReadLine());

			double average = (num1 + num2 + num3) / 3;
			Console.WriteLine("Среднее арифметическое чисел равно:");
			Console.WriteLine(average);
			Console.WriteLine("=======================");

			//Задание 3
			Console.WriteLine("Введите первое число: ");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число: ");
			double b = double.Parse(Console.ReadLine());

			Console.WriteLine("Сумма:");
			Console.WriteLine(a + b);
			Console.WriteLine("Разность:");
			Console.WriteLine(a - b);
			Console.WriteLine("Произведение:");
			Console.WriteLine(a * b);

			if (b != 0)
			{
				Console.WriteLine("частное: ");
				Console.WriteLine(a / b);
			}
			else
			{
				Console.WriteLine("Ошибка.");
			}
		}
	}
}
