﻿namespace Quan_Ly_Dao_Tao.Chuc_Nang.Quan_Ly_Giang_Vien
{
    partial class TraCuuThongTinGiangVien_QuanLyGiangVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbdonvi1 = new System.Windows.Forms.ComboBox();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this.txtHH = new System.Windows.Forms.TextBox();
            this.txtHV = new System.Windows.Forms.TextBox();
            this.cbGioi = new System.Windows.Forms.ComboBox();
            this.txtGV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMaGv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbdonvi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(14, 544);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 87;
            this.label13.Text = "Danh sách có:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Enabled = false;
            this.txtDiachi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(478, 206);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(289, 73);
            this.txtDiachi.TabIndex = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên giảng viên";
            this.columnHeader2.Width = 243;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã đơn vị";
            this.columnHeader3.Width = 122;
            // 
            // listDS
            // 
            this.listDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listDS.FullRowSelect = true;
            this.listDS.GridLines = true;
            this.listDS.HideSelection = false;
            this.listDS.Location = new System.Drawing.Point(18, 205);
            this.listDS.Name = "listDS";
            this.listDS.OwnerDraw = true;
            this.listDS.Size = new System.Drawing.Size(498, 326);
            this.listDS.TabIndex = 91;
            this.listDS.UseCompatibleStateImageBehavior = false;
            this.listDS.View = System.Windows.Forms.View.Details;
            this.listDS.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listDS_DrawColumnHeader);
            this.listDS.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listDS_DrawItem);
            this.listDS.SelectedIndexChanged += new System.EventHandler(this.listDS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã giảng viên";
            this.columnHeader1.Width = 129;
            // 
            // cbdonvi1
            // 
            this.cbdonvi1.Enabled = false;
            this.cbdonvi1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdonvi1.FormattingEnabled = true;
            this.cbdonvi1.Location = new System.Drawing.Point(478, 160);
            this.cbdonvi1.Name = "cbdonvi1";
            this.cbdonvi1.Size = new System.Drawing.Size(289, 27);
            this.cbdonvi1.TabIndex = 28;
            // 
            // d1
            // 
            this.d1.CustomFormat = "dd/MM/yyyy";
            this.d1.Enabled = false;
            this.d1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d1.Location = new System.Drawing.Point(134, 69);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(153, 27);
            this.d1.TabIndex = 31;
            // 
            // txtHH
            // 
            this.txtHH.Enabled = false;
            this.txtHH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHH.Location = new System.Drawing.Point(134, 115);
            this.txtHH.Name = "txtHH";
            this.txtHH.Size = new System.Drawing.Size(245, 27);
            this.txtHH.TabIndex = 30;
            // 
            // txtHV
            // 
            this.txtHV.Enabled = false;
            this.txtHV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHV.Location = new System.Drawing.Point(478, 115);
            this.txtHV.Name = "txtHV";
            this.txtHV.Size = new System.Drawing.Size(289, 27);
            this.txtHV.TabIndex = 29;
            // 
            // cbGioi
            // 
            this.cbGioi.Enabled = false;
            this.cbGioi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioi.FormattingEnabled = true;
            this.cbGioi.Location = new System.Drawing.Point(478, 72);
            this.cbGioi.Name = "cbGioi";
            this.cbGioi.Size = new System.Drawing.Size(153, 27);
            this.cbGioi.TabIndex = 28;
            // 
            // txtGV
            // 
            this.txtGV.Enabled = false;
            this.txtGV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGV.Location = new System.Drawing.Point(134, 30);
            this.txtGV.Name = "txtGV";
            this.txtGV.Size = new System.Drawing.Size(245, 27);
            this.txtGV.TabIndex = 25;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(134, 160);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(245, 27);
            this.txtSDT.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(388, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Đơn vị:";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.ForeColor = System.Drawing.Color.Black;
            this.lbSL.Location = new System.Drawing.Point(132, 544);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(102, 19);
            this.lbSL.TabIndex = 94;
            this.lbSL.Text = "... giảng viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(388, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Học vị:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.cbdonvi1);
            this.groupBox1.Controls.Add(this.d1);
            this.groupBox1.Controls.Add(this.txtHH);
            this.groupBox1.Controls.Add(this.txtHV);
            this.groupBox1.Controls.Add(this.cbGioi);
            this.groupBox1.Controls.Add(this.txtGV);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(558, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 314);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Học hàm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(388, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giới tính:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 19);
            this.label19.TabIndex = 16;
            this.label19.Text = "Ngày sinh:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(134, 206);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // txtHoten
            // 
            this.txtHoten.Enabled = false;
            this.txtHoten.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(478, 30);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(289, 27);
            this.txtHoten.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(388, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã GV:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(331, 100);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 37);
            this.btnTim.TabIndex = 27;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaGv
            // 
            this.txtMaGv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGv.Location = new System.Drawing.Point(79, 67);
            this.txtMaGv.Name = "txtMaGv";
            this.txtMaGv.Size = new System.Drawing.Size(381, 27);
            this.txtMaGv.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã GV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtMaGv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbdonvi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(18, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 149);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN TÌM KIẾM";
            // 
            // cbdonvi
            // 
            this.cbdonvi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdonvi.FormattingEnabled = true;
            this.cbdonvi.Location = new System.Drawing.Point(78, 30);
            this.cbdonvi.Name = "cbdonvi";
            this.cbdonvi.Size = new System.Drawing.Size(382, 27);
            this.cbdonvi.TabIndex = 11;
            this.cbdonvi.SelectedIndexChanged += new System.EventHandler(this.cbdonvi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn vị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(14, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 90;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // TraCuuThongTinGiangVien_QuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listDS);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TraCuuThongTinGiangVien_QuanLyGiangVien";
            this.Size = new System.Drawing.Size(1359, 577);
            this.Load += new System.EventHandler(this.TraCuuThongTinGiangVien_QuanLyGiangVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listDS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cbdonvi1;
        private System.Windows.Forms.DateTimePicker d1;
        private System.Windows.Forms.TextBox txtHH;
        private System.Windows.Forms.TextBox txtHV;
        private System.Windows.Forms.ComboBox cbGioi;
        private System.Windows.Forms.TextBox txtGV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMaGv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbdonvi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
