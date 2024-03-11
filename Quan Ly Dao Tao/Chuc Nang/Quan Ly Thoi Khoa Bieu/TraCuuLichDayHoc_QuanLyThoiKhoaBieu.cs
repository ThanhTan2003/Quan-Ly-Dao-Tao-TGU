﻿using Quan_Ly_Dao_Tao.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Dao_Tao.Chuc_Nang.Quan_Ly_Thoi_Khoa_Bieu
{
    public partial class TraCuuLichDayHoc_QuanLyThoiKhoaBieu : UserControl
    {
        public TraCuuLichDayHoc_QuanLyThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void listMH_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listHP_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listMH_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listMH.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        private void listHP_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listHP.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        private void TraCuuLichDayHoc_QuanLyThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            LoadDonVi();
            LoadNamHoc();
            LoadHocKy();
            LoadMonHoc();
        }
        // combobox DONVI
        private void LoadDonVi()
        {
            string sql = "select * from DONVI";
            DataTable dt = new DataTable();
            dt = CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboDonVi.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        // combobox NGANH
        private void LoadNganh()
        {
            string sql = "select distinct TenNganh from NGANH, DONVI where TenDV =N'" + cboDonVi.SelectedItem.ToString() + "' and NGANH.MaDV = DONVI.MaDV"; 
            DataTable dt = new DataTable();
            dt = CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboNganh.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        // combobox NAMHOC
        private void LoadNamHoc()
        {
            // cboHocKy1: nằm ở bên thông tin tìm kiếm
            string sql = "select * from NAMHOC";
            DataTable dt = new DataTable();
            dt = CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboNamHoc.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        // combobox HOCKI
        private void LoadHocKy()
        {
            string sql = "select distinct HocKy from THOIKHOABIEU";
            DataTable dt = new DataTable();
            dt = CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboHocKyTim.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        // khởi tạo môn học 
        private void LoadMonHoc()
        {
            // lấy MaMH, TenMH gán vào listMH khoi form được load lên
            string sql = "select * from MONHOC";
            DataTable dt = new DataTable();
            dt = CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listMH.Items.Add(dt.Rows[i][0].ToString());
                listMH.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {            
            string maMH = txtTimMaMH.Text;            
            if (string.Equals(maMH, "Vui lòng nhập vào mã môn học"))
            {
                MessageBox.Show("Vui lòng nhập vào mã môn học!", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(maMH))
            {
                MessageBox.Show("Vui lòng nhập vào mã môn học!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtTimMaMH.Focus();
                return;
            }
            if (maMH.Length == 7 && maMH.Substring(0, 2).Equals("MH"))
            {
                string sql = "select MaMH, TenMH from MONHOC where MaMH='" + txtTimMaMH.Text + "'";
                DataTable dt = new DataTable();
                dt = CSDL.LayDuLieu(sql);
                if (dt.Rows.Count > 0)
                {
                    listMH.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listMH.Items.Add(dt.Rows[i][0].ToString());
                        listMH.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy môn học cần tìm. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã môn học không hợp lệ. Vui lòng nhập lại!", "Thông báo");
            }
        }
        
        private void empty()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtNamHoc.Text = "";
            cboHocKy.Text = "";
            txtNhom.Text = "";
            cboThu.Text = "";
            txtMaGV.Text = "";
            txtTiet.Text = "";
            txtTenGV.Text = "";
            nuSoTiet.Value = 0;
        }
        private void listMH_Click(object sender, EventArgs e)
        {            
            empty();
            string maMH = listMH.SelectedItems[0].SubItems[0].Text;
            LoadDanhSachNhomHocPhan(maMH);
        }

        private void cboDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // khi chọn DONVI => ra toàn bộ môn học của đơn vị đó
            listMH.Items.Clear();
            if (cboDonVi.SelectedIndex != -1)
            {
                cboNganh.Items.Clear();
                LoadNganh();
                string sql = "select MH.MaMH, MH.TenMH from MONHOC MH join NGANH N on MH.TenNganh = N.TenNganh join DONVI DV on N.MaDV = DV.MaDV where DV.TenDV = N'" + cboDonVi.SelectedItem.ToString() + "'";
                DataTable dt = new DataTable();
                dt = CSDL.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listMH.Items.Add(dt.Rows[i][0].ToString());
                    listMH.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                }
            }
        }

        private void cboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // chọn DONVI và NGANH => ra môn học của ngành thuộc đơn vị đó
            listMH.Items.Clear();
            if (cboDonVi.SelectedIndex != -1 && cboNganh.SelectedIndex != -1)
            {
                string sql = "select MH.MaMH, MH.TenMH from MONHOC MH join NGANH N on MH.TenNganh = N.TenNganh join DONVI DV on N.MaDV = DV.MaDV where DV.TenDV = N'" + cboDonVi.SelectedItem.ToString() + "' and N.TenNganh =N'" + cboNganh.SelectedItem.ToString() + "'";
                DataTable dt = new DataTable();
                dt = CSDL.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listMH.Items.Add(dt.Rows[i][0].ToString());
                    listMH.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                }
            }
        }

        private void listHP_Click(object sender, EventArgs e)
        {
            string maMH = listHP.SelectedItems[0].SubItems[1].Text;
            string nhom = listHP.SelectedItems[0].SubItems[3].Text;
            string sql = "select T.MaMH, TenMH, NamHoc, HocKy, SoTC, NhomHP, Thu, G.MaGV, TietGiangDay, HoTen, GhiChu, SoTietThucDay \r\nfrom THOIKHOABIEU T, MONHOC M, GIANGVIEN G\r\nwhere T.MaMH='" + maMH + "' and NhomHP=" + nhom + " and T.MaMH = M.MaMH and T.MaGV = G.MaGV \r\norder by NhomHP";
            LoadThongTinNhomHocPhan(sql);
        }

        private void txtTimMaMH_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimMaMH.Text = "";
            txtTimMaMH.ForeColor = Color.Black;
        }

        private void cboDonVi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboNganh.Text = "";
            cboNamHoc.Text = "";
            cboHocKyTim.Text = "";
        }

        private void listMH_KeyUp(object sender, KeyEventArgs e)
        {
            string maMH = listMH.SelectedItems[0].SubItems[0].Text;
            LoadDanhSachNhomHocPhan(maMH);
        }
        private void LoadDanhSachNhomHocPhan(string maMH)
        {
            string sql = "select ROW_NUMBER()over(order by NhomHP) as STT, T.MaMH, TenMH, NhomHP, Thu, TietGiangDay  from THOIKHOABIEU T, MONHOC M where T.MaMH='" + maMH + "' and T.MaMH = M.MaMH";
            DataTable dt = new DataTable();
            dt = CSDL.LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                listHP.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listHP.Items.Add(dt.Rows[i][0].ToString());
                    listHP.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listHP.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                    listHP.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                    listHP.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                    listHP.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                }
            }
            else
            {
                listHP.Items.Clear();
            }
        }

        private void LoadThongTinNhomHocPhan(string sql)
        {
            DataTable dt = new DataTable();
            dt = CSDL.LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtMaMH.Text = dt.Rows[i][0].ToString();
                    txtTenMH.Text = dt.Rows[i][1].ToString();
                    txtNamHoc.Text = dt.Rows[i][2].ToString();
                    cboHocKy.Text = dt.Rows[i][3].ToString();
                    txtSoTC.Text = dt.Rows[i][4].ToString();
                    txtNhom.Text = dt.Rows[i][5].ToString();
                    cboThu.Text = dt.Rows[i][6].ToString();
                    txtMaGV.Text = dt.Rows[i][7].ToString();
                    txtTiet.Text = dt.Rows[i][8].ToString();
                    txtTenGV.Text = dt.Rows[i][9].ToString();
                    txtGhiChu.Text = dt.Rows[i][10].ToString();
                    int soTiet = Convert.ToInt32(dt.Rows[i][11]);
                    nuSoTiet.Value = soTiet;
                }
            }
        }
        private void listHP_KeyUp(object sender, KeyEventArgs e)
        {
            string maMH = listHP.SelectedItems[0].SubItems[1].Text;
            string nhom = listHP.SelectedItems[0].SubItems[3].Text;
            string sql = "select T.MaMH, TenMH, NamHoc, HocKy, SoTC, NhomHP, Thu, G.MaGV, TietGiangDay, HoTen, GhiChu, SoTietThucDay \r\nfrom THOIKHOABIEU T, MONHOC M, GIANGVIEN G\r\nwhere T.MaMH='" + maMH + "' and NhomHP=" + nhom + " and T.MaMH = M.MaMH and T.MaGV = G.MaGV \r\norder by NhomHP";
            LoadThongTinNhomHocPhan(sql);
        }
        
    }
}
