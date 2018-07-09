using log4net;
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
    public partial class FrmDuAn : Form
    {
        private ILog lg = LogManager.GetLogger(typeof(FrmDuAn));
        public FrmDuAn()
        {
            InitializeComponent();
            LoadMau();
        }
        private void LoadMau()
        {
            layoutControlGroup2.AppearanceGroup.BorderColor = Setting.GroupColor();

        }
        private void Load_duAn()
        {
            List<DuAn> duan = Retrofit.instance.getAllDuAn();
            gridControl1.DataSource = duan;
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            DuAn duAn = new DuAn(tbDuAn.Text);
            StatusRespon status = Retrofit.instance.addDuAn(duAn);
          
            if (status.Status)
            {
                MessageBox.Show("Thêm dự án thành công!!!");
                Load_duAn();
            }
            An();
        }

        private void FrmDuAn_Load(object sender, EventArgs e)
        {
            Load_duAn();
        }

        public void Hien()
        {
            tbDuAn.Enabled = true;
        }
        public void An()
        {
            tbDuAn.Enabled = false;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            Hien();
            tbDuAn.ResetText();
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

        private void gridView1_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle != gridView1.FocusedRowHandle && (e.RowHandle % 2 == 0))
                e.Appearance.BackColor = Color.LightYellow;
        }
    }
}
