using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using System.IO;

namespace Ekonometria
{
    public partial class Form1 : Form
    {

        private int iloscZmiennych;

        private int iloscWierszy;

        private double[] Y;

        private double[] Ywyliczane;

        private double[][] X_i;

        private double[] R0;

        private double[][] R;

        private double[][] X;

        public class Macierz
        {
            public List<int> Items { get; set; }

            public double H { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            btResult.Enabled = false;
        }

		public Matrix<double> matrix_X(double[,] tablica)
		{
			return Matrix<double>.Build.DenseOfArray(tablica);
		}

		public void get_H(Macierz macierz)
		{
			for (int i = 0; i < macierz.Items.Count; i++)
			{
				double num = 0.0;
				for (int j = 0; j < macierz.Items.Count; j++)
				{
					if (i != j)
					{
						num += Math.Abs(R[macierz.Items[i] - 1][macierz.Items[j] - 1]);
					}
				}
				macierz.H += R0[macierz.Items[i] - 1] * R0[macierz.Items[i] - 1] / (1.0 + num);
			}
		}

		public IEnumerable<IEnumerable<T>> combinationsCount<T>(IEnumerable<T> items, int ilosc)
		{
			int i = 0;
			foreach (T item in items)
			{
				if (ilosc == 1)
				{
					yield return new T[1] { item };
				}
				else
				{
					using IEnumerator<IEnumerable<T>> elem1 = combinationsCount(items.Skip(i + 1), ilosc - 1).GetEnumerator();
					while (elem1.MoveNext())
					{
						yield return Enumerable.Concat(second: elem1.Current, first: new T[1] { item });
					}
				}
				i++;
			}
		}

		private double Correlations(double[] wektor, double[] wektor2)
		{
			double n1 = 0.0;
			double n2 = 0.0;
			double n3 = 0.0;
			for (int i = 0; i < wektor.Count(); i++)
			{
				double n4 = wektor[i] - wektor.Average();
				double n5 = wektor2[i] - wektor2.Average();
				n1 += n4 * n5;
				n2 += n4 * n4;
				n3 += n5 * n5;
			}
			return n1 / Math.Sqrt(n2 * n3);
		}

		private void btFile_Click(object sender, EventArgs e)
		{
			Stream stream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			if ((stream = openFileDialog.OpenFile()) != null)
			{
				using (StreamReader streamReader = new StreamReader(stream))
				{
					textBoxDane.Text = streamReader.ReadToEnd();
					return;
				}
			}

		}

		private void textBoxDane_TextChanged(object sender, EventArgs e)
        {
			bool isValid = true;
			string[] wiersze = textBoxDane.Lines;
			iloscWierszy = wiersze.Where((string x) => x.Length > 0).Count();
			List<List<string>> tekst = (from x in wiersze where x.Length > 0 select x.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList()).ToList();
			if (tekst.Any())
			{
				iloscZmiennych = tekst.FirstOrDefault().Count - 1;
			}
			if (tekst.Any((List<string> x) => x.Count() != tekst.FirstOrDefault().Count()))
			{
				isValid = false;
			}
			if (iloscZmiennych < 1)
			{
				isValid = false;
			}
			if (tekst.Count() == 0)
			{
				isValid = false;
			}
			if (isValid)
			{
				Y = new double[iloscWierszy];
				X_i = new double[iloscZmiennych][];
				List<int> list = new List<int>();
				for (int i = 0; i < X_i.Length; i++)
				{
					X_i[i] = new double[iloscWierszy];
				}
				for (int j = 0; j < tekst.Count(); j++)
				{
					for (int k = 0; k < tekst[j].Count; k++)
					{
						double result = 0.0;
						if (double.TryParse(tekst[j][k].Replace('.', ','), out result))
						{
							if (k == 0)
							{
								Y[j] = result;
							}
							else
							{
								X_i[k - 1][j] = result;
							}
						}
						else
						{
							isValid = false;
						}
					}
				}
			}
			if (isValid)
			{
				labelVal.Text = "Dane poprawne";
				btResult.Enabled = true;
			}
			else
			{
				labelVal.Text = "Zły format danych";
				btResult.Enabled = false;
			}
		}


        private void btResult_Click(object sender, EventArgs e)
        {
			// Wektor i macierz korelacji
			R0 = new double[iloscZmiennych];
			R = new double[iloscZmiennych][];
			for (int i = 0; i < iloscZmiennych; i++)
			{
				R0[i] = Correlations(Y, X_i[i]);
			}
			for (int j = 0; j < iloscZmiennych; j++)
			{
				R[j] = new double[iloscZmiennych];
				for (int k = 0; k < iloscZmiennych; k++)
				{
					R[j][k] = Correlations(X_i[j], X_i[k]);
				}
			}
			labelR0.Text = "";
			for (int i1 = 0; i1 < iloscZmiennych; i1++)
			{
				Label label2 = labelR0;
				label2.Text = label2.Text + $"{R0[i1]:0.0000}" + "\n";
			}
			labelR.Text = "";
			for (int i2 = 0; i2 < iloscZmiennych; i2++)
			{
				for (int j2 = 0; j2 < iloscZmiennych; j2++)
				{
					if (R[i2][j2] >= 0.0)
					{
						labelR.Text += " ";
					}
					labelR.Text += $"{R[i2][j2]:0.0000}";
					labelR.Text += "  ";
				}
				labelR.Text += "\n";
			}
			//ilość kombinacji dla zmiennych, H
			Macierz[] array = new Macierz[(int)Math.Pow(2.0, iloscZmiennych) - 1];
			List<int> list = new List<int>();
			for (int l = 0; l < iloscZmiennych; l++)
			{
				list.Add(l + 1);
			}
			int n1 = 0;
			for (int m = 0; m < iloscZmiennych; m++)
			{
				IEnumerable<IEnumerable<int>> enumerable = combinationsCount(list, m + 1);
				foreach (IEnumerable<int> item in enumerable)
				{
					array[n1] = new Macierz();
					array[n1].Items = item.ToList();
					get_H(array[n1]);
					n1++;
				}
			}
			Macierz macierz = array.OrderByDescending((Macierz x) => x.H).FirstOrDefault();
			X = new double[macierz.Items.Count + 1][];
			for (int n = 0; n < macierz.Items.Count; n++)
			{
				X[n] = new double[iloscZmiennych];
				X[n] = X_i[macierz.Items[n] - 1];
			}
			X[macierz.Items.Count] = new double[iloscWierszy];
			for (int n2 = 0; n2 < iloscWierszy; n2++)
			{
				X[macierz.Items.Count][n2] = 1.0;
			}
			labelZmienne.Text = "Zmienne:  ";
			foreach (int item in macierz.Items)
			{
				Label label = labelZmienne;
				label.Text = label.Text + "x" + item + ", ";
			}
			//szacowanie D(a)
			Matrix<double> matrix = Matrix<double>.Build.DenseOfColumnArrays(X);
			Vector<double> one = Vector<double>.Build.DenseOfArray(Y);
			Matrix<double> matrix2 = Matrix<double>.Build.DenseOfColumnArrays(Y);
			int count = 0;
			foreach (int item in macierz.Items)
			{
				count++;
			}
			Vector<double> vector = matrix.Transpose().Multiply(matrix).Inverse().Multiply(matrix.Transpose().Multiply(one));
			Matrix<double> other = Matrix<double>.Build.DenseOfColumnVectors(vector);
			Matrix<double> matrix3 = 1.0 / (double)(iloscWierszy - (count + 1)) * (matrix2.Transpose().Multiply(matrix2) - matrix2.Transpose().Multiply(matrix).Multiply(other));
			Matrix<double> matrix4 = matrix3[0, 0] * (matrix.Transpose() * matrix).Inverse();
			double[] array2 = new double[matrix4.RowCount];
			for (int n3 = 0; n3 < matrix4.RowCount; n3++)
			{
				array2[n3] = Math.Sqrt(matrix4[n3, n3]);
			}
			for (int n4 = 0; n4 < array2.Length; n4++)
			{
				Label label = labelD;
				label.Text = label.Text + "D(a" + (n4 + 1) + ") = " + $"{array2[n4]:0.0000}" + "\n";
			}
			labelEDa.Text = "Oszacowane błędy:     ";
			for (int n8 = 0; n8 < array2.Length; n8++)
			{
				labelEDa.Text += "(";
				labelEDa.Text += $"{array2[n8]:0.0000}";
				labelEDa.Text += ")    ";
			}
			//odchylenie, los
			double odch = Math.Sqrt(matrix3[0, 0]);
			double los = odch / Y.Average();
			labelLos.Text = "Współczynnik zmienności losowej:  " + $"{los:0.0000}";
			Ywyliczane = new double[iloscWierszy];
			for (int n5 = 0; n5 < iloscWierszy; n5++)
			{
				for (int n6 = 0; n6 < macierz.Items.Count; n6++)
				{
					Ywyliczane[n5] += vector[n6] * X_i[macierz.Items[n6] - 1][n5];
				}
				Ywyliczane[n5] += vector.Last();
			}
			double first = 0.0;
			double second = 0.0;
			for (int n7 = 0; n7 < iloscWierszy; n7++)
			{
				first += (Ywyliczane[n7] - Y.Average()) * (Ywyliczane[n7] - Y.Average());
				second += (Y[n7] - Y.Average()) * (Y[n7] - Y.Average());
			}
			//rownanie
			labelRownanie.Text = "Równanie modelu: Y = ";
			for (int r = 0; r < vector.Count; r++)
			{
				Label label = labelRownanie;
				label.Text = label.Text + $"{vector[r]:0.0000}" + "x" + macierz.Items[r] + " + ";
				if (r == vector.Count - 2)
				{
					r++;
					labelRownanie.Text += $"{vector[r]:0.0000}";
				}
			}
			///labels

			labelDet.Text = "Współczynnik determinacji:  " + $"{(first / second):0.0000}";
			labelOdchylenie.Text = "Odchylenie standardowe składnika resztowego:  " + $"{odch:0.0000}";

		}

    }
}
