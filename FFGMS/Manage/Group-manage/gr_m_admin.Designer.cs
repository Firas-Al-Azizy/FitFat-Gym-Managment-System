namespace FFGMS.Manage
{
    partial class gr_m_admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gr_tab_admin = new MetroFramework.Controls.MetroTabControl();
            this.gr_add_admin = new MetroFramework.Controls.MetroTabPage();
            this.gr_view_admin = new MetroFramework.Controls.MetroTabPage();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.view_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.view_menu = new System.Windows.Forms.TableLayoutPanel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.search_txb = new MetroFramework.Controls.MetroTextBox();
            this.search_picbx = new System.Windows.Forms.PictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.data_view = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gr_tab_admin.SuspendLayout();
            this.gr_view_admin.SuspendLayout();
            this.view_pnl.SuspendLayout();
            this.view_menu.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_tab_admin
            // 
            this.gr_tab_admin.Controls.Add(this.gr_add_admin);
            this.gr_tab_admin.Controls.Add(this.gr_view_admin);
            this.gr_tab_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_tab_admin.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.gr_tab_admin.ItemSize = new System.Drawing.Size(266, 40);
            this.gr_tab_admin.Location = new System.Drawing.Point(0, 0);
            this.gr_tab_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_tab_admin.Name = "gr_tab_admin";
            this.gr_tab_admin.SelectedIndex = 1;
            this.gr_tab_admin.Size = new System.Drawing.Size(737, 439);
            this.gr_tab_admin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.gr_tab_admin.Style = MetroFramework.MetroColorStyle.Teal;
            this.gr_tab_admin.TabIndex = 0;
            this.gr_tab_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gr_tab_admin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gr_tab_admin.UseSelectable = true;
            this.gr_tab_admin.UseStyleColors = true;
            // 
            // gr_add_admin
            // 
            this.gr_add_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_add_admin.HorizontalScrollbarBarColor = true;
            this.gr_add_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.gr_add_admin.HorizontalScrollbarSize = 10;
            this.gr_add_admin.Location = new System.Drawing.Point(4, 44);
            this.gr_add_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_add_admin.Name = "gr_add_admin";
            this.gr_add_admin.Size = new System.Drawing.Size(729, 391);
            this.gr_add_admin.Style = MetroFramework.MetroColorStyle.Black;
            this.gr_add_admin.TabIndex = 0;
            this.gr_add_admin.Text = "Add Group";
            this.gr_add_admin.UseStyleColors = true;
            this.gr_add_admin.VerticalScrollbarBarColor = true;
            this.gr_add_admin.VerticalScrollbarHighlightOnWheel = false;
            this.gr_add_admin.VerticalScrollbarSize = 11;
            // 
            // gr_view_admin
            // 
            this.gr_view_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_view_admin.Controls.Add(this.view_pnl);
            this.gr_view_admin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gr_view_admin.HorizontalScrollbarBarColor = true;
            this.gr_view_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.HorizontalScrollbarSize = 10;
            this.gr_view_admin.Location = new System.Drawing.Point(4, 44);
            this.gr_view_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_view_admin.Name = "gr_view_admin";
            this.gr_view_admin.Size = new System.Drawing.Size(729, 391);
            this.gr_view_admin.TabIndex = 1;
            this.gr_view_admin.Text = "View Group";
            this.gr_view_admin.UseStyleColors = true;
            this.gr_view_admin.VerticalScrollbarBarColor = true;
            this.gr_view_admin.VerticalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.VerticalScrollbarSize = 11;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // view_pnl
            // 
            this.view_pnl.BackColor = System.Drawing.Color.Transparent;
            this.view_pnl.ColumnCount = 1;
            this.view_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.view_pnl.Controls.Add(this.view_menu, 0, 0);
            this.view_pnl.Controls.Add(this.data_view, 0, 1);
            this.view_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_pnl.Location = new System.Drawing.Point(0, 0);
            this.view_pnl.Name = "view_pnl";
            this.view_pnl.RowCount = 3;
            this.view_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857F));
            this.view_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.57143F));
            this.view_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.view_pnl.Size = new System.Drawing.Size(729, 391);
            this.view_pnl.TabIndex = 3;
            // 
            // view_menu
            // 
            this.view_menu.BackColor = System.Drawing.Color.Transparent;
            this.view_menu.ColumnCount = 5;
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.08333F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.91667F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.view_menu.Controls.Add(this.search_panel, 4, 0);
            this.view_menu.Controls.Add(this.gunaButton3, 0, 0);
            this.view_menu.Controls.Add(this.gunaButton4, 0, 0);
            this.view_menu.Controls.Add(this.gunaButton1, 0, 0);
            this.view_menu.Controls.Add(this.gunaButton2, 0, 0);
            this.view_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_menu.Location = new System.Drawing.Point(3, 3);
            this.view_menu.Name = "view_menu";
            this.view_menu.RowCount = 1;
            this.view_menu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.view_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.view_menu.Size = new System.Drawing.Size(723, 36);
            this.view_menu.TabIndex = 4;
            // 
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.Color.Transparent;
            this.search_panel.Controls.Add(this.search_txb);
            this.search_panel.Controls.Add(this.search_picbx);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_panel.Location = new System.Drawing.Point(459, 3);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(261, 33);
            this.search_panel.TabIndex = 4;
            // 
            // search_txb
            // 
            // 
            // 
            // 
            this.search_txb.CustomButton.Image = null;
            this.search_txb.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.search_txb.CustomButton.Name = "";
            this.search_txb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.search_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_txb.CustomButton.TabIndex = 1;
            this.search_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_txb.CustomButton.UseSelectable = true;
            this.search_txb.CustomButton.Visible = false;
            this.search_txb.Dock = System.Windows.Forms.DockStyle.Right;
            this.search_txb.Lines = new string[0];
            this.search_txb.Location = new System.Drawing.Point(39, 0);
            this.search_txb.MaxLength = 32767;
            this.search_txb.Name = "search_txb";
            this.search_txb.PasswordChar = '\0';
            this.search_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_txb.SelectedText = "";
            this.search_txb.SelectionLength = 0;
            this.search_txb.SelectionStart = 0;
            this.search_txb.ShortcutsEnabled = true;
            this.search_txb.Size = new System.Drawing.Size(222, 33);
            this.search_txb.TabIndex = 6;
            this.search_txb.UseSelectable = true;
            this.search_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // search_picbx
            // 
            this.search_picbx.BackColor = System.Drawing.Color.Transparent;
            this.search_picbx.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_picbx.Image = global::FFGMS.Properties.Resources.search_64px;
            this.search_picbx.Location = new System.Drawing.Point(0, 0);
            this.search_picbx.Name = "search_picbx";
            this.search_picbx.Size = new System.Drawing.Size(39, 33);
            this.search_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_picbx.TabIndex = 4;
            this.search_picbx.TabStop = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::FFGMS.Properties.Resources.icons8_swap_32;
            this.gunaButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaButton1.Location = new System.Drawing.Point(107, 3);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(110, 33);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Change";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::FFGMS.Properties.Resources.icons8_view_module_32;
            this.gunaButton2.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaButton2.Location = new System.Drawing.Point(3, 3);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(98, 33);
            this.gunaButton2.TabIndex = 2;
            this.gunaButton2.Text = "View";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // data_view
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.data_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_view.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.data_view.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_view.DefaultCellStyle = dataGridViewCellStyle9;
            this.data_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_view.EnableHeadersVisualStyles = false;
            this.data_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_view.Location = new System.Drawing.Point(3, 45);
            this.data_view.Name = "data_view";
            this.data_view.RowHeadersVisible = false;
            this.data_view.RowTemplate.Height = 24;
            this.data_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_view.Size = new System.Drawing.Size(723, 322);
            this.data_view.TabIndex = 5;
            this.data_view.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.data_view.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_view.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_view.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_view.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_view.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_view.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.data_view.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_view.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_view.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_view.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.data_view.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_view.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_view.ThemeStyle.HeaderStyle.Height = 4;
            this.data_view.ThemeStyle.ReadOnly = false;
            this.data_view.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data_view.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_view.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.data_view.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_view.ThemeStyle.RowsStyle.Height = 24;
            this.data_view.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_view.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::FFGMS.Properties.Resources.icons8_print_32;
            this.gunaButton3.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaButton3.Location = new System.Drawing.Point(343, 3);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(110, 33);
            this.gunaButton3.TabIndex = 5;
            this.gunaButton3.Text = "Print";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = global::FFGMS.Properties.Resources.icons8_delete_32;
            this.gunaButton4.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaButton4.Location = new System.Drawing.Point(223, 3);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(114, 33);
            this.gunaButton4.TabIndex = 4;
            this.gunaButton4.Text = "Delete";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gr_m_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 439);
            this.Controls.Add(this.gr_tab_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gr_m_admin";
            this.Text = "gr_m_admin";
            this.gr_tab_admin.ResumeLayout(false);
            this.gr_view_admin.ResumeLayout(false);
            this.view_pnl.ResumeLayout(false);
            this.view_menu.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabPage gr_add_admin;
        private MetroFramework.Controls.MetroTabPage gr_view_admin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MetroFramework.Controls.MetroTabControl gr_tab_admin;
        private System.Windows.Forms.TableLayoutPanel view_pnl;
        private System.Windows.Forms.TableLayoutPanel view_menu;
        private System.Windows.Forms.Panel search_panel;
        private MetroFramework.Controls.MetroTextBox search_txb;
        private System.Windows.Forms.PictureBox search_picbx;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaDataGridView data_view;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton4;
    }
}