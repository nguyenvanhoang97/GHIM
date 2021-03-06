﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;
using qlcv.Reponses;
using qlcv.Network;
using log4net;

namespace qlcv
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private ILog lg = LogManager.GetLogger(typeof(frmDoiMatKhau));
        string taikhoan = "";

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(string _taiKhoan)
        {
            taikhoan = _taiKhoan;
            InitializeComponent();
        }
        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string matKhauCu, matKhauMoi, nhapLaiMatKhauMoi;
                matKhauMoi = txtMatKhauMoi.Text;
                nhapLaiMatKhauMoi = txtNhapLaiMatKhau.Text;
                matKhauCu = txtMatKhauCu.Text;
                if (matKhauMoi != nhapLaiMatKhauMoi)
                {
                    lbLoi.Text = "Mật khẩu nhập lại không khớp vui lòng kiểm tra lại!";
                }
                else if (txtMatKhauMoi.Text.Length < 8)
                {
                    lbLoi.Text = "Mật khẩu phải có từ 8 kí tự trở lên!";
                }
                else
                {

                    //Lưu mật khẩu mới nếu khớp
                    StatusRespon status = Retrofit.instance.UserDoiMatKhau(matKhauCu, matKhauMoi);
                    MessageBox.Show(status.Message);
                    if (status.Status)
                    {
                        this.Close();
                    }
                    else
                    {
                        btNhapLai_Click(sender, e);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }

        }
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhauMoi.Text.Trim() != "")
                {
                    string matKhau, matKhauNhapLai;
                    matKhau = txtMatKhauMoi.Text;
                    matKhauNhapLai = txtNhapLaiMatKhau.Text;
                    if (matKhau.Length < 8)
                    {
                        lbMatKhau.Text = "Mật khẩu ngắn thường dễ đoán. \r\nHãy thử mật khẩu có ít nhất 8 ký tự.";
                    }
                    else if (matKhau.Length >= 8)
                    {
                        lbMatKhau.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }
        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNhapLaiMatKhau.Text.Trim() != "")
                {
                    string matKhau, matKhauNhapLai;
                    matKhau = txtMatKhauMoi.Text;
                    matKhauNhapLai = txtNhapLaiMatKhau.Text;
                    if (matKhau != matKhauNhapLai)
                    {
                        lbNhapLaiMK.Text = "Mật khẩu không khớp vui lòng kiểm tra lại!";
                    }
                    else if (matKhau.Equals(matKhauNhapLai))
                    {
                        lbNhapLaiMK.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
           

        }


        private void btNhapLai_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            try
            {
                txtMatKhauCu.ResetText();
                txtMatKhauMoi.ResetText();
                txtNhapLaiMatKhau.ResetText();
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
            
        }

    }
}