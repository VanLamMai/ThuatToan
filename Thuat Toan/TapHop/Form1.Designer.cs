namespace TapHop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_PTTapB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_PTTapA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Giao = new System.Windows.Forms.Button();
            this.btn_Hop = new System.Windows.Forms.Button();
            this.btn_Hieu = new System.Windows.Forms.Button();
            this.btn_HieuDoiXung = new System.Windows.Forms.Button();
            this.btn_BuA = new System.Windows.Forms.Button();
            this.btn_BuB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_KQTapB = new System.Windows.Forms.TextBox();
            this.txtb_KQTapA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_KQ = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TOÁN TRÊN TẬP HỢP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 465);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_BuB);
            this.tabPage1.Controls.Add(this.btn_BuA);
            this.tabPage1.Controls.Add(this.btn_HieuDoiXung);
            this.tabPage1.Controls.Add(this.btn_Hieu);
            this.tabPage1.Controls.Add(this.btn_Hop);
            this.tabPage1.Controls.Add(this.btn_Giao);
            this.tabPage1.Controls.Add(this.btn_Exit);
            this.tabPage1.Controls.Add(this.btn_Remove);
            this.tabPage1.Controls.Add(this.btn_Nhap);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập các phần tử của tập hợp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_PTTapB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb_PTTapA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông số đầu vào";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi chú: Tập hợp các số nguyên không quá 100 phần tử và ký tự từ a đến z.";
            // 
            // txtb_PTTapB
            // 
            this.txtb_PTTapB.Location = new System.Drawing.Point(9, 98);
            this.txtb_PTTapB.Name = "txtb_PTTapB";
            this.txtb_PTTapB.Size = new System.Drawing.Size(741, 25);
            this.txtb_PTTapB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(603, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập mảng các phần tử trên B cách nhau bởi dấu \",\". Ví dụ: a,b,c,d,e,f,... hoặc 1" +
    ",2,3,4,...,100";
            // 
            // txtb_PTTapA
            // 
            this.txtb_PTTapA.Location = new System.Drawing.Point(9, 50);
            this.txtb_PTTapA.Name = "txtb_PTTapA";
            this.txtb_PTTapA.Size = new System.Drawing.Size(741, 25);
            this.txtb_PTTapA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mảng các phần tử trên A cách nhau bởi dấu \",\". Ví dụ: a,b,c,d,e,f,... hoặc 1" +
    ",2,3,4,...,100";
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Các phép toán trên tập hợp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(15, 181);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(138, 28);
            this.btn_Nhap.TabIndex = 1;
            this.btn_Nhap.Text = "Nhập phần tử";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(324, 181);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(138, 28);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Xóa Trắng";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(618, 181);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(138, 28);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát chương trình";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Giao
            // 
            this.btn_Giao.Location = new System.Drawing.Point(15, 232);
            this.btn_Giao.Name = "btn_Giao";
            this.btn_Giao.Size = new System.Drawing.Size(111, 28);
            this.btn_Giao.TabIndex = 4;
            this.btn_Giao.Text = "A Giao B";
            this.btn_Giao.UseVisualStyleBackColor = true;
            this.btn_Giao.Click += new System.EventHandler(this.btn_Giao_Click);
            // 
            // btn_Hop
            // 
            this.btn_Hop.Location = new System.Drawing.Point(137, 232);
            this.btn_Hop.Name = "btn_Hop";
            this.btn_Hop.Size = new System.Drawing.Size(111, 28);
            this.btn_Hop.TabIndex = 5;
            this.btn_Hop.Text = "A Hợp B";
            this.btn_Hop.UseVisualStyleBackColor = true;
            this.btn_Hop.Click += new System.EventHandler(this.btn_Hop_Click);
            // 
            // btn_Hieu
            // 
            this.btn_Hieu.Location = new System.Drawing.Point(254, 232);
            this.btn_Hieu.Name = "btn_Hieu";
            this.btn_Hieu.Size = new System.Drawing.Size(111, 28);
            this.btn_Hieu.TabIndex = 6;
            this.btn_Hieu.Text = "A Hiệu B";
            this.btn_Hieu.UseVisualStyleBackColor = true;
            this.btn_Hieu.Click += new System.EventHandler(this.btn_Hieu_Click);
            // 
            // btn_HieuDoiXung
            // 
            this.btn_HieuDoiXung.Location = new System.Drawing.Point(371, 232);
            this.btn_HieuDoiXung.Name = "btn_HieuDoiXung";
            this.btn_HieuDoiXung.Size = new System.Drawing.Size(151, 28);
            this.btn_HieuDoiXung.TabIndex = 7;
            this.btn_HieuDoiXung.Text = "A Hiệu Đối Xứng B";
            this.btn_HieuDoiXung.UseVisualStyleBackColor = true;
            this.btn_HieuDoiXung.Click += new System.EventHandler(this.btn_HieuDoiXung_Click);
            // 
            // btn_BuA
            // 
            this.btn_BuA.Location = new System.Drawing.Point(528, 232);
            this.btn_BuA.Name = "btn_BuA";
            this.btn_BuA.Size = new System.Drawing.Size(111, 28);
            this.btn_BuA.TabIndex = 8;
            this.btn_BuA.Text = "Bù của A";
            this.btn_BuA.UseVisualStyleBackColor = true;
            this.btn_BuA.Click += new System.EventHandler(this.btn_BuA_Click);
            // 
            // btn_BuB
            // 
            this.btn_BuB.Location = new System.Drawing.Point(645, 232);
            this.btn_BuB.Name = "btn_BuB";
            this.btn_BuB.Size = new System.Drawing.Size(111, 28);
            this.btn_BuB.TabIndex = 9;
            this.btn_BuB.Text = "Bù của B";
            this.btn_BuB.UseVisualStyleBackColor = true;
            this.btn_BuB.Click += new System.EventHandler(this.btn_BuB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtb_KQ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtb_KQTapB);
            this.groupBox2.Controls.Add(this.txtb_KQTapA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 160);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả thực hiện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "B";
            // 
            // txtb_KQTapB
            // 
            this.txtb_KQTapB.Location = new System.Drawing.Point(83, 68);
            this.txtb_KQTapB.Name = "txtb_KQTapB";
            this.txtb_KQTapB.Size = new System.Drawing.Size(652, 25);
            this.txtb_KQTapB.TabIndex = 5;
            // 
            // txtb_KQTapA
            // 
            this.txtb_KQTapA.Location = new System.Drawing.Point(83, 37);
            this.txtb_KQTapA.Name = "txtb_KQTapA";
            this.txtb_KQTapA.Size = new System.Drawing.Size(652, 25);
            this.txtb_KQTapA.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(17, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kết Quả";
            // 
            // txtb_KQ
            // 
            this.txtb_KQ.Location = new System.Drawing.Point(83, 128);
            this.txtb_KQ.Name = "txtb_KQ";
            this.txtb_KQ.Size = new System.Drawing.Size(651, 25);
            this.txtb_KQ.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtb_PTTapB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_PTTapA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtb_KQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtb_KQTapB;
        private System.Windows.Forms.TextBox txtb_KQTapA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_BuB;
        private System.Windows.Forms.Button btn_BuA;
        private System.Windows.Forms.Button btn_HieuDoiXung;
        private System.Windows.Forms.Button btn_Hieu;
        private System.Windows.Forms.Button btn_Hop;
        private System.Windows.Forms.Button btn_Giao;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Nhap;
    }
}

