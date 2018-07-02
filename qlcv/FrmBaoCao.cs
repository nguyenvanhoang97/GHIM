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
        }
        private void DuAn()
        {
            List<DuAn> allDuAn = Retrofit.instance.getAllDuAn();
            lueDuAn.Properties.DataSource = allDuAn;
            lueDuAn.Properties.ValueMember = "ID";
            lueDuAn.Properties.DisplayMember = "TenDuAn";
        }

        private void LoadCongViec()
        {
            List<Work> allwork = Retrofit.instance.getAllWork(lueDuAn.EditValue.ToString());
            gridControl1.DataSource = allwork;
        }

        private void LoadWork(string id)
        {
            List<Work> works = Retrofit.instance.getAllWork(id);
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
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            FrmBC frm = new FrmBC(id);
            frm.ShowDialog();
        }
    }
}
