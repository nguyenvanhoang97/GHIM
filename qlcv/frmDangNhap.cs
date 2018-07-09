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
    public partial class frmDangNhap : Form
    {
        private ILog lg = LogManager.GetLogger(typeof(frmDangNhap));
        public frmDangNhap()
        {
            InitializeComponent();
            
        }
        private void buttonDN_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxTK.Text;
                string password = textBoxMK.Text;
                User login = Retrofit.instance.Login(username, password);
                Console.Write(login);
                if (login != null)
                {
                    if (login.status)
                    {
                        Cache.username = username;
                        Networking.getInstance().setToken(login.Token);
                        frmMain frMenu = new frmMain(login.IsAdmin);
                        frMenu.Show();
                        this.Hide();
                        if (cbGhiNho.Checked)
                        {
                            Properties.Settings.Default.user = username;
                            Properties.Settings.Default.password = password;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.user = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Thông báo");
                    }
                }

            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxTK.Text = Properties.Settings.Default.user;
                textBoxMK.Text = Properties.Settings.Default.password;
                cbGhiNho.Checked = textBoxTK.Text != "" && textBoxMK.Text != "";
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
           
        }
    }
}
