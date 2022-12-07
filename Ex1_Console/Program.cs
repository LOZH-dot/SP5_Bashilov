using System;

namespace Ex1_Console {
	class Program {
		static void Main(string[] args) {
			double a = .0, b = .0;
			double h = .0;

			while (true) {
				try {
					Console.Write("Введите начальное значение интервала: ");
					a = double.Parse(Console.ReadLine());

					Console.Write("Введите конечное значение интервала: ");
					b = double.Parse(Console.ReadLine());

					Console.Write("Введите шаг функции: ");
					h = double.Parse(Console.ReadLine());

					if (h == .0) throw new Exception("Введите шаг отличный от нуля!");
					if (a > b) throw new Exception("Начальное значение интервала не может превышать конечное!");
					if (h < 0) throw new Exception("Введите положительный шаг!");

					break;
				}
				catch (FormatException) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Ошибка: ");
					Console.ResetColor();
					Console.WriteLine("Ожидается ввод числа!");
				}
				catch (Exception ex) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Ошибка: ");
					Console.ResetColor();
					Console.WriteLine(ex.Message);
				}
			}

			Console.WriteLine($"Результат вычисления функции по интервалу [{a}, {b}] с шагом {h}:");
			Console.WriteLine("\t\tx\ty (округлено до 3-х знаков после запятой)");

			for (double i = a; i <= b; i += h) {
				try {
					Console.WriteLine($"\t\t{i}\t{Math.Round(f(i), 3)}");
				}
				catch (NotFiniteNumberException ex) {
					Console.WriteLine($"\t\t{i}\t{ex.Message}");
				}
			}

		}

		static double f(double x) {
			double y = Math.Log(Math.Pow(x, 4) - 1) * Math.Log(1 + x);

			if (double.IsNaN(y)) throw new NotFiniteNumberException("y не существует в данной точке");
			if (double.IsPositiveInfinity(y)) throw new NotFiniteNumberException("Положительная бесконечность");
			if (double.IsNegativeInfinity(y)) throw new NotFiniteNumberException("Отрицательная бесконечность");

			return y;
		}
	}
}
