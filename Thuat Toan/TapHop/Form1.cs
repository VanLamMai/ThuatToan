using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapHop
{
    public partial class Form1 : Form
    {
        Set tapa, tapb;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult thongBao = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (thongBao == DialogResult.OK)
                Application.Exit();
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            string s;
            if (this.txtb_PTTapA.Text == "" || this.txtb_PTTapB.Text == "")
                MessageBox.Show("Nhập lại tập hợp A hoặc tập hợp B!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                s = this.txtb_PTTapA.Text.Trim();
                string[] strA = s.Split(',');                
                try
                {
                    int test = int.Parse(strA[0]);
                    List<int> a = new List<int>(); 
                    for (int i = 0; i < strA.Length; i++)
                    {
                        a.Add(int.Parse(strA[i]));
                    }
                    tapa = new Set(a.Count, a);
                }
                catch
                {
                    List<char> a = new List<char>(); 
                    for (int i = 0; i < strA.Length; i++)
                    {
                        a.Add(char.Parse(strA[i]));
                    }
                    tapa = new Set(a.Count, a);
                }                                       
                this.txtb_KQTapA.Text = tapa.ConvertSetToString();

                s = this.txtb_PTTapB.Text.Trim();
                string[] strB = s.Split(',');               
                try
                {
                    int test = int.Parse(strB[0]);
                    List<int> b = new List<int>();
                    for (int i = 0; i < strB.Length; i++)
                    {
                        b.Add(int.Parse(strB[i]));
                    }
                    tapb = new Set(b.Count, b);
                }
                catch
                {
                    List<char> b = new List<char>();
                    for (int i = 0; i < strB.Length; i++)
                    {
                        b.Add(char.Parse(strB[i]));
                    }
                    tapb = new Set(b.Count, b);
                }                                
                this.txtb_KQTapB.Text = tapb.ConvertSetToString();
            }
        }

        private void btn_Hop_Click(object sender, EventArgs e)
        {
            Set tapc = new Set();
            tapc.Hop(tapa, tapb, ref tapc);
            this.txtb_KQ.Text = tapc.ConvertSetToString();
        }

        private void btn_BuA_Click(object sender, EventArgs e)
        {
            Set tapc = new Set();
            tapc.TapBu(tapa, ref tapc);
            this.txtb_KQ.Text = tapc.ConvertSetToString();
        }

        private void btn_BuB_Click(object sender, EventArgs e)
        {
            Set tapc = new Set();
            tapc.TapBu(tapb, ref tapc);
            this.txtb_KQ.Text = tapc.ConvertSetToString();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            this.txtb_KQTapA.Text = "";
            this.txtb_KQTapB.Text = "";
            this.txtb_KQ.Text = "";
            this.txtb_PTTapA.Text = "";
            this.txtb_PTTapB.Text = "";
        }

        private void btn_Hieu_Click(object sender, EventArgs e)
        {
            Set tapc = new Set();
            tapc.Hieu(tapa, tapb, ref tapc);
            this.txtb_KQ.Text = tapc.ConvertSetToString();
        }

        private void btn_HieuDoiXung_Click(object sender, EventArgs e)
        {
            Set tapAHieuB = new Set();
            tapAHieuB.Hieu(tapa, tapb, ref tapAHieuB);
            Set TapBHieuA = new Set();
            TapBHieuA.Hieu(tapb, tapa, ref TapBHieuA);
            Set tapc = new Set();
            tapc.Hop(tapAHieuB, TapBHieuA, ref tapc);
            this.txtb_KQ.Text = tapc.ConvertSetToString();
        }

        private void btn_Giao_Click(object sender, EventArgs e)
        {
            Set tapc = new Set();
            tapc.Giao(tapa, tapb, ref tapc);
            this.txtb_KQ.Text = tapc.ConvertSetToString();
        }
    }
}
