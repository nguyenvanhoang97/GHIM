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
    public partial class FrmBaoLoi : Form
    {
        private ILog lg = LogManager.GetLogger(typeof(frmBaoCaoChiTietGhim));
        private string ID;
        public FrmBaoLoi(string id)
        {
            InitializeComponent();
            ID = id;
            LoadMau();
        }
        private void LoadMau()
        {
            layoutControlGroup2.AppearanceGroup.BorderColor = Setting.GroupColor();

        }
        private void btBaoLoi_Click(object sender, EventArgs e)
        {
            try
            {
                BaoLoi bl = new BaoLoi();
                bl.ID = ID;
                bl.SoLoi = Int32.Parse(numericUpDown1.Value.ToString());
                bl.MoTa = tbLoi.Text;
                bl.Deadline = dateDeadline.DateTime;
                StatusRespon s = Retrofit.instance.BaoLoi(bl);
                MessageBox.Show(s.Message);
            }
            catch (Exception ex)
            {
                lg.Error(ex);
            }
           
        }
    }
}
