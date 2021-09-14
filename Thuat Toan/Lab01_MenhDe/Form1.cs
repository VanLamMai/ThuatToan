using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_MenhDe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private int LayMenhDeP()
		{
			int p = int.Parse(this.txt_p.Text);
			if (p > 1 || p < 0)
			{
				p = 1;
				this.txt_p.Text = 1.ToString();
			}			
			return p;
		}

		private int LayMenhDeQ()
		{
			int q = int.Parse(this.txt_q.Text);
			if (q > 1 || q < 0)
			{
				q = 1;
				this.txt_q.Text = 1.ToString();
			}				
			return q;
		}

		private int Not(int n)
		{
			if (n == 0)
				return 1;
			else
				return 0;
		}

		private int Or(int p, int q)
		{
			if (p == 0 && q == 0)
				return 0;
			return 1;
		}

		private int And(int p, int q)
		{
			if (p == 1 && q == 1)
				return 1;
			return 0;
		}

		private int KeoTheo(int p, int q)
		{
			if (p == 1 && q == 0)
				return 0;
			return 1;
		}

		private int KeoTheoHaiChieu(int p, int q)
		{
			if ((p == 1 && q == 1) || (p == 0 && q == 0))
				return 1;
			return 0;
		}

		private void btn_Not_Click(object sender, EventArgs e)
		{
			int p = LayMenhDeP();
			int q = LayMenhDeQ();
			string str = string.Format("Not(p) = {0}{1}Not(q) = {2}", Not(p), Environment.NewLine, Not(q));
			this.txtb_KetQua.Text = str;
		}

		private void btn_OR_Click(object sender, EventArgs e)
		{
			int p = LayMenhDeP();
			int q = LayMenhDeQ();
			string str = string.Format("Or(p,q) = {0}", Or(p, q));
			this.txtb_KetQua.Text = str;
		}

		private void btn_AND_Click(object sender, EventArgs e)
		{
			int p = LayMenhDeP();
			int q = LayMenhDeQ();
			string str = string.Format("And(p,q) = {0}", And(p, q));
			this.txtb_KetQua.Text = str;
		}

		private void btn_KEOTHEO_Click(object sender, EventArgs e)
		{
			int p = LayMenhDeP();
			int q = LayMenhDeQ();
			string str = string.Format("KeoTheo(p, q){0}=> p --> q = {1}",Environment.NewLine, KeoTheo(p, q));
			this.txtb_KetQua.Text = str;
		}

		private void btn_KEOTHEO2C_Click(object sender, EventArgs e)
		{
			int p = LayMenhDeP();
			int q = LayMenhDeQ();
			string str = string.Format("KeoTheoHaiChieu(p, q){0}=> p <=> q = {1}",Environment.NewLine, KeoTheoHaiChieu(p, q));
			this.txtb_KetQua.Text = str;
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			this.txtb_KetQua.Clear();
			this.txt_p.Clear();
			this.txt_q.Clear();
		}
	}
}
