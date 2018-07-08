
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
using qlcv.Reponses;
using qlcv.Network;

namespace qlcv
{
    public partial class frmBaoCaoChiTietGhim : Form
    {

        public frmBaoCaoChiTietGhim()
        {
            InitializeComponent();
        }

        private void frmBaoCaoAgentToltalCall_Load(object sender, EventArgs e)
        {
            LoadMau();
            LoadNgay(); 
            LoadBaoCao();
            LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            DataTable nguoith = new DataTable();

            List<User> alluser = new List<User>();
            User us = new User();
            us.Name = "Tất cả";
            us.ID = 0;
            
            alluser = Retrofit.instance.getAllUser();
            alluser.Insert(0, us);
            nguoith.Columns.Add("ID", Type.GetType("System.Int32"));
            nguoith.Columns.Add("Name", Type.GetType("System.String"));
            for (int i = 0; i < alluser.Count; i++)
            {
                nguoith.Rows.Add(alluser[i].ID, alluser[i].Name);
            }
            luedNhanVien.Properties.DataSource = nguoith;
            luedNhanVien.Properties.ValueMember = "ID";
            luedNhanVien.Properties.DisplayMember = "Name";
            luedNhanVien.EditValue = 0;
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
                DateTime TuNgay = dateTuNgay.DateTime;
                DateTime DenNgay = dateDenNgay.DateTime;
                int ID_User = 0;
                ID_User = luedNhanVien.EditValue != null ? int.Parse(luedNhanVien.EditValue.ToString()) : 0;
                List<BaoCaoChiTietGhimOBJ> list = Retrofit.instance.BaoCaoChiTietGhim(TuNgay, DenNgay, ID_User);
                gc.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng liên hệ quản trị viên", "Thông báo");
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
