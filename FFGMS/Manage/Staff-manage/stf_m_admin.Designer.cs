namespace FFGMS.Manage.Staff_manage
{
    partial class stf_m_admin
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
            this.components = new System.ComponentModel.Container();
            this.st_add_admin = new MetroFramework.Controls.MetroTabPage();
            this.table_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sel_img_btn = new Guna.UI.WinForms.GunaButton();
            this.img_picb = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gender_gbx = new Guna.UI.WinForms.GunaGroupBox();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txb = new MetroFramework.Controls.MetroTextBox();
            this.sal_txb = new MetroFramework.Controls.MetroTextBox();
            this.age_lbl = new System.Windows.Forms.Label();
            this.sal_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.uname_txb = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_txb = new MetroFramework.Controls.MetroTextBox();
            this.uname_lbl = new System.Windows.Forms.Label();
            this.pho_txb = new MetroFramework.Controls.MetroTextBox();
            this.adr_lbl = new System.Windows.Forms.Label();
            this.pho_lbl = new System.Windows.Forms.Label();
            this.img_lbl = new System.Windows.Forms.Label();
            this.btn_grbx = new Guna.UI.WinForms.GunaGroupBox();
            this.erase_btn = new Guna.UI.WinForms.GunaButton();
            this.add_btn = new Guna.UI.WinForms.GunaButton();
            this.pass_txb = new MetroFramework.Controls.MetroTextBox();
            this.adr_txb = new MetroFramework.Controls.MetroTextBox();
            this.age_txb = new MetroFramework.Controls.MetroTextBox();
            this.type_cobx = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.st_tab_admin = new MetroFramework.Controls.MetroTabControl();
            this.gr_view_admin = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.st_add_admin.SuspendLayout();
            this.table_pnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_picb)).BeginInit();
            this.gender_gbx.SuspendLayout();
            this.btn_grbx.SuspendLayout();
            this.st_tab_admin.SuspendLayout();
            this.gr_view_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // st_add_admin
            // 
            this.st_add_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.st_add_admin.Controls.Add(this.table_pnl);
            this.st_add_admin.Controls.Add(this.panel1);
            this.st_add_admin.HorizontalScrollbarBarColor = true;
            this.st_add_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.st_add_admin.HorizontalScrollbarSize = 8;
            this.st_add_admin.Location = new System.Drawing.Point(4, 44);
            this.st_add_admin.Margin = new System.Windows.Forms.Padding(2);
            this.st_add_admin.Name = "st_add_admin";
            this.st_add_admin.Size = new System.Drawing.Size(545, 306);
            this.st_add_admin.Style = MetroFramework.MetroColorStyle.Black;
            this.st_add_admin.TabIndex = 0;
            this.st_add_admin.Text = "Add Staff";
            this.st_add_admin.UseStyleColors = true;
            this.st_add_admin.VerticalScrollbarBarColor = true;
            this.st_add_admin.VerticalScrollbarHighlightOnWheel = false;
            this.st_add_admin.VerticalScrollbarSize = 8;
            this.st_add_admin.Click += new System.EventHandler(this.st_add_admin_Click);
            // 
            // table_pnl
            // 
            this.table_pnl.AutoSize = true;
            this.table_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table_pnl.BackColor = System.Drawing.Color.Transparent;
            this.table_pnl.ColumnCount = 4;
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.98844F));
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.01156F));
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.table_pnl.Controls.Add(this.panel3, 1, 2);
            this.table_pnl.Controls.Add(this.gender_gbx, 1, 5);
            this.table_pnl.Controls.Add(this.gender_lbl, 0, 5);
            this.table_pnl.Controls.Add(this.name_lbl, 0, 0);
            this.table_pnl.Controls.Add(this.name_txb, 1, 0);
            this.table_pnl.Controls.Add(this.sal_txb, 1, 4);
            this.table_pnl.Controls.Add(this.age_lbl, 0, 1);
            this.table_pnl.Controls.Add(this.sal_lbl, 0, 4);
            this.table_pnl.Controls.Add(this.label3, 0, 3);
            this.table_pnl.Controls.Add(this.email_lbl, 2, 0);
            this.table_pnl.Controls.Add(this.uname_txb, 3, 3);
            this.table_pnl.Controls.Add(this.label2, 2, 4);
            this.table_pnl.Controls.Add(this.email_txb, 3, 0);
            this.table_pnl.Controls.Add(this.uname_lbl, 2, 3);
            this.table_pnl.Controls.Add(this.pho_txb, 3, 1);
            this.table_pnl.Controls.Add(this.adr_lbl, 2, 2);
            this.table_pnl.Controls.Add(this.pho_lbl, 2, 1);
            this.table_pnl.Controls.Add(this.img_lbl, 0, 2);
            this.table_pnl.Controls.Add(this.btn_grbx, 3, 5);
            this.table_pnl.Controls.Add(this.pass_txb, 3, 4);
            this.table_pnl.Controls.Add(this.adr_txb, 3, 2);
            this.table_pnl.Controls.Add(this.age_txb, 1, 1);
            this.table_pnl.Controls.Add(this.type_cobx, 1, 3);
            this.table_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_pnl.Location = new System.Drawing.Point(0, 40);
            this.table_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.table_pnl.Name = "table_pnl";
            this.table_pnl.RowCount = 6;
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table_pnl.Size = new System.Drawing.Size(545, 268);
            this.table_pnl.TabIndex = 67;
            this.table_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.table_pnl_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.img_picb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(62, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 117);
            this.panel3.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sel_img_btn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(163, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 117);
            this.panel4.TabIndex = 0;
            // 
            // sel_img_btn
            // 
            this.sel_img_btn.AnimationHoverSpeed = 0.07F;
            this.sel_img_btn.AnimationSpeed = 0.03F;
            this.sel_img_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.sel_img_btn.BorderColor = System.Drawing.Color.Black;
            this.sel_img_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sel_img_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sel_img_btn.FocusedColor = System.Drawing.Color.Empty;
            this.sel_img_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_img_btn.ForeColor = System.Drawing.Color.White;
            this.sel_img_btn.Image = global::FFGMS.Properties.Resources.icons8_plus_32;
            this.sel_img_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sel_img_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.sel_img_btn.Location = new System.Drawing.Point(0, 0);
            this.sel_img_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sel_img_btn.Name = "sel_img_btn";
            this.sel_img_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sel_img_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sel_img_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.sel_img_btn.OnHoverImage = null;
            this.sel_img_btn.OnPressedColor = System.Drawing.Color.Black;
            this.sel_img_btn.Size = new System.Drawing.Size(26, 19);
            this.sel_img_btn.TabIndex = 1;
            this.sel_img_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sel_img_btn.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // img_picb
            // 
            this.img_picb.BackColor = System.Drawing.Color.Transparent;
            this.img_picb.BaseColor = System.Drawing.Color.White;
            this.img_picb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_picb.Image = global::FFGMS.Properties.Resources.icons8_prelum_100_2;
            this.img_picb.Location = new System.Drawing.Point(0, 0);
            this.img_picb.Margin = new System.Windows.Forms.Padding(2);
            this.img_picb.Name = "img_picb";
            this.img_picb.Size = new System.Drawing.Size(189, 117);
            this.img_picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_picb.TabIndex = 61;
            this.img_picb.TabStop = false;
            this.img_picb.UseTransfarantBackground = false;
            // 
            // gender_gbx
            // 
            this.gender_gbx.BackColor = System.Drawing.Color.Transparent;
            this.gender_gbx.BaseColor = System.Drawing.Color.White;
            this.gender_gbx.BorderColor = System.Drawing.Color.Transparent;
            this.gender_gbx.Controls.Add(this.radio_male);
            this.gender_gbx.Controls.Add(this.radio_female);
            this.gender_gbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gender_gbx.LineColor = System.Drawing.Color.Transparent;
            this.gender_gbx.Location = new System.Drawing.Point(62, 242);
            this.gender_gbx.Margin = new System.Windows.Forms.Padding(2);
            this.gender_gbx.Name = "gender_gbx";
            this.gender_gbx.Size = new System.Drawing.Size(189, 24);
            this.gender_gbx.TabIndex = 65;
            this.gender_gbx.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Dock = System.Windows.Forms.DockStyle.Left;
            this.radio_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radio_male.Location = new System.Drawing.Point(0, 0);
            this.radio_male.Margin = new System.Windows.Forms.Padding(2);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(52, 24);
            this.radio_male.TabIndex = 1;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Dock = System.Windows.Forms.DockStyle.Right;
            this.radio_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radio_female.Location = new System.Drawing.Point(124, 0);
            this.radio_female.Margin = new System.Windows.Forms.Padding(2);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(65, 24);
            this.radio_female.TabIndex = 0;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // gender_lbl
            // 
            this.gender_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.BackColor = System.Drawing.Color.Transparent;
            this.gender_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.gender_lbl.Location = new System.Drawing.Point(2, 240);
            this.gender_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(56, 28);
            this.gender_lbl.TabIndex = 9;
            this.gender_lbl.Text = "Gender:";
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.name_lbl.Location = new System.Drawing.Point(2, 0);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(56, 29);
            this.name_lbl.TabIndex = 43;
            this.name_lbl.Text = "Name:";
            // 
            // name_txb
            // 
            // 
            // 
            // 
            this.name_txb.CustomButton.Image = null;
            this.name_txb.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.name_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.name_txb.CustomButton.Name = "";
            this.name_txb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.name_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_txb.CustomButton.TabIndex = 1;
            this.name_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_txb.CustomButton.UseSelectable = true;
            this.name_txb.CustomButton.Visible = false;
            this.name_txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_txb.Lines = new string[0];
            this.name_txb.Location = new System.Drawing.Point(62, 2);
            this.name_txb.Margin = new System.Windows.Forms.Padding(2);
            this.name_txb.MaxLength = 32767;
            this.name_txb.Name = "name_txb";
            this.name_txb.PasswordChar = '\0';
            this.name_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_txb.SelectedText = "";
            this.name_txb.SelectionLength = 0;
            this.name_txb.SelectionStart = 0;
            this.name_txb.ShortcutsEnabled = true;
            this.name_txb.Size = new System.Drawing.Size(189, 25);
            this.name_txb.TabIndex = 44;
            this.name_txb.UseSelectable = true;
            this.name_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.name_txb.Click += new System.EventHandler(this.name_txb_Click_1);
            // 
            // sal_txb
            // 
            // 
            // 
            // 
            this.sal_txb.CustomButton.Image = null;
            this.sal_txb.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.sal_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.sal_txb.CustomButton.Name = "";
            this.sal_txb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.sal_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sal_txb.CustomButton.TabIndex = 1;
            this.sal_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sal_txb.CustomButton.UseSelectable = true;
            this.sal_txb.CustomButton.Visible = false;
            this.sal_txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sal_txb.Lines = new string[0];
            this.sal_txb.Location = new System.Drawing.Point(62, 213);
            this.sal_txb.Margin = new System.Windows.Forms.Padding(2);
            this.sal_txb.MaxLength = 32767;
            this.sal_txb.Name = "sal_txb";
            this.sal_txb.PasswordChar = '\0';
            this.sal_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sal_txb.SelectedText = "";
            this.sal_txb.SelectionLength = 0;
            this.sal_txb.SelectionStart = 0;
            this.sal_txb.ShortcutsEnabled = true;
            this.sal_txb.Size = new System.Drawing.Size(189, 25);
            this.sal_txb.TabIndex = 59;
            this.sal_txb.UseSelectable = true;
            this.sal_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sal_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // age_lbl
            // 
            this.age_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.age_lbl.AutoSize = true;
            this.age_lbl.BackColor = System.Drawing.Color.Transparent;
            this.age_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.age_lbl.Location = new System.Drawing.Point(2, 29);
            this.age_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(56, 29);
            this.age_lbl.TabIndex = 45;
            this.age_lbl.Text = "Age:";
            // 
            // sal_lbl
            // 
            this.sal_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sal_lbl.AutoSize = true;
            this.sal_lbl.BackColor = System.Drawing.Color.Transparent;
            this.sal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.sal_lbl.Location = new System.Drawing.Point(2, 211);
            this.sal_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sal_lbl.Name = "sal_lbl";
            this.sal_lbl.Size = new System.Drawing.Size(56, 29);
            this.sal_lbl.TabIndex = 58;
            this.sal_lbl.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(2, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 62;
            this.label3.Text = "Type:";
            // 
            // email_lbl
            // 
            this.email_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.Color.Transparent;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.email_lbl.Location = new System.Drawing.Point(255, 0);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(77, 29);
            this.email_lbl.TabIndex = 47;
            this.email_lbl.Text = "Email:";
            // 
            // uname_txb
            // 
            this.uname_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.uname_txb.CustomButton.Image = null;
            this.uname_txb.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.uname_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.uname_txb.CustomButton.Name = "";
            this.uname_txb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.uname_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uname_txb.CustomButton.TabIndex = 1;
            this.uname_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uname_txb.CustomButton.UseSelectable = true;
            this.uname_txb.CustomButton.Visible = false;
            this.uname_txb.Lines = new string[0];
            this.uname_txb.Location = new System.Drawing.Point(336, 181);
            this.uname_txb.Margin = new System.Windows.Forms.Padding(2);
            this.uname_txb.MaxLength = 32767;
            this.uname_txb.Name = "uname_txb";
            this.uname_txb.PasswordChar = '\0';
            this.uname_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uname_txb.SelectedText = "";
            this.uname_txb.SelectionLength = 0;
            this.uname_txb.SelectionStart = 0;
            this.uname_txb.ShortcutsEnabled = true;
            this.uname_txb.Size = new System.Drawing.Size(207, 28);
            this.uname_txb.TabIndex = 52;
            this.uname_txb.UseSelectable = true;
            this.uname_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uname_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(255, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Password:";
            // 
            // email_txb
            // 
            this.email_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.email_txb.CustomButton.Image = null;
            this.email_txb.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.email_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.email_txb.CustomButton.Name = "";
            this.email_txb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.email_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email_txb.CustomButton.TabIndex = 1;
            this.email_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email_txb.CustomButton.UseSelectable = true;
            this.email_txb.CustomButton.Visible = false;
            this.email_txb.Lines = new string[0];
            this.email_txb.Location = new System.Drawing.Point(336, 2);
            this.email_txb.Margin = new System.Windows.Forms.Padding(2);
            this.email_txb.MaxLength = 32767;
            this.email_txb.Name = "email_txb";
            this.email_txb.PasswordChar = '\0';
            this.email_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email_txb.SelectedText = "";
            this.email_txb.SelectionLength = 0;
            this.email_txb.SelectionStart = 0;
            this.email_txb.ShortcutsEnabled = true;
            this.email_txb.Size = new System.Drawing.Size(207, 25);
            this.email_txb.TabIndex = 48;
            this.email_txb.UseSelectable = true;
            this.email_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uname_lbl
            // 
            this.uname_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uname_lbl.AutoSize = true;
            this.uname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.uname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.uname_lbl.Location = new System.Drawing.Point(255, 179);
            this.uname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uname_lbl.Name = "uname_lbl";
            this.uname_lbl.Size = new System.Drawing.Size(77, 32);
            this.uname_lbl.TabIndex = 51;
            this.uname_lbl.Text = "User Name:";
            // 
            // pho_txb
            // 
            this.pho_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.pho_txb.CustomButton.Image = null;
            this.pho_txb.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.pho_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.pho_txb.CustomButton.Name = "";
            this.pho_txb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.pho_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pho_txb.CustomButton.TabIndex = 1;
            this.pho_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pho_txb.CustomButton.UseSelectable = true;
            this.pho_txb.CustomButton.Visible = false;
            this.pho_txb.Lines = new string[0];
            this.pho_txb.Location = new System.Drawing.Point(336, 31);
            this.pho_txb.Margin = new System.Windows.Forms.Padding(2);
            this.pho_txb.MaxLength = 32767;
            this.pho_txb.Name = "pho_txb";
            this.pho_txb.PasswordChar = '\0';
            this.pho_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pho_txb.SelectedText = "";
            this.pho_txb.SelectionLength = 0;
            this.pho_txb.SelectionStart = 0;
            this.pho_txb.ShortcutsEnabled = true;
            this.pho_txb.Size = new System.Drawing.Size(207, 25);
            this.pho_txb.TabIndex = 57;
            this.pho_txb.UseSelectable = true;
            this.pho_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pho_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // adr_lbl
            // 
            this.adr_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adr_lbl.AutoSize = true;
            this.adr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.adr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adr_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.adr_lbl.Location = new System.Drawing.Point(255, 58);
            this.adr_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adr_lbl.Name = "adr_lbl";
            this.adr_lbl.Size = new System.Drawing.Size(77, 121);
            this.adr_lbl.TabIndex = 49;
            this.adr_lbl.Text = "Address:";
            // 
            // pho_lbl
            // 
            this.pho_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pho_lbl.AutoSize = true;
            this.pho_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pho_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pho_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.pho_lbl.Location = new System.Drawing.Point(255, 29);
            this.pho_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pho_lbl.Name = "pho_lbl";
            this.pho_lbl.Size = new System.Drawing.Size(77, 29);
            this.pho_lbl.TabIndex = 56;
            this.pho_lbl.Text = "Phone:";
            // 
            // img_lbl
            // 
            this.img_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_lbl.AutoSize = true;
            this.img_lbl.BackColor = System.Drawing.Color.Transparent;
            this.img_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.img_lbl.Location = new System.Drawing.Point(2, 58);
            this.img_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.img_lbl.Name = "img_lbl";
            this.img_lbl.Size = new System.Drawing.Size(56, 121);
            this.img_lbl.TabIndex = 60;
            this.img_lbl.Text = "Image:";
            // 
            // btn_grbx
            // 
            this.btn_grbx.BackColor = System.Drawing.Color.Transparent;
            this.btn_grbx.BaseColor = System.Drawing.Color.White;
            this.btn_grbx.BorderColor = System.Drawing.Color.Transparent;
            this.btn_grbx.Controls.Add(this.erase_btn);
            this.btn_grbx.Controls.Add(this.add_btn);
            this.btn_grbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_grbx.LineColor = System.Drawing.Color.Transparent;
            this.btn_grbx.Location = new System.Drawing.Point(336, 242);
            this.btn_grbx.Margin = new System.Windows.Forms.Padding(2);
            this.btn_grbx.Name = "btn_grbx";
            this.btn_grbx.Size = new System.Drawing.Size(207, 24);
            this.btn_grbx.TabIndex = 64;
            this.btn_grbx.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // erase_btn
            // 
            this.erase_btn.AnimationHoverSpeed = 0.07F;
            this.erase_btn.AnimationSpeed = 0.03F;
            this.erase_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.erase_btn.BorderColor = System.Drawing.Color.Black;
            this.erase_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.erase_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.erase_btn.FocusedColor = System.Drawing.Color.Empty;
            this.erase_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erase_btn.ForeColor = System.Drawing.Color.White;
            this.erase_btn.Image = global::FFGMS.Properties.Resources.icons8_erase_32;
            this.erase_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.erase_btn.Location = new System.Drawing.Point(0, 0);
            this.erase_btn.Margin = new System.Windows.Forms.Padding(2);
            this.erase_btn.Name = "erase_btn";
            this.erase_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.erase_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.erase_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.erase_btn.OnHoverImage = null;
            this.erase_btn.OnPressedColor = System.Drawing.Color.Black;
            this.erase_btn.Size = new System.Drawing.Size(86, 24);
            this.erase_btn.TabIndex = 1;
            this.erase_btn.Text = "Erase";
            this.erase_btn.Click += new System.EventHandler(this.erase_btn_Click_1);
            // 
            // add_btn
            // 
            this.add_btn.AnimationHoverSpeed = 0.07F;
            this.add_btn.AnimationSpeed = 0.03F;
            this.add_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.add_btn.BorderColor = System.Drawing.Color.Black;
            this.add_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.add_btn.FocusedColor = System.Drawing.Color.Empty;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Image = global::FFGMS.Properties.Resources.icons8_plus_32;
            this.add_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.add_btn.Location = new System.Drawing.Point(122, 0);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.add_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_btn.OnHoverImage = null;
            this.add_btn.OnPressedColor = System.Drawing.Color.Black;
            this.add_btn.Size = new System.Drawing.Size(85, 24);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // pass_txb
            // 
            this.pass_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.pass_txb.CustomButton.Image = null;
            this.pass_txb.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.pass_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.pass_txb.CustomButton.Name = "";
            this.pass_txb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.pass_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass_txb.CustomButton.TabIndex = 1;
            this.pass_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass_txb.CustomButton.UseSelectable = true;
            this.pass_txb.CustomButton.Visible = false;
            this.pass_txb.Lines = new string[0];
            this.pass_txb.Location = new System.Drawing.Point(336, 213);
            this.pass_txb.Margin = new System.Windows.Forms.Padding(2);
            this.pass_txb.MaxLength = 32767;
            this.pass_txb.Name = "pass_txb";
            this.pass_txb.PasswordChar = '\0';
            this.pass_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass_txb.SelectedText = "";
            this.pass_txb.SelectionLength = 0;
            this.pass_txb.SelectionStart = 0;
            this.pass_txb.ShortcutsEnabled = true;
            this.pass_txb.Size = new System.Drawing.Size(207, 25);
            this.pass_txb.TabIndex = 54;
            this.pass_txb.UseSelectable = true;
            this.pass_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // adr_txb
            // 
            this.adr_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.adr_txb.CustomButton.Image = null;
            this.adr_txb.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.adr_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.adr_txb.CustomButton.Name = "";
            this.adr_txb.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.adr_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adr_txb.CustomButton.TabIndex = 1;
            this.adr_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adr_txb.CustomButton.UseSelectable = true;
            this.adr_txb.CustomButton.Visible = false;
            this.adr_txb.Lines = new string[0];
            this.adr_txb.Location = new System.Drawing.Point(336, 60);
            this.adr_txb.Margin = new System.Windows.Forms.Padding(2);
            this.adr_txb.MaxLength = 32767;
            this.adr_txb.Multiline = true;
            this.adr_txb.Name = "adr_txb";
            this.adr_txb.PasswordChar = '\0';
            this.adr_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adr_txb.SelectedText = "";
            this.adr_txb.SelectionLength = 0;
            this.adr_txb.SelectionStart = 0;
            this.adr_txb.ShortcutsEnabled = true;
            this.adr_txb.Size = new System.Drawing.Size(207, 117);
            this.adr_txb.TabIndex = 50;
            this.adr_txb.UseSelectable = true;
            this.adr_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adr_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // age_txb
            // 
            // 
            // 
            // 
            this.age_txb.CustomButton.Image = null;
            this.age_txb.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.age_txb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.age_txb.CustomButton.Name = "";
            this.age_txb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.age_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.age_txb.CustomButton.TabIndex = 1;
            this.age_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.age_txb.CustomButton.UseSelectable = true;
            this.age_txb.CustomButton.Visible = false;
            this.age_txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.age_txb.Lines = new string[0];
            this.age_txb.Location = new System.Drawing.Point(62, 31);
            this.age_txb.Margin = new System.Windows.Forms.Padding(2);
            this.age_txb.MaxLength = 32767;
            this.age_txb.Name = "age_txb";
            this.age_txb.PasswordChar = '\0';
            this.age_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.age_txb.SelectedText = "";
            this.age_txb.SelectionLength = 0;
            this.age_txb.SelectionStart = 0;
            this.age_txb.ShortcutsEnabled = true;
            this.age_txb.Size = new System.Drawing.Size(189, 25);
            this.age_txb.TabIndex = 66;
            this.age_txb.UseSelectable = true;
            this.age_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.age_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // type_cobx
            // 
            this.type_cobx.BackColor = System.Drawing.Color.Transparent;
            this.type_cobx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_cobx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.type_cobx.FormattingEnabled = true;
            this.type_cobx.ItemHeight = 23;
            this.type_cobx.Items.AddRange(new object[] {
            "Admin",
            "Reciptioniest",
            "Trainer"});
            this.type_cobx.Location = new System.Drawing.Point(62, 181);
            this.type_cobx.Margin = new System.Windows.Forms.Padding(2);
            this.type_cobx.Name = "type_cobx";
            this.type_cobx.Size = new System.Drawing.Size(189, 29);
            this.type_cobx.TabIndex = 67;
            this.type_cobx.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 40);
            this.panel1.TabIndex = 2;
            // 
            // st_tab_admin
            // 
            this.st_tab_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.st_tab_admin.Controls.Add(this.st_add_admin);
            this.st_tab_admin.Controls.Add(this.gr_view_admin);
            this.st_tab_admin.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.st_tab_admin.ItemSize = new System.Drawing.Size(266, 40);
            this.st_tab_admin.Location = new System.Drawing.Point(0, 2);
            this.st_tab_admin.Margin = new System.Windows.Forms.Padding(2);
            this.st_tab_admin.Name = "st_tab_admin";
            this.st_tab_admin.SelectedIndex = 0;
            this.st_tab_admin.Size = new System.Drawing.Size(553, 354);
            this.st_tab_admin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.st_tab_admin.Style = MetroFramework.MetroColorStyle.Teal;
            this.st_tab_admin.TabIndex = 1;
            this.st_tab_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.st_tab_admin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.st_tab_admin.UseSelectable = true;
            this.st_tab_admin.UseStyleColors = true;
            this.st_tab_admin.SelectedIndexChanged += new System.EventHandler(this.st_tab_admin_SelectedIndexChanged);
            // 
            // gr_view_admin
            // 
            this.gr_view_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_view_admin.Controls.Add(this.panel2);
            this.gr_view_admin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gr_view_admin.HorizontalScrollbarBarColor = true;
            this.gr_view_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.HorizontalScrollbarSize = 8;
            this.gr_view_admin.Location = new System.Drawing.Point(4, 44);
            this.gr_view_admin.Margin = new System.Windows.Forms.Padding(2);
            this.gr_view_admin.Name = "gr_view_admin";
            this.gr_view_admin.Size = new System.Drawing.Size(545, 306);
            this.gr_view_admin.TabIndex = 1;
            this.gr_view_admin.Text = "View Staff";
            this.gr_view_admin.UseStyleColors = true;
            this.gr_view_admin.VerticalScrollbarBarColor = true;
            this.gr_view_admin.VerticalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.VerticalScrollbarSize = 8;
            this.gr_view_admin.Click += new System.EventHandler(this.gr_view_admin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 34);
            this.panel2.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // stf_m_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 357);
            this.Controls.Add(this.st_tab_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "stf_m_admin";
            this.Text = "stf_m_admin";
            this.st_add_admin.ResumeLayout(false);
            this.st_add_admin.PerformLayout();
            this.table_pnl.ResumeLayout(false);
            this.table_pnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_picb)).EndInit();
            this.gender_gbx.ResumeLayout(false);
            this.gender_gbx.PerformLayout();
            this.btn_grbx.ResumeLayout(false);
            this.st_tab_admin.ResumeLayout(false);
            this.gr_view_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage st_add_admin;
        private MetroFramework.Controls.MetroTabControl st_tab_admin;
        private MetroFramework.Controls.MetroTabPage gr_view_admin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel table_pnl;
        private Guna.UI.WinForms.GunaGroupBox gender_gbx;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label name_lbl;
        private MetroFramework.Controls.MetroTextBox name_txb;
        private MetroFramework.Controls.MetroTextBox sal_txb;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.Label sal_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label email_lbl;
        private MetroFramework.Controls.MetroTextBox uname_txb;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox email_txb;
        private System.Windows.Forms.Label uname_lbl;
        private MetroFramework.Controls.MetroTextBox pho_txb;
        private System.Windows.Forms.Label adr_lbl;
        private System.Windows.Forms.Label pho_lbl;
        private System.Windows.Forms.Label img_lbl;
        private Guna.UI.WinForms.GunaGroupBox btn_grbx;
        private Guna.UI.WinForms.GunaButton erase_btn;
        private Guna.UI.WinForms.GunaButton add_btn;
        private MetroFramework.Controls.MetroTextBox pass_txb;
        private MetroFramework.Controls.MetroTextBox adr_txb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox age_txb;
        private MetroFramework.Controls.MetroComboBox type_cobx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaButton sel_img_btn;
        private Guna.UI.WinForms.GunaCirclePictureBox img_picb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}