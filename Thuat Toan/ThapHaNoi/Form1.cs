using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThapHaNoi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void btn_Run_Click(object sender, EventArgs e)
		{
			int soDia = int.Parse(this.cbx_SoDia.Text);
			this.lisbx_KetQua.DataSource = null;
			int soBuoc = 0;
			ThapHN(ref soBuoc, soDia, this.cbx_Dia1.Text, this.cbx_Dia2.Text, cbx_Dia3.Text);
			this.txtb_SoBuoc.Text = soBuoc.ToString();
		}

		private void btn_Remove_Click(object sender, EventArgs e)
		{
			this.cbx_SoDia.Text = null;
			this.cbx_Dia1.Text = null;
			this.cbx_Dia2.Text = null;
			this.cbx_Dia3.Text = null;
			this.txtb_SoBuoc.Text = null;
			this.lisbx_KetQua.Items.Clear();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			DialogResult dil = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (dil == DialogResult.OK)
				Application.Exit();
		}

		private void ThapHN(ref int soBuoc, int Sodia, string from, string inter, string to)
		{
			if (Sodia == 1)
			{

				this.lisbx_KetQua.Items.Add("Đĩa 1 từ " + from + " sang " + to);
				soBuoc += 1;
			}
			else
			{
				ThapHN(ref soBuoc, Sodia - 1, from, to, inter);
				this.lisbx_KetQua.Items.Add("Đĩa " + Sodia.ToString() + " từ " + from + " sang " + to);
				soBuoc += 1;
				ThapHN(ref soBuoc, Sodia - 1, inter, from, to);
			}
		}
	}
}