using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using qlcv.Network;
using qlcv.Reponses;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using log4net;

namespace qlcv
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ILog lg = LogManager.GetLogger(typeof(FrmQLCV));
        bool IsAdmin;
        public frmMain(bool IsAdmin)
        {
            InitializeComponent();
            this.IsAdmin = IsAdmin;
            LoadNgay();
            LoadPhanQuyen();
            LoadMau();
        }
        private void LoadNgayGioHeThong()
        {
            try
            {
                DateTime now = DateTime.Now;
                txtNgayGioHeThong.Caption = now.ToString("HH:mm:ss   dd-MM-yyyy");
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
           
        }
        private void LoadPhanQuyen()
        {
            try
            {
                txtTaiKhoan.Caption = "Chúc " + Cache.username + " có một ngày tốt lành!";
                if (!IsAdmin)
                {
                    btCongViec.Enabled = false;
                    btDuAn.Enabled = false;
                    btNhanVien.Enabled = false;

                }
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
        private void LoadNgay()
        {
            deTuNgay.DateTime = DateTime.Today;
            deDenNgay.DateTime = DateTime.Today.AddDays(1).AddTicks(-1);
        }
        List<Ghim> listGhim = new List<Ghim>();
        private void LoadBieuDo()
        {
            try
            {
                listGhim = Retrofit.instance.Ghim(deTuNgay.DateTime, deDenNgay.DateTime);
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
            WaitDialogForm wait = new DevExpress.Utils.WaitDialogForm("Phần mềm đang tải dữ liệu....", "Vui lòng chờ");
            try
            {

                wait.Show();
                chartBieuDo.Series.Clear();
                chartBieuDo.Titles.Clear();
                chartBieuDo.DataSource = listGhim;
                // Create four side-by-side stacked bar series.
                Series series1 = new Series("Ghim", ViewType.StackedBar);
                for (int i = 0; i < listGhim.Count; i++)
                {
                    series1.Points.Add(new SeriesPoint(listGhim[i].Name, listGhim[i].SoGhim));
                }
                // Add all series to the chart.
                chartBieuDo.Series.AddRange(new Series[] { series1, });
                // Access the type-specific options of the diagram.
                if (listGhim.Count > 0)
                {
                    // Access the view-type-specific options of the series.
                    ((StackedBarSeriesView)series1.View).BarWidth = 0.8;

                    // Access the type-specific options of the diagram.
                    ((XYDiagram)chartBieuDo.Diagram).EnableAxisXZooming = true;
                }


                // Hide the legend (if necessary).
                chartBieuDo.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

                // Add a title to the chart (if necessary).
                chartBieuDo.Titles.Add(new ChartTitle());
                chartBieuDo.Titles[0].Text = "";
                chartBieuDo.Titles[0].WordWrap = true;

                //Add the chart to the form.
                chartBieuDo.Dock = DockStyle.Fill;





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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQLCV frmCV = new FrmQLCV();
            frmCV.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDuAn frmDA = new FrmDuAn();
            frmDA.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadBieuDo();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmBaoCao frmBC = new FrmBaoCao();
            frmBC.Show();
        }

        private void btBaoCaoTongHopGhim_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCaoTongHopGhim frm = new frmBaoCaoTongHopGhim();
            frm.Show();
        }

        private void btLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txtNgayGioHeThong.Caption = now.ToString("HH:mm:ss   dd-MM-yyyy");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadBieuDo();
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void btBaoCaoChiTietGhim_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCaoChiTietGhim frm = new frmBaoCaoChiTietGhim();
            frm.Show();
        }
    }
}