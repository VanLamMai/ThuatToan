namespace ThapHaNoi
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_SoDia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Dia1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Dia3 = new System.Windows.Forms.ComboBox();
            this.cbx_Dia2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lisbx_KetQua = new System.Windows.Forms.ListBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.txtb_SoBuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(220, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÀI TOÁN THÁP HÀ NỘI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập số đĩa:";
            // 
            // cbx_SoDia
            // 
            this.cbx_SoDia.FormattingEnabled = true;
            this.cbx_SoDia.IntegralHeight = false;
            this.cbx_SoDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbx_SoDia.Location = new System.Drawing.Point(129, 25);
            this.cbx_SoDia.Name = "cbx_SoDia";
            this.cbx_SoDia.Size = new System.Drawing.Size(74, 29);
            this.cbx_SoDia.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập nhãn đĩa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(141, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đĩa 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(240, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đĩa 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(342, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đĩa 3";
            // 
            // cbx_Dia1
            // 
            this.cbx_Dia1.FormattingEnabled = true;
            this.cbx_Dia1.IntegralHeight = false;
            this.cbx_Dia1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "X",
            "Y",
            "Z"});
            this.cbx_Dia1.Location = new System.Drawing.Point(129, 93);
            this.cbx_Dia1.Name = "cbx_Dia1";
            this.cbx_Dia1.Size = new System.Drawing.Size(74, 29);
            this.cbx_Dia1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Dia3);
            this.groupBox1.Controls.Add(this.cbx_Dia2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_SoDia);
            this.groupBox1.Controls.Add(this.cbx_Dia1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập";
            // 
            // cbx_Dia3
            // 
            this.cbx_Dia3.FormattingEnabled = true;
            this.cbx_Dia3.IntegralHeight = false;
            this.cbx_Dia3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "X",
            "Y",
            "Z"});
            this.cbx_Dia3.Location = new System.Drawing.Point(333, 93);
            this.cbx_Dia3.Name = "cbx_Dia3";
            this.cbx_Dia3.Size = new System.Drawing.Size(74, 29);
            this.cbx_Dia3.TabIndex = 11;
            // 
            // cbx_Dia2
            // 
            this.cbx_Dia2.FormattingEnabled = true;
            this.cbx_Dia2.IntegralHeight = false;
            this.cbx_Dia2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "X",
            "Y",
            "Z"});
            this.cbx_Dia2.Location = new System.Drawing.Point(227, 93);
            this.cbx_Dia2.Name = "cbx_Dia2";
            this.cbx_Dia2.Size = new System.Drawing.Size(74, 29);
            this.cbx_Dia2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lisbx_KetQua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 252);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xuất";
            // 
            // lisbx_KetQua
            // 
            this.lisbx_KetQua.FormattingEnabled = true;
            this.lisbx_KetQua.ItemHeight = 21;
            this.lisbx_KetQua.Location = new System.Drawing.Point(17, 30);
            this.lisbx_KetQua.Name = "lisbx_KetQua";
            this.lisbx_KetQua.ScrollAlwaysVisible = true;
            this.lisbx_KetQua.Size = new System.Drawing.Size(551, 214);
            this.lisbx_KetQua.TabIndex = 33;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(33, 291);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(183, 36);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Xóa dữ liệu chạy lại";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(32, 454);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(183, 33);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(33, 243);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(183, 42);
            this.btn_Run.TabIndex = 10;
            this.btn_Run.Text = "Chạy thuật toán";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // txtb_SoBuoc
            // 
            this.txtb_SoBuoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtb_SoBuoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SoBuoc.Location = new System.Drawing.Point(470, 498);
            this.txtb_SoBuoc.Name = "txtb_SoBuoc";
            this.txtb_SoBuoc.ReadOnly = true;
            this.txtb_SoBuoc.Size = new System.Drawing.Size(160, 29);
            this.txtb_SoBuoc.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(291, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng số bước chạy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 535);
            this.Controls.Add(this.txtb_SoBuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbx_SoDia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbx_Dia1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbx_Dia3;
		private System.Windows.Forms.ComboBox cbx_Dia2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox lisbx_KetQua;
		private System.Windows.Forms.Button btn_Remove;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_Run;
		private System.Windows.Forms.TextBox txtb_SoBuoc;
		private System.Windows.Forms.Label label2;
	}
}

