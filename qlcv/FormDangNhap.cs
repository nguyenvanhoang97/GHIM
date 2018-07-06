using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using qlcv.Network;
using qlcv.Reponses;

namespace qlcv
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            string username = textBoxTK.Text;
            string password = textBoxMK.Text;
            User login = Retrofit.instance.Login(username, password);
            Console.Write(login);
           
            if (login.status)
            {
                Networking.getInstance().setToken(login.Token);
                frmMain frMenu = new frmMain(login.IsAdmin);
                frMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng","Thông báo");
            }
        }
    }
}
