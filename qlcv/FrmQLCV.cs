using qlcv.Network;
using qlcv.Reponses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlcv
{
    public partial class FrmQLCV : Form
    {
        public FrmQLCV()
        {
            InitializeComponent();
            LoadNguoiThucHien();
            DuAn();
        }
        private void DuAn()
        {
            List<DuAn> allDuAn = Retrofit.instance.getAllDuAn();
            lueDuAn.Properties.DataSource = allDuAn;
            lueDuAn.Properties.ValueMember = "ID";
            lueDuAn.Properties.DisplayMember = "TenDuAn";
        }
        public void Hien()
        {

        }
        private void LoadNguoiThucHien()
        {
            //DataTable nguoith = new DataTable();

            List<User> alluser = Retrofit.instance.getAllUser();
            
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", Type.GetType("System.Int32"));
            dataTable.Columns.Add("Name", Type.GetType("System.String"));
            for(int i = 0; i < alluser.Count; i++)
            {
                dataTable.Rows.Add(alluser[i].ID, alluser[i].Name);
            }
            luedNguoiTH.Properties.DataSource = dataTable;
            luedNguoiTH.Properties.ValueMember = "ID";
            luedNguoiTH.Properties.DisplayMember = "Name";
            luedNguoiTH.Properties.PopulateColumns();
        }
        private void LoadTrangThai()
        {
            //List<string> allTrangThai = Retrofit.instance.getAllTrangThai
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                string hangMuc = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HangMuc").ToString();
                string phanHe = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PhanHe").ToString();
                string moTa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MoTa").ToString();
                DateTime ngayBatDau = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayBatDau").ToString());
                DateTime deadline = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Deadline").ToString());
                DateTime ngayHoanThanh = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayHoanThanh").ToString());
                string trangThai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TrangThaiCongViec").ToString();
                string nguoiYeuCau = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NguoiYeuCau").ToString();
                string nguoiThucHien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NguoiThucHien").ToString();
                string duAn = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DuAn").ToString();

                tbHangMuc.Text = hangMuc;
                tbMoTa.Text = moTa;
                tbPhanHe.Text = phanHe;
                tbNguoiYC.Text = nguoiYeuCau;
                luedNguoiTH.Text = nguoiThucHien;
                lueTrangThai.Text = trangThai;
                lueDuAn.Text = duAn;
                dateDead.DateTime = deadline;
                dateNgayBD.DateTime = ngayBatDau;
                dateNgayHT.DateTime = ngayHoanThanh;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle != gridView1.FocusedRowHandle && (e.RowHandle % 2 == 0))
                e.Appearance.BackColor = Color.LightYellow;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void lueDuAn_EditValueChanged(object sender, EventArgs e)
        {
            string a=lueDuAn.EditValue.ToString();
            LoadCongViec(a);
        }
        private void LoadCongViec(string id)
        {
            List<User> users = Retrofit.instance.getAllUser();
            List<Work> works = Retrofit.instance.getAllWork(id);
            gridControl1.DataSource = works;
        }
    }
}
