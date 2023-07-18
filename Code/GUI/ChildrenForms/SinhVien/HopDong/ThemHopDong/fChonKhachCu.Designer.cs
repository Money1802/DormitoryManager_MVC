namespace GUI.ChildrenForms.KhachTro.HopDong.ThemHopDong
{
    partial class fChonKhachCu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonKhachCu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.cb_soCanCuoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_huy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tenKhach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_soCanCuoc
            // 
            this.cb_soCanCuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_soCanCuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_soCanCuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.cb_soCanCuoc.FormattingEnabled = true;
            this.cb_soCanCuoc.Location = new System.Drawing.Point(192, 42);
            this.cb_soCanCuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_soCanCuoc.Name = "cb_soCanCuoc";
            this.cb_soCanCuoc.Size = new System.Drawing.Size(266, 33);
            this.cb_soCanCuoc.Sorted = true;
            this.cb_soCanCuoc.TabIndex = 0;
            this.cb_soCanCuoc.SelectedIndexChanged += new System.EventHandler(this.cb_soCanCuoc_SelectedIndexChanged);
            this.cb_soCanCuoc.TextChanged += new System.EventHandler(this.cb_soCanCuoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số căn cước";
            // 
            // btn_huy
            // 
            this.btn_huy.AllowToggling = false;
            this.btn_huy.AnimationSpeed = 200;
            this.btn_huy.AutoGenerateColors = false;
            this.btn_huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_huy.BackColor1 = System.Drawing.Color.Crimson;
            this.btn_huy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_huy.BackgroundImage")));
            this.btn_huy.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huy.ButtonText = "Huỷ";
            this.btn_huy.ButtonTextMarginLeft = 0;
            this.btn_huy.ColorContrastOnClick = 45;
            this.btn_huy.ColorContrastOnHover = 45;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_huy.CustomizableEdges = borderEdges1;
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huy.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_huy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_huy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_huy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.IconMarginLeft = 11;
            this.btn_huy.IconPadding = 10;
            this.btn_huy.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.IdleBorderColor = System.Drawing.Color.Crimson;
            this.btn_huy.IdleBorderRadius = 3;
            this.btn_huy.IdleBorderThickness = 1;
            this.btn_huy.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_huy.IdleIconLeftImage = null;
            this.btn_huy.IdleIconRightImage = null;
            this.btn_huy.IndicateFocus = false;
            this.btn_huy.Location = new System.Drawing.Point(56, 229);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_huy.Name = "btn_huy";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_huy.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_huy.OnPressedState = stateProperties2;
            this.btn_huy.Size = new System.Drawing.Size(138, 55);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huy.TextMarginLeft = 0;
            this.btn_huy.UseDefaultRadiusAndThickness = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_them
            // 
            this.btn_them.AllowToggling = false;
            this.btn_them.AnimationSpeed = 200;
            this.btn_them.AutoGenerateColors = false;
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btn_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_them.BackgroundImage")));
            this.btn_them.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_them.ButtonText = "Thêm";
            this.btn_them.ButtonTextMarginLeft = 0;
            this.btn_them.ColorContrastOnClick = 45;
            this.btn_them.ColorContrastOnHover = 45;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_them.CustomizableEdges = borderEdges2;
            this.btn_them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_them.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_them.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_them.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_them.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.IconMarginLeft = 11;
            this.btn_them.IconPadding = 10;
            this.btn_them.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.btn_them.IdleBorderRadius = 3;
            this.btn_them.IdleBorderThickness = 1;
            this.btn_them.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btn_them.IdleIconLeftImage = null;
            this.btn_them.IdleIconRightImage = null;
            this.btn_them.IndicateFocus = false;
            this.btn_them.Location = new System.Drawing.Point(281, 229);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_them.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_them.OnPressedState = stateProperties4;
            this.btn_them.Size = new System.Drawing.Size(178, 55);
            this.btn_them.TabIndex = 1;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.TextMarginLeft = 0;
            this.btn_them.UseDefaultRadiusAndThickness = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách";
            // 
            // lb_tenKhach
            // 
            this.lb_tenKhach.AutoSize = true;
            this.lb_tenKhach.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lb_tenKhach.Location = new System.Drawing.Point(188, 103);
            this.lb_tenKhach.Name = "lb_tenKhach";
            this.lb_tenKhach.Size = new System.Drawing.Size(20, 25);
            this.lb_tenKhach.TabIndex = 1;
            this.lb_tenKhach.Text = "?";
            // 
            // fChonKhachCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lb_tenKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_soCanCuoc);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fChonKhachCu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn thông tin sinh viên cũ";
            this.Load += new System.EventHandler(this.fChonKhachCu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_soCanCuoc;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_them;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tenKhach;
    }
}