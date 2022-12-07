using System;
using System.Windows.Forms;

namespace Ex1_Forms {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void CalculateButton_Click(object sender, EventArgs e) {
			double a = .0, b = .0;
			double h = .0;

			try {
				a = double.Parse(ATextBox.Text);

				b = double.Parse(BTextBox.Text);

				h = double.Parse(HTextBox.Text);

				if (h == .0) throw new Exception("введите шаг отличный от нуля!");
				if (a > b) throw new Exception("начальное значение интервала не может превышать конечное!");
				if (h < 0) throw new Exception("введите положительный шаг!");
			}
			catch (FormatException) {
				ResultTextBox.Text = "Ошибка: ожидается ввод чисел в поля интервала и шага";
				return;
			}
			catch (ArgumentNullException) {
				ResultTextBox.Text = "Ошибка: ожидается ввод чисел в поля интервала и шага";
				return;
			}
			catch (Exception ex) {
				ResultTextBox.Text = $"Ошибка: {ex.Message}";
				return;
			}

			ResultTextBox.Clear();
			ResultTextBox.Text = $"Результат вычисления функции по интервалу [{a}, {b}] с шагом {h}:\n";
			ResultTextBox.Text += "\t\tx\ty (округлено до 3-х знаков после запятой)\n";

			for (double i = a; i <= b; i += h) {
				try {
					ResultTextBox.Text += $"\t\t{i}\t{Math.Round(f(i), 3)}\n";
				}
				catch (NotFiniteNumberException ex) {
					ResultTextBox.Text += $"\t\t{i}\t{ex.Message}\n";
				}
			}
		}
		private double f(double x) {
			double y = Math.Log(Math.Pow(x, 4) - 1) * Math.Log(1 + x);

			if (double.IsNaN(y)) throw new NotFiniteNumberException("y не существует в данной точке");
			if (double.IsPositiveInfinity(y)) throw new NotFiniteNumberException("Положительная бесконечность");
			if (double.IsNegativeInfinity(y)) throw new NotFiniteNumberException("Отрицательная бесконечность");

			return y;
		}
	}
}
