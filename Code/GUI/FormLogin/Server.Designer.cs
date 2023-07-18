
namespace GUI.FormLogin
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cb_Authentication = new System.Windows.Forms.ComboBox();
            this.btn_testconnect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_saveconect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.bnt_sửa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(265, 89);
            this.txt_server.Multiline = true;
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(441, 37);
            this.txt_server.TabIndex = 0;
            this.txt_server.Leave += new System.EventHandler(this.txt_server_Leave);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(37, 89);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(165, 37);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Server Name";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(37, 143);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(189, 37);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Authentication";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(265, 205);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(441, 37);
            this.txt_user.TabIndex = 2;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(37, 205);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(143, 37);
            this.bunifuLabel3.TabIndex = 1;
            this.bunifuLabel3.Text = "User Name";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_pw
            // 
            this.txt_pw.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Location = new System.Drawing.Point(265, 265);
            this.txt_pw.Multiline = true;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(441, 37);
            this.txt_pw.TabIndex = 3;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(37, 265);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(125, 37);
            this.bunifuLabel4.TabIndex = 1;
            this.bunifuLabel4.Text = "Password";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(37, 323);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(119, 37);
            this.bunifuLabel5.TabIndex = 1;
            this.bunifuLabel5.Text = "Database";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cb_Authentication
            // 
            this.cb_Authentication.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Authentication.FormattingEnabled = true;
            this.cb_Authentication.Location = new System.Drawing.Point(265, 143);
            this.cb_Authentication.Name = "cb_Authentication";
            this.cb_Authentication.Size = new System.Drawing.Size(441, 39);
            this.cb_Authentication.TabIndex = 1;
            this.cb_Authentication.SelectedIndexChanged += new System.EventHandler(this.cb_Authentication_SelectedIndexChanged);
            this.cb_Authentication.Leave += new System.EventHandler(this.cb_Authentication_Leave);
            // 
            // btn_testconnect
            // 
            this.btn_testconnect.AllowToggling = false;
            this.btn_testconnect.AnimationSpeed = 200;
            this.btn_testconnect.AutoGenerateColors = false;
            this.btn_testconnect.BackColor = System.Drawing.Color.Transparent;
            this.btn_testconnect.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_testconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_testconnect.BackgroundImage")));
            this.btn_testconnect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_testconnect.ButtonText = "Kiểm tra kết nối";
            this.btn_testconnect.ButtonTextMarginLeft = 0;
            this.btn_testconnect.ColorContrastOnClick = 45;
            this.btn_testconnect.ColorContrastOnHover = 45;
            this.btn_testconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_testconnect.CustomizableEdges = borderEdges1;
            this.btn_testconnect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_testconnect.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_testconnect.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_testconnect.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_testconnect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_testconnect.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testconnect.ForeColor = System.Drawing.Color.Black;
            this.btn_testconnect.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_testconnect.IconMarginLeft = 11;
            this.btn_testconnect.IconPadding = 10;
            this.btn_testconnect.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_testconnect.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_testconnect.IdleBorderRadius = 3;
            this.btn_testconnect.IdleBorderThickness = 1;
            this.btn_testconnect.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_testconnect.IdleIconLeftImage = null;
            this.btn_testconnect.IdleIconRightImage = null;
            this.btn_testconnect.IndicateFocus = false;
            this.btn_testconnect.Location = new System.Drawing.Point(146, 404);
            this.btn_testconnect.Name = "btn_testconnect";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_testconnect.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_testconnect.OnPressedState = stateProperties2;
            this.btn_testconnect.Size = new System.Drawing.Size(244, 51);
            this.btn_testconnect.TabIndex = 5;
            this.btn_testconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_testconnect.TextMarginLeft = 0;
            this.btn_testconnect.UseDefaultRadiusAndThickness = true;
            this.btn_testconnect.Click += new System.EventHandler(this.btn_testconnect_Click);
            // 
            // btn_saveconect
            // 
            this.btn_saveconect.AllowToggling = false;
            this.btn_saveconect.AnimationSpeed = 200;
            this.btn_saveconect.AutoGenerateColors = false;
            this.btn_saveconect.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveconect.BackColor1 = System.Drawing.Color.Aqua;
            this.btn_saveconect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_saveconect.BackgroundImage")));
            this.btn_saveconect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_saveconect.ButtonText = "Lưu cấu hình";
            this.btn_saveconect.ButtonTextMarginLeft = 0;
            this.btn_saveconect.ColorContrastOnClick = 45;
            this.btn_saveconect.ColorContrastOnHover = 45;
            this.btn_saveconect.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_saveconect.CustomizableEdges = borderEdges2;
            this.btn_saveconect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_saveconect.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_saveconect.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_saveconect.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_saveconect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_saveconect.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveconect.ForeColor = System.Drawing.Color.Black;
            this.btn_saveconect.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveconect.IconMarginLeft = 11;
            this.btn_saveconect.IconPadding = 10;
            this.btn_saveconect.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveconect.IdleBorderColor = System.Drawing.Color.Red;
            this.btn_saveconect.IdleBorderRadius = 3;
            this.btn_saveconect.IdleBorderThickness = 1;
            this.btn_saveconect.IdleFillColor = System.Drawing.Color.Aqua;
            this.btn_saveconect.IdleIconLeftImage = null;
            this.btn_saveconect.IdleIconRightImage = null;
            this.btn_saveconect.IndicateFocus = false;
            this.btn_saveconect.Location = new System.Drawing.Point(470, 404);
            this.btn_saveconect.Name = "btn_saveconect";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_saveconect.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_saveconect.OnPressedState = stateProperties4;
            this.btn_saveconect.Size = new System.Drawing.Size(244, 51);
            this.btn_saveconect.TabIndex = 6;
            this.btn_saveconect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_saveconect.TextMarginLeft = 0;
            this.btn_saveconect.UseDefaultRadiusAndThickness = true;
            this.btn_saveconect.Click += new System.EventHandler(this.btn_saveconect_Click);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(286, 11);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(286, 37);
            this.bunifuLabel6.TabIndex = 1;
            this.bunifuLabel6.Text = "CẤU HÌNH SERVER";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_database
            // 
            this.txt_database.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_database.Location = new System.Drawing.Point(265, 323);
            this.txt_database.Multiline = true;
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(441, 37);
            this.txt_database.TabIndex = 3;
            // 
            // bnt_sửa
            // 
            this.bnt_sửa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_sửa.Location = new System.Drawing.Point(371, 367);
            this.bnt_sửa.Name = "bnt_sửa";
            this.bnt_sửa.Size = new System.Drawing.Size(178, 31);
            this.bnt_sửa.TabIndex = 7;
            this.bnt_sửa.Text = "Sửa tên Database";
            this.bnt_sửa.UseVisualStyleBackColor = true;
            this.bnt_sửa.Click += new System.EventHandler(this.btn_suâNme_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 469);
            this.Controls.Add(this.bnt_sửa);
            this.Controls.Add(this.btn_saveconect);
            this.Controls.Add(this.btn_testconnect);
            this.Controls.Add(this.cb_Authentication);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.txt_database);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txt_server);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_server;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.TextBox txt_user;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.TextBox txt_pw;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.ComboBox cb_Authentication;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_testconnect;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_saveconect;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.Button bnt_sửa;
    }
}