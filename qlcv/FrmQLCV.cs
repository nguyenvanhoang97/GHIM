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
            DuAn();


        }
      
        public void Hien()
        {

        }
        private void DuAn()
        {
            List<DuAn> allDuAn = Retrofit.instance.getAllDuAn();
            luedDuAn.Properties.DataSource = allDuAn;
            luedDuAn.Properties.ValueMember = "ID";
            luedDuAn.Properties.DisplayMember = "TenDuAn";
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
                //FrmHTCV frm = new FrmHTCV(hangMuc , phanHe , moTa , ngayBatDau , ngayHoanThanh , nguoiThucHien , nguoiYeuCau , deadline , trangThai);
                //frm.Show();


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
            FrmHTCV frm = new FrmHTCV();
            frm.Show();
        }
        private void LoadWork(string id)
        {
            List<Work> works = Retrofit.instance.getAllWork(id);
            gridControl1.DataSource = works;
        }

        private void luedDuAn_EditValueChanged(object sender, EventArgs e)
        {
            string id= luedDuAn.EditValue.ToString();
            LoadWork(id);
        }
    }
}
