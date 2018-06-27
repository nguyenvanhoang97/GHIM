namespace qlcv
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btDangNhap);
            this.layoutControl1.Controls.Add(this.textBoxMK);
            this.layoutControl1.Controls.Add(this.textBoxTK);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(730, 195, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(389, 224);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btDangNhap
            // 
            this.btDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.Appearance.Options.UseFont = true;
            this.btDangNhap.ImageOptions.Image = global::qlcv.Properties.Resources.icons8_key_24;
            this.btDangNhap.Location = new System.Drawing.Point(157, 129);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(152, 31);
            this.btDangNhap.StyleController = this.layoutControl1;
            this.btDangNhap.TabIndex = 7;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.Click += new System.EventHandler(this.buttonDN_Click);
            // 
            // textBoxMK
            // 
            this.textBoxMK.Location = new System.Drawing.Point(148, 97);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(161, 20);
            this.textBoxMK.TabIndex = 5;
            this.textBoxMK.Text = "1";
            this.textBoxMK.UseSystemPasswordChar = true;
            // 
            // textBoxTK
            // 
            this.textBoxTK.Location = new System.Drawing.Point(148, 67);
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(161, 20);
            this.textBoxTK.TabIndex = 4;
            this.textBoxTK.Text = "1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.Color.LightSkyBlue;
            this.layoutControlGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 20D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 20D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 20D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 20D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5});
            rowDefinition1.Height = 50D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 30D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 30D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 5D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 35D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 50D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(389, 224);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.textBoxTK;
            this.layoutControlItem1.Location = new System.Drawing.Point(77, 62);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(234, 30);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 0);
            this.layoutControlItem1.Text = "Tài khoản:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.textBoxMK;
            this.layoutControlItem2.Location = new System.Drawing.Point(77, 92);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(234, 30);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 0);
            this.layoutControlItem2.Text = "Mật khẩu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btDangNhap;
            this.layoutControlItem3.Location = new System.Drawing.Point(155, 127);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem3.Size = new System.Drawing.Size(156, 35);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 224);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btDangNhap;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.TextBox textBoxTK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

