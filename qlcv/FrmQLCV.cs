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
        string id;
        private void LoadCongViec()
        {

            List<WorkV2> allwork = Retrofit.instance.getAllWork(luedDuAn.EditValue.ToString());
            gridControl1.DataSource = allwork;
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
                FrmHTCV frm = new FrmHTCV(id);
                frm.Show();

            }
            catch (Exception ex)
           {

                throw ex;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FrmHTCV frm = new FrmHTCV();
            frm.Show();
        }
        private void LoadWork(string id)
        {
            List<WorkV2> works = Retrofit.instance.getAllWork(id);
            gridControl1.DataSource = works;
        }

        private void luedDuAn_EditValueChanged(object sender, EventArgs e)
        {
            string id = luedDuAn.EditValue.ToString();
            LoadWork(id);
        }

        private void btXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            string hangmuc = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HangMuc").ToString();
            DialogResult result = MessageBox.Show("Xóa "+hangmuc+"?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Work work = new Work();
                work.ID = Int32.Parse(id);
                StatusRespon status = Retrofit.instance.deleteWork(work);
                if (status.Status)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Không xóa được công việc này");
                }
                LoadCongViec();
            }
        }

        private void btSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
