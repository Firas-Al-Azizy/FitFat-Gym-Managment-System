﻿namespace FFGMS.Manage.Group_manage
{
    partial class gr_m_reciption
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
            this.gr_tab_rec = new MetroFramework.Controls.MetroTabControl();
            this.gr_view_rec = new MetroFramework.Controls.MetroTabPage();
            this.view_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.view_menu = new System.Windows.Forms.TableLayoutPanel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.search_panel = new System.Windows.Forms.Panel();
            this.search_txb = new MetroFramework.Controls.MetroTextBox();
            this.search_picbx = new System.Windows.Forms.PictureBox();
            this.data_view = new Guna.UI.WinForms.GunaDataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gr_tab_rec.SuspendLayout();
            this.gr_view_rec.SuspendLayout();
            this.view_pnl.SuspendLayout();
            this.view_menu.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_tab_rec
            // 
            this.gr_tab_rec.Controls.Add(this.gr_view_rec);
            this.gr_tab_rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_tab_rec.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.gr_tab_rec.ItemSize = new System.Drawing.Size(266, 40);
            this.gr_tab_rec.Location = new System.Drawing.Point(0, 0);
            this.gr_tab_rec.Name = "gr_tab_rec";
            this.gr_tab_rec.SelectedIndex = 0;
            this.gr_tab_rec.Size = new System.Drawing.Size(737, 439);
            this.gr_tab_rec.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.gr_tab_rec.Style = MetroFramework.MetroColorStyle.Teal;
            this.gr_tab_rec.TabIndex = 1;
            this.gr_tab_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gr_tab_rec.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gr_tab_rec.UseSelectable = true;
            this.gr_tab_rec.UseStyleColors = true;
            // 
            // gr_view_rec
            // 
            this.gr_view_rec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_view_rec.Controls.Add(this.view_pnl);
            this.gr_view_rec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gr_view_rec.HorizontalScrollbarBarColor = true;
            this.gr_view_rec.HorizontalScrollbarHighlightOnWheel = false;
            this.gr_view_rec.HorizontalScrollbarSize = 10;
            this.gr_view_rec.Location = new System.Drawing.Point(4, 44);
            this.gr_view_rec.Name = "gr_view_rec";
            this.gr_view_rec.Size = new System.Drawing.Size(729, 391);
            this.gr_view_rec.TabIndex = 1;
            this.gr_view_rec.Text = "View Group";
            this.gr_view_rec.UseStyleColors = true;
            this.gr_view_rec.VerticalScrollbarBarColor = true;
            this.gr_view_rec.VerticalScrollbarHighlightOnWheel = false;
            this.gr_view_rec.VerticalScrollbarSize = 10;
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
            this.view_pnl.TabIndex = 4;
            // 
            // view_menu
            // 
            this.view_menu.BackColor = System.Drawing.Color.Transparent;
            this.view_menu.ColumnCount = 5;
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.08333F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.91667F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.view_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.view_menu.Controls.Add(this.gunaButton3, 0, 0);
            this.view_menu.Controls.Add(this.gunaButton2, 0, 0);
            this.view_menu.Controls.Add(this.search_panel, 4, 0);
            this.view_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_menu.Location = new System.Drawing.Point(3, 3);
            this.view_menu.Name = "view_menu";
            this.view_menu.RowCount = 1;
            this.view_menu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.view_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.view_menu.Size = new System.Drawing.Size(723, 36);
            this.view_menu.TabIndex = 4;
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
            this.gunaButton3.Location = new System.Drawing.Point(106, 3);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(109, 33);
            this.gunaButton3.TabIndex = 10;
            this.gunaButton3.Text = "Print";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.gunaButton2.Size = new System.Drawing.Size(97, 33);
            this.gunaButton2.TabIndex = 8;
            this.gunaButton2.Text = "View";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // search_panel
            // 
            this.search_panel.BackColor = System.Drawing.Color.Transparent;
            this.search_panel.Controls.Add(this.search_txb);
            this.search_panel.Controls.Add(this.search_picbx);
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_panel.Location = new System.Drawing.Point(457, 3);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(263, 33);
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
            this.search_txb.Location = new System.Drawing.Point(41, 0);
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
            // data_view
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.data_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_view.BackgroundColor = System.Drawing.SystemColors.Control;
            this.data_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_view.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_view.DefaultCellStyle = dataGridViewCellStyle3;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gr_m_reciption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 439);
            this.Controls.Add(this.gr_tab_rec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gr_m_reciption";
            this.Text = "gr_m_reciption";
            this.gr_tab_rec.ResumeLayout(false);
            this.gr_view_rec.ResumeLayout(false);
            this.view_pnl.ResumeLayout(false);
            this.view_menu.ResumeLayout(false);
            this.search_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl gr_tab_rec;
        private MetroFramework.Controls.MetroTabPage gr_view_rec;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TableLayoutPanel view_pnl;
        private System.Windows.Forms.TableLayoutPanel view_menu;
        private System.Windows.Forms.Panel search_panel;
        private MetroFramework.Controls.MetroTextBox search_txb;
        private System.Windows.Forms.PictureBox search_picbx;
        private Guna.UI.WinForms.GunaDataGridView data_view;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}