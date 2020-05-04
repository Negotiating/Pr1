using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_1_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calculate_Click(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(side.Text);
			if (a > 0)
			{
				double r = a / (2 * Math.Sqrt(3));
				result.Text = r.ToString();
			}
		}

		private void side_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}

		private void check_Click(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(SideA.Text);
			double b = Convert.ToDouble(SideB.Text);
			double c = Convert.ToDouble(SideC.Text);
			if ((a + b > c) && (a + c > b) && (b + c > a) && (a > 0) && (b > 0) && (c > 0))
				rezult.Text = "Треугольник существует!";
			else rezult.Text = "Треугольник не существует!";
		}

		private void SideA_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}

		private void SideB_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}

		private void SideC_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number))
			{
				e.Handled = true;
			}
		}
	}
}
