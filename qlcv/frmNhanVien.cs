using qlcv.Network;
using qlcv.objClass;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        string id;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadGioiTinh();
            LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            List<User> alluser = Retrofit.instance.getAllUser();
            for (int i = 0; i < alluser.Count; i++)
            {
                if (alluser[i].SoDienThoai == null)
                {
                    alluser[i].SoDienThoai = "";
                }
                if (alluser[i].DiaChi == null)
                {
                    alluser[i].DiaChi = "";
                }
                if (alluser[i].GioiTinh)
                {
                    alluser[i].gt = "Nam";
                }
                else
                {
                    alluser[i].gt = "Nữ";
                }
            }

            gridControl1.DataSource = alluser;
        }
        private void LoadGioiTinh()
        {
            List<GioiTinh> listGioiTinh = new List<GioiTinh>();
            listGioiTinh.Add(new GioiTinh(0, "Nam"));
            listGioiTinh.Add(new GioiTinh(1, "Nữ"));
            lueGender.Properties.DataSource = listGioiTinh;
            lueGender.Properties.ValueMember = "ID";
            lueGender.Properties.DisplayMember = "gt";
            lueGender.EditValue = "1";
        }
        private void simpleButton2_Click(object sender, EventArgs e)//Button lưu thông tin nhân viên
        {
            if(checkThem)
            {
                //Thêm người dùng mới
                User user = new User(tbName.Text, tbAddress.Text, tbMail.Text, tbUsername.Text, tbPass.Text,
                cbIsAd.Checked, tbPhone.Text, deNgaySinh.DateTime, lueGender.EditValue.ToString() == "0" ? false : true);
                user.ThemDuAn = cbThemDA.Checked;
                StatusRespon status = Retrofit.instance.addUser(user);
                MessageBox.Show(status.Message);
                LoadNhanVien();
                An();
            }
            else
            {
                //Sửa người dùng
                User user = new User(tbName.Text, tbAddress.Text, tbMail.Text, tbUsername.Text, tbPass.Text,
                cbIsAd.Checked, tbPhone.Text, deNgaySinh.DateTime, lueGender.EditValue.ToString() == "0" ? false : true);
                user.ThemDuAn = cbThemDA.Checked;
                user.ID = Int32.Parse(id);
                StatusRespon status = Retrofit.instance.updateUser(user);
                LoadNhanVien();
                An();
            }
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
               id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name").ToString();
                string diaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
                string mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mail").ToString();
                string username = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username").ToString();
                string pass = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Password").ToString();
                bool isAdmin = bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IsAdmin").ToString());
                string soDienThoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoDienThoai").ToString();
                bool gioiTinh = bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString());
                DateTime ngaySinh = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString());

                tbName.Text = name;
                tbAddress.Text = diaChi;
                tbMail.Text = mail;
                tbUsername.Text = username;
                tbPass.Text = pass;
                cbIsAd.Checked = isAdmin;
                tbPhone.Text = soDienThoai;
                int gt = 0;
                if (!gioiTinh)
                {
                    gt = 1;
                }
                lueGender.EditValue = gt;
                deNgaySinh.DateTime = ngaySinh;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name").ToString();
            DialogResult result = MessageBox.Show("Xóa  "+name+"?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                User user = new User();
                user.ID = Int32.Parse(id);
                StatusRespon status = Retrofit.instance.deleteUser(user);
                if (status.Status)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Không xóa được User này");
                }
                LoadNhanVien();
            }
            
        }

        private void Hien()
        {
            tbName.Enabled = true;
            tbAddress.Enabled = true;
            tbMail.Enabled = true;
            tbPass.Enabled = true;
            tbPhone.Enabled = true;
            tbUsername.Enabled = true;
            deNgaySinh.Enabled = true;
            cbIsAd.Enabled = true;
            lueGender.Enabled = true;
            cbThemDA.Enabled = true;
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }
        private void An()
        {
            tbName.Enabled = false;
            tbAddress.Enabled = false;
            tbMail.Enabled = false;
            tbPass.Enabled = false;
            tbPhone.Enabled = false;
            tbUsername.Enabled = false;
            deNgaySinh.Enabled = false;
            cbIsAd.Enabled = false;
            lueGender.Enabled = false;
            cbThemDA.Enabled = false;
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        bool checkThem;
        private object userLogin;

        private void sbThem_Click(object sender, EventArgs e)
        {
            Hien();
            tbName.ResetText();
            tbAddress.ResetText();
            tbMail.ResetText();
            tbPass.ResetText();
            tbPhone.ResetText();
            tbUsername.ResetText();
            lueGender.ResetText();
            deNgaySinh.ResetText();
            checkThem = true;
            
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
            //tbName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name").ToString();
            //bool gioiTinh = bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString());
            //int gt = 0;
            //if (!gioiTinh)
            //{
            //    gt = 1;
            //}
            //lueGender.EditValue = gt;
            //tbAddress.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            //tbMail.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mail").ToString();
            //tbPass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Password").ToString();
            //tbUsername.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username").ToString();
            //tbPhone.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoDienThoai").ToString();
            //deNgaySinh.DateTime = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString());
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            checkThem = false;
            
            Hien();
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
    }
}
