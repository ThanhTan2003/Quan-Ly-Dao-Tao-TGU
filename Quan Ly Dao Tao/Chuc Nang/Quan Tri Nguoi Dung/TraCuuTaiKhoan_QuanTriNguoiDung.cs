﻿using Quan_Ly_Dao_Tao.BaoCao.From;
using Quan_Ly_Dao_Tao.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Dao_Tao.Chuc_Nang.Quan_Tri_Nguoi_Dung
{
    public partial class TraCuuTaiKhoan_QuanTriNguoiDung : UserControl
    {
        public TraCuuTaiKhoan_QuanTriNguoiDung()
        {
            InitializeComponent();
        }

        void LayDSTaiKhoan()
        {
            string sql = "select TAIKHOAN.TK, LOAITAIKHOAN.TenLoai from TAIKHOAN, LOAITAIKHOAN where TAIKHOAN.LoaiTK = LOAITAIKHOAN.MaLoai";
            DataTable dt = CSDL.LayDuLieu(sql);
            listDS.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        void LayDSLoaiTK()
        {
            string sql = "select *from LOAITAIKHOAN";
            cbPhanLoai.Items.Clear();
            DataTable dt = CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbPhanLoai.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void listDS_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listDS_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.Item != null)
            {
                if (e.ItemIndex == 0) // Nếu là dòng tiêu đề
                {
                }
                else // Nếu là các dòng dữ liệu
                {
                    // Vẽ các dòng dữ liệu với màu chữ đen và font size nhỏ hơn
                    e.Graphics.DrawString(listDS.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }

        private void TraCuuTaiKhoan_QuanTriNguoiDung_Load(object sender, EventArgs e)
        {
            LayDSTaiKhoan();
            LayDSLoaiTK();
        }

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select TAIKHOAN.TK, LOAITAIKHOAN.TenLoai from TAIKHOAN, LOAITAIKHOAN where TAIKHOAN.LoaiTK = LOAITAIKHOAN.MaLoai and LOAITAIKHOAN.TenLoai = N'" + cbPhanLoai.Text + "'";
            DataTable dt = CSDL.LayDuLieu(sql);
            listDS.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDS.SelectedItems.Count > 0)
            {
                string sql = "select TAIKHOAN.MaGV, TAIKHOAN.TenHienThi, TenLoai, MK from TAIKHOAN, LOAITAIKHOAN where TAIKHOAN.LoaiTK = LOAITAIKHOAN.MaLoai and TK = '" + listDS.SelectedItems[0].SubItems[0].Text + "'";
                DataTable dt = CSDL.LayDuLieu(sql);
                if (dt.Rows.Count > 0)
                {
                    
                    tbHoTen.Text = dt.Rows[0][1].ToString();
                    tbTK.Text = listDS.SelectedItems[0].SubItems[0].Text;
                    tbLoaiTK.Text = cbPhanLoai.Text;
                    tbLoaiTK.Text = dt.Rows[0][2].ToString();
                    tbMK.Text = dt.Rows[0][3].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin tài khoản cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            listDS.Items.Clear();
            string sql = "select TK, TenLoai from TAIKHOAN, LOAITAIKHOAN where TAIKHOAN.LoaiTK = LOAITAIKHOAN.MaLoai and TK like '%" + tbTimKiem.Text + "%'";
            DataTable dt = CSDL.LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listDS_DrawColumnHeader_1(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listDS_DrawItem_1(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.Item != null)
            {
                if (e.ItemIndex == 0) // Nếu là dòng tiêu đề
                {
                }
                else // Nếu là các dòng dữ liệu
                {
                    // Vẽ các dòng dữ liệu với màu chữ đen và font size nhỏ hơn
                    e.Graphics.DrawString(listDS.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InDanhSachTaiKhoan f = new InDanhSachTaiKhoan();
            f.ShowDialog();
        }
    }
}
