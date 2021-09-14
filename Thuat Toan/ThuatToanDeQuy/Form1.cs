using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuatToanDeQuy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double Layn()
		{
			double n = double.Parse(this.txt_Nhap.Text);
			if (n < 0)
			{
				n = 0;
				this.txt_Nhap.Text = 0.ToString();
			}
			return n;
		}

		private double HamF1(double n)
		{
			if (n == 0)
				return 0;
			else if (n == 1)
				return -5;
			else
				return -4 * HamF1(n - 1) + 5 * HamF1(n - 2) + 12 * n + 8;
		}

		private double HamF2(double n)
		{
			if (n == 0)
				return 1;
			else if (n == 1)
				return 0;
			else
				return 2 * HamF1(n - 1) - HamF1(n - 2) + 2;
		}

		private double HamF3(double n)
		{
			if (n == 0)
				return 2;
			else if (n == 1)
				return 32;
			else
				return 16 * HamF1(n - 1) - 64 * HamF1(n - 2) + 128 * Math.Pow(8, n);
		}

		private double HamF4(double n)
		{
			if (n == 0)
				return 3;
			else if (n == 1)
				return 0;
			else
				return 5 * HamF1(n - 1) - 2 * HamF1(n - 2) + (35 * n + 51) * Math.Pow(3, n);
		}

		private double HamF5(double n)
		{
			if (n == 0)
				return 1;
			else if (n == 1)
				return 3;
			else
				return 5 * HamF1(n - 1) - 2 * HamF1(n - 2) + (Math.Pow(-n, 2) - 2 * n + 3);
		}

		private double HamF6(double n)
		{
			if (n == 0)
				return -1;
			else if (n == 1)
				return -2;
			else
				return 8 * HamF1(n - 1) + 15 * HamF1(n - 2) - 2 * Math.Pow(5, n + 1);
		}

		private double HamF7(double n)
		{
			if (n == 0)
				return 2;
			else if (n == 1)
				return 0;
			else
				return 6 * HamF1(n - 1) + 9 * HamF1(n - 2) + (18 * n + 12) * Math.Pow(3, n);
		}

		private double HamF8(double n)
		{
			if (n == 0)
				return 1;
			else if (n == 1)
				return -2;
			else
				return 12 * HamF1(n - 1) - 9 * HamF1(n - 2) + (2 * Math.Pow(n, 2) + 29 * n + 56) * Math.Pow(3, n - 1);
		}
		private void KQ_BaiTap1_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF1(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = -4Xn-1 + 5Xn-2 + 12n + 8{0}X0 = {1}, X1 = {2}", Environment.NewLine, 0, -5);
			this.txtb_DeBai.Text = str;
		}

		private void KQ_BaiTap2_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF2(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = 2Xn-1 - Xn-2 + 2{0}X0 = {1}, X1 = {2}", Environment.NewLine, 1, 0);
			this.txtb_DeBai.Text = str;
		}

		private void KQ_BaiTap3_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF3(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = 16Xn-1 - 64Xn-2 + 128 * 8^n{0}X0 = {1}, X1 = {2}", Environment.NewLine, 2, 32);
			this.txtb_DeBai.Text = str;
		}

		private void KQ_BaiTap4_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF4(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = 5Xn-1 - 2Xn-2 + (35n + 51)3^n{0}X0 = {1}, X1 = {2}", Environment.NewLine, 3, 0);
			this.txtb_DeBai.Text = str;
		}

		private void KQ_BaiTap5_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF5(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = 5Xn-1 - 2Xn-2 + (-n^2 - 2n + 3){0}X0 = {1}, X1 = {2}", Environment.NewLine, 1, 3);
			this.txtb_DeBai.Text = str;
		}

		private void KQ_BaiTap6_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF6(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = 8Xn-1 + 15Xn-2 = 2.5^(n+1){0}X0 = {1}, X1 = {2}", Environment.NewLine, -1, -2);
			this.txtb_DeBai.Text = str;
		}

		private void KQ_BaiTap7_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF7(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = 6Xn-1 + 9Xn-2 + (18n + 12)3^n{0}X0 = {1}, X1 = {2}", Environment.NewLine, 2, 0);
			this.txtb_DeBai.Text = str;
		}

		private void KQ_BaiTap8_Click(object sender, EventArgs e)
		{
			double n = Layn();
			double kq = HamF8(n);
			this.txt_KetQua.Text = kq.ToString();
			string str = string.Format("Xn = 12Xn-1 - 9Xn-2 + (2n^2 + 29n + 56)2^n-1{0}X0 = {1}, X1 = {2}", Environment.NewLine, 1, -2);
			this.txtb_DeBai.Text = str;
		}
	}
}
