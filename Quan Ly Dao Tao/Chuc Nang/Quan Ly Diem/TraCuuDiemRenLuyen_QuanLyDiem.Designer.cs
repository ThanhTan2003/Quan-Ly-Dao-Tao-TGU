﻿namespace Quan_Ly_Dao_Tao.Chuc_Nang.Quan_Ly_Diem
{
    partial class TraCuuDiemRenLuyen_QuanLyDiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDS = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLop = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.cbHK = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(534, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "DANH SÁCH SINH VIÊN";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Điểm rèn luyện";
            this.columnHeader8.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lớp";
            this.columnHeader7.Width = 164;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ tên";
            this.columnHeader6.Width = 263;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MSSV";
            this.columnHeader5.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            this.columnHeader4.Width = 61;
            // 
            // listDS
            // 
            this.listDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listDS.FullRowSelect = true;
            this.listDS.GridLines = true;
            this.listDS.HideSelection = false;
            this.listDS.Location = new System.Drawing.Point(538, 186);
            this.listDS.Name = "listDS";
            this.listDS.OwnerDraw = true;
            this.listDS.Size = new System.Drawing.Size(779, 351);
            this.listDS.TabIndex = 73;
            this.listDS.UseCompatibleStateImageBehavior = false;
            this.listDS.View = System.Windows.Forms.View.Details;
            this.listDS.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listDS_DrawColumnHeader);
            this.listDS.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listDS_DrawItem);
            this.listDS.SelectedIndexChanged += new System.EventHandler(this.listDS_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên lớp";
            this.columnHeader9.Width = 340;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã lớp";
            this.columnHeader3.Width = 129;
            // 
            // listLop
            // 
            this.listLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader9});
            this.listLop.FullRowSelect = true;
            this.listLop.GridLines = true;
            this.listLop.HideSelection = false;
            this.listLop.Location = new System.Drawing.Point(38, 186);
            this.listLop.Name = "listLop";
            this.listLop.OwnerDraw = true;
            this.listLop.Size = new System.Drawing.Size(473, 351);
            this.listLop.TabIndex = 71;
            this.listLop.UseCompatibleStateImageBehavior = false;
            this.listLop.View = System.Windows.Forms.View.Details;
            this.listLop.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listLop_DrawColumnHeader);
            this.listLop.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listLop_DrawItem);
            this.listLop.SelectedIndexChanged += new System.EventHandler(this.listLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "DANH SÁCH LỚP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.numDiem);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(545, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 127);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // txtLop
            // 
            this.txtLop.Enabled = false;
            this.txtLop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(75, 76);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(274, 27);
            this.txtLop.TabIndex = 30;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(442, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(324, 27);
            this.txtHoTen.TabIndex = 29;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Enabled = false;
            this.txtMSSV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(75, 36);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(274, 27);
            this.txtMSSV.TabIndex = 28;
            // 
            // numDiem
            // 
            this.numDiem.Enabled = false;
            this.numDiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiem.Location = new System.Drawing.Point(442, 76);
            this.numDiem.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(90, 27);
            this.numDiem.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(384, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Điểm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Lớp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(372, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Họ tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "MSSV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNamHoc);
            this.groupBox2.Controls.Add(this.cbHK);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(38, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 127);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN";
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(119, 36);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(321, 27);
            this.cbNamHoc.TabIndex = 17;
            // 
            // cbHK
            // 
            this.cbHK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHK.FormattingEnabled = true;
            this.cbHK.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHK.Location = new System.Drawing.Point(119, 68);
            this.cbHK.Name = "cbHK";
            this.cbHK.Size = new System.Drawing.Size(321, 27);
            this.cbHK.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Học kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Năm học:";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.ForeColor = System.Drawing.Color.Black;
            this.lbTong.Location = new System.Drawing.Point(688, 549);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(24, 19);
            this.lbTong.TabIndex = 78;
            this.lbTong.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(534, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "Tổng số sinh viên:";
            // 
            // TraCuuDiemRenLuyen_QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDS);
            this.Controls.Add(this.listLop);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TraCuuDiemRenLuyen_QuanLyDiem";
            this.Size = new System.Drawing.Size(1359, 577);
            this.Load += new System.EventHandler(this.TraCuuDiemRenLuyen_QuanLyDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listDS;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.NumericUpDown numDiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.ComboBox cbHK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label4;
    }
}
