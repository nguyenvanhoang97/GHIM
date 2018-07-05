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
    public partial class FrmBC : Form
    {
        private string ID;
        public FrmBC(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void btKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCo_Click(object sender, EventArgs e)
        {
            StatusRespon status = Retrofit.instance.doneWork(ID);
            MessageBox.Show(status.Message);
            this.Close();
        }
    }
}
