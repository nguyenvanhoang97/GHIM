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
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
            DuAn();
            LoadMau();
        }
        private void DuAn()
        {
            List<DuAn> allDuAn = Retrofit.instance.getAllDuAn();
            lueDuAn.Properties.DataSource = allDuAn;
            lueDuAn.Properties.ValueMember = "ID";
            lueDuAn.Properties.DisplayMember = "TenDuAn";
        }
        private void LoadMau()
        {
            layoutControlGroup2.AppearanceGroup.BorderColor = Setting.GroupColor();
           
        }

        private void LoadCongViec()
        {
            List<WorkV2> allwork = Retrofit.instance.getAllWork(lueDuAn.EditValue.ToString());
            gridControl1.DataSource = allwork;
        }

        private void LoadWork(string id)
        {
            List<WorkV2> works = Retrofit.instance.getAllWork(id);
            gridControl1.DataSource = works;
        }

       

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void lueDuAn_EditValueChanged_1(object sender, EventArgs e)
        {
            string id = lueDuAn.EditValue.ToString();
            LoadWork(id);
        }

        private void btSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
           
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

        private void báoHoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn hoàn thành công việc này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                StatusRespon status = Retrofit.instance.doneWork(id);
                MessageBox.Show(status.Message);
            }
            else
            {
                return;
            }
            
        }
    }
}
