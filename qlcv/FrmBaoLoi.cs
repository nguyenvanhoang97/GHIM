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
    public partial class FrmBaoLoi : Form
    {
        private string ID;
        public FrmBaoLoi(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void btBaoLoi_Click(object sender, EventArgs e)
        {
            BaoLoi bl = new BaoLoi();
            bl.ID = ID;
            bl.SoLoi = Int32.Parse(tbSoLoi.Text);
            bl.MoTa = tbLoi.Text;
            bl.Deadline = dateDeadline.DateTime;
            StatusRespon s = Retrofit.instance.BaoLoi(bl);
            MessageBox.Show(s.Message);
        }
    }
}
