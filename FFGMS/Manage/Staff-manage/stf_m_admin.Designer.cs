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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.st_add_admin = new MetroFramework.Controls.MetroTabPage();
            this.table_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.gender_gbx = new Guna.UI.WinForms.GunaGroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txb = new MetroFramework.Controls.MetroTextBox();
            this.sal_txb = new MetroFramework.Controls.MetroTextBox();
            this.dob_lbl = new System.Windows.Forms.Label();
            this.type_combo = new Guna.UI.WinForms.GunaComboBox();
            this.sal_lbl = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
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
            this.img_picb = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_grbx = new Guna.UI.WinForms.GunaGroupBox();
            this.erase_btn = new Guna.UI.WinForms.GunaButton();
            this.add_btn = new Guna.UI.WinForms.GunaButton();
            this.pass_txb = new MetroFramework.Controls.MetroTextBox();
            this.adr_txb = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.st_tab_admin = new MetroFramework.Controls.MetroTabControl();
            this.gr_view_admin = new MetroFramework.Controls.MetroTabPage();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.st_add_admin.SuspendLayout();
            this.table_pnl.SuspendLayout();
            this.gender_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_picb)).BeginInit();
            this.btn_grbx.SuspendLayout();
            this.st_tab_admin.SuspendLayout();
            this.gr_view_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // st_add_admin
            // 
            this.st_add_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.st_add_admin.Controls.Add(this.table_pnl);
            this.st_add_admin.Controls.Add(this.panel1);
            this.st_add_admin.HorizontalScrollbarBarColor = true;
            this.st_add_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.st_add_admin.HorizontalScrollbarSize = 10;
            this.st_add_admin.Location = new System.Drawing.Point(4, 44);
            this.st_add_admin.Name = "st_add_admin";
            this.st_add_admin.Size = new System.Drawing.Size(543, 320);
            this.st_add_admin.Style = MetroFramework.MetroColorStyle.Black;
            this.st_add_admin.TabIndex = 0;
            this.st_add_admin.Text = "Add Staff";
            this.st_add_admin.UseStyleColors = true;
            this.st_add_admin.VerticalScrollbarBarColor = true;
            this.st_add_admin.VerticalScrollbarHighlightOnWheel = false;
            this.st_add_admin.VerticalScrollbarSize = 10;
            this.st_add_admin.Click += new System.EventHandler(this.st_add_admin_Click);
            // 
            // table_pnl
            // 
            this.table_pnl.AutoSize = true;
            this.table_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table_pnl.BackColor = System.Drawing.Color.Transparent;
            this.table_pnl.ColumnCount = 4;
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96825F));
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.03175F));
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.table_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.table_pnl.Controls.Add(this.gender_gbx, 1, 5);
            this.table_pnl.Controls.Add(this.gender_lbl, 0, 5);
            this.table_pnl.Controls.Add(this.name_lbl, 0, 0);
            this.table_pnl.Controls.Add(this.name_txb, 1, 0);
            this.table_pnl.Controls.Add(this.sal_txb, 1, 4);
            this.table_pnl.Controls.Add(this.dob_lbl, 0, 1);
            this.table_pnl.Controls.Add(this.type_combo, 1, 3);
            this.table_pnl.Controls.Add(this.sal_lbl, 0, 4);
            this.table_pnl.Controls.Add(this.metroDateTime1, 1, 1);
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
            this.table_pnl.Controls.Add(this.img_picb, 1, 2);
            this.table_pnl.Controls.Add(this.btn_grbx, 3, 5);
            this.table_pnl.Controls.Add(this.pass_txb, 3, 4);
            this.table_pnl.Controls.Add(this.adr_txb, 3, 2);
            this.table_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_pnl.Location = new System.Drawing.Point(0, 49);
            this.table_pnl.Name = "table_pnl";
            this.table_pnl.RowCount = 6;
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.table_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.table_pnl.Size = new System.Drawing.Size(543, 333);
            this.table_pnl.TabIndex = 67;
            // 
            // gender_gbx
            // 
            this.gender_gbx.BackColor = System.Drawing.Color.Transparent;
            this.gender_gbx.BaseColor = System.Drawing.Color.White;
            this.gender_gbx.BorderColor = System.Drawing.Color.Transparent;
            this.gender_gbx.Controls.Add(this.radioButton2);
            this.gender_gbx.Controls.Add(this.radioButton1);
            this.gender_gbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gender_gbx.LineColor = System.Drawing.Color.Transparent;
            this.gender_gbx.Location = new System.Drawing.Point(54, 299);
            this.gender_gbx.Name = "gender_gbx";
            this.gender_gbx.Size = new System.Drawing.Size(121, 31);
            this.gender_gbx.TabIndex = 65;
            this.gender_gbx.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioButton2.Location = new System.Drawing.Point(0, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 31);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioButton1.Location = new System.Drawing.Point(40, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 31);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.gender_lbl.Location = new System.Drawing.Point(3, 296);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(45, 37);
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
            this.name_lbl.Location = new System.Drawing.Point(3, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(45, 37);
            this.name_lbl.TabIndex = 43;
            this.name_lbl.Text = "Name:";
            // 
            // name_txb
            // 
            // 
            // 
            // 
            this.name_txb.CustomButton.Image = null;
            this.name_txb.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.name_txb.CustomButton.Name = "";
            this.name_txb.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.name_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_txb.CustomButton.TabIndex = 1;
            this.name_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_txb.CustomButton.UseSelectable = true;
            this.name_txb.CustomButton.Visible = false;
            this.name_txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_txb.Lines = new string[0];
            this.name_txb.Location = new System.Drawing.Point(54, 3);
            this.name_txb.MaxLength = 32767;
            this.name_txb.Name = "name_txb";
            this.name_txb.PasswordChar = '\0';
            this.name_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_txb.SelectedText = "";
            this.name_txb.SelectionLength = 0;
            this.name_txb.SelectionStart = 0;
            this.name_txb.ShortcutsEnabled = true;
            this.name_txb.Size = new System.Drawing.Size(121, 31);
            this.name_txb.TabIndex = 44;
            this.name_txb.UseSelectable = true;
            this.name_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sal_txb
            // 
            // 
            // 
            // 
            this.sal_txb.CustomButton.Image = null;
            this.sal_txb.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.sal_txb.CustomButton.Name = "";
            this.sal_txb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.sal_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sal_txb.CustomButton.TabIndex = 1;
            this.sal_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sal_txb.CustomButton.UseSelectable = true;
            this.sal_txb.CustomButton.Visible = false;
            this.sal_txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sal_txb.Lines = new string[0];
            this.sal_txb.Location = new System.Drawing.Point(54, 264);
            this.sal_txb.MaxLength = 32767;
            this.sal_txb.Name = "sal_txb";
            this.sal_txb.PasswordChar = '\0';
            this.sal_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sal_txb.SelectedText = "";
            this.sal_txb.SelectionLength = 0;
            this.sal_txb.SelectionStart = 0;
            this.sal_txb.ShortcutsEnabled = true;
            this.sal_txb.Size = new System.Drawing.Size(121, 29);
            this.sal_txb.TabIndex = 59;
            this.sal_txb.UseSelectable = true;
            this.sal_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sal_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dob_lbl
            // 
            this.dob_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dob_lbl.AutoSize = true;
            this.dob_lbl.BackColor = System.Drawing.Color.Transparent;
            this.dob_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.dob_lbl.Location = new System.Drawing.Point(3, 37);
            this.dob_lbl.Name = "dob_lbl";
            this.dob_lbl.Size = new System.Drawing.Size(45, 37);
            this.dob_lbl.TabIndex = 45;
            this.dob_lbl.Text = "D.O.B:";
            // 
            // type_combo
            // 
            this.type_combo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_combo.BackColor = System.Drawing.Color.Transparent;
            this.type_combo.BaseColor = System.Drawing.Color.Transparent;
            this.type_combo.BorderColor = System.Drawing.Color.Silver;
            this.type_combo.BorderSize = 1;
            this.type_combo.Cursor = System.Windows.Forms.Cursors.Default;
            this.type_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type_combo.DropDownHeight = 125;
            this.type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combo.DropDownWidth = 50;
            this.type_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type_combo.FocusedColor = System.Drawing.Color.Transparent;
            this.type_combo.Font = new System.Drawing.Font("Baloo Bhaijaan", 10.8F);
            this.type_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.type_combo.IntegralHeight = false;
            this.type_combo.ItemHeight = 25;
            this.type_combo.Items.AddRange(new object[] {
            "Admin",
            "Reciptionist",
            "Trainer"});
            this.type_combo.Location = new System.Drawing.Point(54, 226);
            this.type_combo.MaxDropDownItems = 3;
            this.type_combo.Name = "type_combo";
            this.type_combo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.type_combo.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.type_combo.Size = new System.Drawing.Size(121, 31);
            this.type_combo.TabIndex = 63;
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
            this.sal_lbl.Location = new System.Drawing.Point(3, 261);
            this.sal_lbl.Name = "sal_lbl";
            this.sal_lbl.Size = new System.Drawing.Size(45, 35);
            this.sal_lbl.TabIndex = 58;
            this.sal_lbl.Text = "Salary:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroDateTime1.Location = new System.Drawing.Point(54, 40);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(121, 30);
            this.metroDateTime1.TabIndex = 46;
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
            this.label3.Location = new System.Drawing.Point(3, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 38);
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
            this.email_lbl.Location = new System.Drawing.Point(181, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(87, 37);
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
            this.uname_txb.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.uname_txb.CustomButton.Name = "";
            this.uname_txb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.uname_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uname_txb.CustomButton.TabIndex = 1;
            this.uname_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uname_txb.CustomButton.UseSelectable = true;
            this.uname_txb.CustomButton.Visible = false;
            this.uname_txb.Lines = new string[0];
            this.uname_txb.Location = new System.Drawing.Point(274, 226);
            this.uname_txb.MaxLength = 32767;
            this.uname_txb.Name = "uname_txb";
            this.uname_txb.PasswordChar = '\0';
            this.uname_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uname_txb.SelectedText = "";
            this.uname_txb.SelectionLength = 0;
            this.uname_txb.SelectionStart = 0;
            this.uname_txb.ShortcutsEnabled = true;
            this.uname_txb.Size = new System.Drawing.Size(266, 32);
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
            this.label2.Location = new System.Drawing.Point(181, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 35);
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
            this.email_txb.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.email_txb.CustomButton.Name = "";
            this.email_txb.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.email_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email_txb.CustomButton.TabIndex = 1;
            this.email_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email_txb.CustomButton.UseSelectable = true;
            this.email_txb.CustomButton.Visible = false;
            this.email_txb.Lines = new string[0];
            this.email_txb.Location = new System.Drawing.Point(274, 3);
            this.email_txb.MaxLength = 32767;
            this.email_txb.Name = "email_txb";
            this.email_txb.PasswordChar = '\0';
            this.email_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email_txb.SelectedText = "";
            this.email_txb.SelectionLength = 0;
            this.email_txb.SelectionStart = 0;
            this.email_txb.ShortcutsEnabled = true;
            this.email_txb.Size = new System.Drawing.Size(266, 31);
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
            this.uname_lbl.Location = new System.Drawing.Point(181, 223);
            this.uname_lbl.Name = "uname_lbl";
            this.uname_lbl.Size = new System.Drawing.Size(87, 38);
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
            this.pho_txb.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.pho_txb.CustomButton.Name = "";
            this.pho_txb.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.pho_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pho_txb.CustomButton.TabIndex = 1;
            this.pho_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pho_txb.CustomButton.UseSelectable = true;
            this.pho_txb.CustomButton.Visible = false;
            this.pho_txb.Lines = new string[0];
            this.pho_txb.Location = new System.Drawing.Point(274, 40);
            this.pho_txb.MaxLength = 32767;
            this.pho_txb.Name = "pho_txb";
            this.pho_txb.PasswordChar = '\0';
            this.pho_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pho_txb.SelectedText = "";
            this.pho_txb.SelectionLength = 0;
            this.pho_txb.SelectionStart = 0;
            this.pho_txb.ShortcutsEnabled = true;
            this.pho_txb.Size = new System.Drawing.Size(266, 31);
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
            this.adr_lbl.Location = new System.Drawing.Point(181, 74);
            this.adr_lbl.Name = "adr_lbl";
            this.adr_lbl.Size = new System.Drawing.Size(87, 149);
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
            this.pho_lbl.Location = new System.Drawing.Point(181, 37);
            this.pho_lbl.Name = "pho_lbl";
            this.pho_lbl.Size = new System.Drawing.Size(87, 37);
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
            this.img_lbl.Location = new System.Drawing.Point(3, 74);
            this.img_lbl.Name = "img_lbl";
            this.img_lbl.Size = new System.Drawing.Size(45, 149);
            this.img_lbl.TabIndex = 60;
            this.img_lbl.Text = "Image:";
            // 
            // img_picb
            // 
            this.img_picb.BackColor = System.Drawing.Color.Transparent;
            this.img_picb.BaseColor = System.Drawing.Color.White;
            this.img_picb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_picb.Image = global::FFGMS.Properties.Resources.icons8_prelum_100_2;
            this.img_picb.Location = new System.Drawing.Point(54, 77);
            this.img_picb.Name = "img_picb";
            this.img_picb.Size = new System.Drawing.Size(121, 143);
            this.img_picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_picb.TabIndex = 61;
            this.img_picb.TabStop = false;
            this.img_picb.UseTransfarantBackground = false;
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
            this.btn_grbx.Location = new System.Drawing.Point(274, 299);
            this.btn_grbx.Name = "btn_grbx";
            this.btn_grbx.Size = new System.Drawing.Size(266, 31);
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
            this.erase_btn.Name = "erase_btn";
            this.erase_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.erase_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.erase_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.erase_btn.OnHoverImage = null;
            this.erase_btn.OnPressedColor = System.Drawing.Color.Black;
            this.erase_btn.Size = new System.Drawing.Size(114, 31);
            this.erase_btn.TabIndex = 1;
            this.erase_btn.Text = "Erase";
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
            this.add_btn.Location = new System.Drawing.Point(153, 0);
            this.add_btn.Name = "add_btn";
            this.add_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.add_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_btn.OnHoverImage = null;
            this.add_btn.OnPressedColor = System.Drawing.Color.Black;
            this.add_btn.Size = new System.Drawing.Size(113, 31);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add";
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
            this.pass_txb.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.pass_txb.CustomButton.Name = "";
            this.pass_txb.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.pass_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass_txb.CustomButton.TabIndex = 1;
            this.pass_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass_txb.CustomButton.UseSelectable = true;
            this.pass_txb.CustomButton.Visible = false;
            this.pass_txb.Lines = new string[0];
            this.pass_txb.Location = new System.Drawing.Point(274, 264);
            this.pass_txb.MaxLength = 32767;
            this.pass_txb.Name = "pass_txb";
            this.pass_txb.PasswordChar = '\0';
            this.pass_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass_txb.SelectedText = "";
            this.pass_txb.SelectionLength = 0;
            this.pass_txb.SelectionStart = 0;
            this.pass_txb.ShortcutsEnabled = true;
            this.pass_txb.Size = new System.Drawing.Size(266, 29);
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
            this.adr_txb.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.adr_txb.CustomButton.Name = "";
            this.adr_txb.CustomButton.Size = new System.Drawing.Size(141, 141);
            this.adr_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adr_txb.CustomButton.TabIndex = 1;
            this.adr_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adr_txb.CustomButton.UseSelectable = true;
            this.adr_txb.CustomButton.Visible = false;
            this.adr_txb.Lines = new string[0];
            this.adr_txb.Location = new System.Drawing.Point(274, 77);
            this.adr_txb.MaxLength = 32767;
            this.adr_txb.Multiline = true;
            this.adr_txb.Name = "adr_txb";
            this.adr_txb.PasswordChar = '\0';
            this.adr_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adr_txb.SelectedText = "";
            this.adr_txb.SelectionLength = 0;
            this.adr_txb.SelectionStart = 0;
            this.adr_txb.ShortcutsEnabled = true;
            this.adr_txb.Size = new System.Drawing.Size(266, 143);
            this.adr_txb.TabIndex = 50;
            this.adr_txb.UseSelectable = true;
            this.adr_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adr_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 49);
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
            this.st_tab_admin.Location = new System.Drawing.Point(0, 3);
            this.st_tab_admin.Name = "st_tab_admin";
            this.st_tab_admin.SelectedIndex = 0;
            this.st_tab_admin.Size = new System.Drawing.Size(551, 368);
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
            this.gr_view_admin.Controls.Add(this.gunaDataGridView1);
            this.gr_view_admin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gr_view_admin.HorizontalScrollbarBarColor = true;
            this.gr_view_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.HorizontalScrollbarSize = 10;
            this.gr_view_admin.Location = new System.Drawing.Point(4, 44);
            this.gr_view_admin.Name = "gr_view_admin";
            this.gr_view_admin.Size = new System.Drawing.Size(543, 320);
            this.gr_view_admin.TabIndex = 1;
            this.gr_view_admin.Text = "View Staff";
            this.gr_view_admin.UseStyleColors = true;
            this.gr_view_admin.VerticalScrollbarBarColor = true;
            this.gr_view_admin.VerticalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.VerticalScrollbarSize = 10;
            this.gr_view_admin.Click += new System.EventHandler(this.gr_view_admin_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(119, 127);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.gunaDataGridView1.TabIndex = 2;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // stf_m_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 371);
            this.Controls.Add(this.st_tab_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stf_m_admin";
            this.Text = "stf_m_admin";
            this.st_add_admin.ResumeLayout(false);
            this.st_add_admin.PerformLayout();
            this.table_pnl.ResumeLayout(false);
            this.table_pnl.PerformLayout();
            this.gender_gbx.ResumeLayout(false);
            this.gender_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_picb)).EndInit();
            this.btn_grbx.ResumeLayout(false);
            this.st_tab_admin.ResumeLayout(false);
            this.gr_view_admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage st_add_admin;
        private MetroFramework.Controls.MetroTabControl st_tab_admin;
        private MetroFramework.Controls.MetroTabPage gr_view_admin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel table_pnl;
        private Guna.UI.WinForms.GunaGroupBox gender_gbx;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label name_lbl;
        private MetroFramework.Controls.MetroTextBox name_txb;
        private MetroFramework.Controls.MetroTextBox sal_txb;
        private System.Windows.Forms.Label dob_lbl;
        private Guna.UI.WinForms.GunaComboBox type_combo;
        private System.Windows.Forms.Label sal_lbl;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
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
        private Guna.UI.WinForms.GunaCirclePictureBox img_picb;
        private Guna.UI.WinForms.GunaGroupBox btn_grbx;
        private Guna.UI.WinForms.GunaButton erase_btn;
        private Guna.UI.WinForms.GunaButton add_btn;
        private MetroFramework.Controls.MetroTextBox pass_txb;
        private MetroFramework.Controls.MetroTextBox adr_txb;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
    }
}