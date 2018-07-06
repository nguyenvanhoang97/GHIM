
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace qlcv
{
    public partial class frmBaoCaoTongHopGhim : Form
    {

        public frmBaoCaoTongHopGhim()
        {
            InitializeComponent();
        }

        private void frmBaoCaoAgentToltalCall_Load(object sender, EventArgs e)
        {
            LoadMau();
            LoadNgay(); 
            LoadBaoCao();
        }

        private void LoadMau()
        {
            layoutDanhSachBaoCao.AppearanceGroup.BorderColor = Setting.GroupColor();
            layoutLocBaoCao.AppearanceGroup.BorderColor = Setting.GroupColor();
        }

        private void LoadNgay()
        {
            dateTuNgay.DateTime = DateTime.Today;
            dateDenNgay.DateTime = DateTime.Today.AddDays(1).AddTicks(-1);
        }

        private void btXemBaoCao_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void LoadBaoCao()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
               
            }
        }

        private void gv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gv_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle != gv.FocusedRowHandle && (e.RowHandle % 2 == 0))
                e.Appearance.BackColor = Setting.RowColor();
        }

        private void btXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Setting.XuatExcelv2Ten("BaoCaoTongHopGhim_" + DateTime.Now.ToString("ddMMyyyyHHmmss"), gv, gc);
            }
            catch (Exception ex)
            {
                
            }
        }
        
    }
}
