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
    public partial class FrmHTCV : Form
    {
        private ILog lg = LogManager.GetLogger(typeof(FrmHTCV));
        private string ID;
        int IDDuAn=-1;
        public FrmHTCV(string id)
        {
            InitializeComponent();
            ID = id;
            LoadNguoiThucHien();
            LoadTrangThai();
            LoadPhanHe();
            DuAn();
            LoadDataSetGiaTri();
        }
        
        public FrmHTCV(int IDDuAn)
        {
            InitializeComponent();
            this.IDDuAn = IDDuAn;
            LoadNguoiThucHien();
            LoadTrangThai();
            LoadPhanHe();
            DuAn();
            this.Text = "Thêm công việc";
            
        }
        private void LoadDataSetGiaTri()
        {
            try
            {
                //load data set gia tri 
                Work work = Retrofit.instance.getChiTietWork(ID);
                tbHangMuc.Text = work.HangMuc;
                tbMoTa.Text = work.MoTa;
                dateDead.DateTime = work.Deadline;
                dateNgayBD.DateTime = work.NgayBatDau;
                luedNguoiTH.EditValue = work.NguoiThucHien;
                lueDuAn.EditValue = work.IdDuAn;
                lueTrangThai.EditValue = work.Status;
                lookUpEdit1.EditValue = work.PhanHe;
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
        }
        private void AnText()
        {
            tbHangMuc.ResetText();
            tbMoTa.ResetText();
            lookUpEdit1.ResetText();
            luedNguoiTH.ResetText();
            lueDuAn.ResetText();
            
            dateDead.ResetText();
            dateNgayBD.ResetText();
        }
       

        

        private void DuAn()
        {
            try
            {
                List<DuAn> allDuAn = Retrofit.instance.getAllDuAn();
                lueDuAn.Properties.DataSource = allDuAn;
                lueDuAn.Properties.ValueMember = "ID";
                lueDuAn.Properties.DisplayMember = "TenDuAn";
                if (IDDuAn != -1)
                {
                    lueDuAn.EditValue = IDDuAn;
                }
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }
        public void Hien()
        {

        }
        private void LoadNguoiThucHien()
        {
            try
            {
                DataTable nguoith = new DataTable();

                List<User> alluser = Retrofit.instance.getAllUser();


                nguoith.Columns.Add("ID", Type.GetType("System.Int32"));
                nguoith.Columns.Add("Name", Type.GetType("System.String"));
                for (int i = 0; i < alluser.Count; i++)
                {
                    nguoith.Rows.Add(alluser[i].ID, alluser[i].Name);
                }
                luedNguoiTH.Properties.DataSource = nguoith;
                luedNguoiTH.Properties.ValueMember = "ID";
                luedNguoiTH.Properties.DisplayMember = "Name";
                //luedNguoiTH.Properties.PopulateColumns();
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }
        private void LoadTrangThai()
        {
            try
            {
                List<TrangThaiCongViec> allTrangThai = Retrofit.instance.getAllTrangThai();
                lueTrangThai.Properties.DataSource = allTrangThai;
                lueTrangThai.Properties.ValueMember = "ID";
                lueTrangThai.Properties.DisplayMember = "TenTrangThai";
                lueTrangThai.EditValue = 1;
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }

        private void LoadPhanHe()
        {
            try
            {
                List<PhanHe> allPhanHe = Retrofit.instance.getAllPhanHe();
                lookUpEdit1.Properties.DataSource = allPhanHe;
                lookUpEdit1.Properties.ValueMember = "ID";
                lookUpEdit1.Properties.DisplayMember = "TenPhanHe";
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }
        private void btLuu_Click(object sender, EventArgs e)
        {

            try
            {
                if (ID == null)
                {
                    //Thêm công việc
                    Work work = new Work();
                    work.HangMuc = tbHangMuc.Text;
                    work.MoTa = tbMoTa.Text;
                    work.NguoiYeuCau = Retrofit.instance.getLoginUser().ID + "";
                    work.PhanHe = lookUpEdit1.EditValue.ToString();
                    work.Deadline = dateDead.DateTime;
                    work.NgayBatDau = dateNgayBD.DateTime;
                    work.NguoiThucHien = Int32.Parse(luedNguoiTH.EditValue.ToString());
                    work.TenDuAn = lueDuAn.EditValue.ToString();
                    work.Status = lueTrangThai.EditValue.ToString();


                    StatusRespon status = Retrofit.instance.addWork(work);
                    MessageBox.Show(status.Message);
                    AnText();
                }
                else
                {
                    Work work = new Work();
                    work.ID = Int32.Parse(ID);
                    work.IdDuAn = lueDuAn.EditValue.ToString();
                    work.HangMuc = tbHangMuc.Text;
                    work.MoTa = tbMoTa.Text;
                    work.NguoiYeuCau = Retrofit.instance.getLoginUser().ID + "";
                    work.PhanHe = lookUpEdit1.EditValue.ToString();
                    work.Deadline = dateDead.DateTime;
                    work.NgayBatDau = dateNgayBD.DateTime;
                    work.NguoiThucHien = Int32.Parse(luedNguoiTH.EditValue.ToString());
                    work.TenDuAn = lueDuAn.EditValue.ToString();
                    work.Status = lueTrangThai.EditValue.ToString();
                    StatusRespon status = Retrofit.instance.updateWork(work);
                    MessageBox.Show(status.Message);
                }
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }
    }
}
