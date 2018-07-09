using DevExpress.Utils;
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
    public partial class FrmBaoCao : Form
    {
        private ILog lg = LogManager.GetLogger(typeof(FrmBaoCao));
        public FrmBaoCao()
        {
            InitializeComponent();
            DuAn();
            LoadMau();
        }
        List<WorkV2> allwork = new List<WorkV2>();
        private void DuAn()
        {
            try
            {
                List<DuAn> allDuAn = Retrofit.instance.getAllDuAn();
                lueDuAn.Properties.DataSource = allDuAn;
                lueDuAn.Properties.ValueMember = "ID";
                lueDuAn.Properties.DisplayMember = "TenDuAn";
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }
        private void LoadMau()
        {
            layoutControlGroup2.AppearanceGroup.BorderColor = Setting.GroupColor();

        }

        private void LoadCongViec()
        {
            try
            {
                allwork = Retrofit.instance.getAllWork(lueDuAn.EditValue.ToString());
                gridControl1.DataSource = allwork;
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
           
        }

        private void LoadWork(string id)
        {
            try
            {
                List<WorkV2> works = Retrofit.instance.getAllWork(id);
                gridControl1.DataSource = works;

            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }



        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void lueDuAn_EditValueChanged_1(object sender, EventArgs e)
        {
            WaitDialogForm wait = new DevExpress.Utils.WaitDialogForm("Phần mềm đang tải dữ liệu....", "Vui lòng chờ");
            try
            {
                wait.Show();
                //Phải cho khác null vào vì có lúc người dùng nó không chọn dự án đỡ mất công gửi lên sever
                //Sau này muốn nếu null mà load toàn bộ dự án thì làm vào phần else là được
                if (lueDuAn.EditValue != null)
                {
                    string id = lueDuAn.EditValue.ToString();
                    LoadWork(id);

                }
                
            }
            catch (Exception ex)
            {
                lg.Error(ex);
                wait.Close();
            }
            finally
            {
                wait.Close();
            }
            
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
            try
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn hoàn thành công việc này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                    StatusRespon status = Retrofit.instance.doneWork(id);
                    MessageBox.Show(status.Message);
                    int index = gridView1.TopRowIndex;
                    int focusrow = gridView1.FocusedRowHandle;
                    gridView1.BeginDataUpdate();
                    LoadCongViec();
                    gridView1.FocusedRowHandle = focusrow;
                    gridView1.TopRowIndex = index;
                    gridView1.EndDataUpdate();
                }
            }
            catch (Exception ex) 
            {
                lg.Error(ex);
            }
            

        }

        private void gridView1_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle != gridView1.FocusedRowHandle && (e.RowHandle % 2 == 0))
                e.Appearance.BackColor = Setting.RowColor();
        }
    }
}
