﻿namespace FFGMS.profiles
{
    partial class trainer_profile
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
            this.gr_tab_admin = new MetroFramework.Controls.MetroTabControl();
            this.gr_view_admin = new MetroFramework.Controls.MetroTabPage();
            this.gr_add_admin = new MetroFramework.Controls.MetroTabPage();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gr_tab_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_tab_admin
            // 
            this.gr_tab_admin.Controls.Add(this.gr_view_admin);
            this.gr_tab_admin.Controls.Add(this.gr_add_admin);
            this.gr_tab_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_tab_admin.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.gr_tab_admin.ItemSize = new System.Drawing.Size(266, 40);
            this.gr_tab_admin.Location = new System.Drawing.Point(0, 0);
            this.gr_tab_admin.Name = "gr_tab_admin";
            this.gr_tab_admin.SelectedIndex = 0;
            this.gr_tab_admin.Size = new System.Drawing.Size(543, 388);
            this.gr_tab_admin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.gr_tab_admin.Style = MetroFramework.MetroColorStyle.Teal;
            this.gr_tab_admin.TabIndex = 6;
            this.gr_tab_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gr_tab_admin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gr_tab_admin.UseSelectable = true;
            this.gr_tab_admin.UseStyleColors = true;
            // 
            // gr_view_admin
            // 
            this.gr_view_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_view_admin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gr_view_admin.HorizontalScrollbarBarColor = true;
            this.gr_view_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.HorizontalScrollbarSize = 10;
            this.gr_view_admin.Location = new System.Drawing.Point(4, 44);
            this.gr_view_admin.Name = "gr_view_admin";
            this.gr_view_admin.Size = new System.Drawing.Size(535, 340);
            this.gr_view_admin.TabIndex = 1;
            this.gr_view_admin.Text = "View Profile";
            this.gr_view_admin.UseStyleColors = true;
            this.gr_view_admin.VerticalScrollbarBarColor = true;
            this.gr_view_admin.VerticalScrollbarHighlightOnWheel = false;
            this.gr_view_admin.VerticalScrollbarSize = 10;
            // 
            // gr_add_admin
            // 
            this.gr_add_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gr_add_admin.HorizontalScrollbarBarColor = true;
            this.gr_add_admin.HorizontalScrollbarHighlightOnWheel = false;
            this.gr_add_admin.HorizontalScrollbarSize = 10;
            this.gr_add_admin.Location = new System.Drawing.Point(4, 44);
            this.gr_add_admin.Name = "gr_add_admin";
            this.gr_add_admin.Size = new System.Drawing.Size(530, 374);
            this.gr_add_admin.Style = MetroFramework.MetroColorStyle.Black;
            this.gr_add_admin.TabIndex = 0;
            this.gr_add_admin.Text = "Alter Profile";
            this.gr_add_admin.UseStyleColors = true;
            this.gr_add_admin.VerticalScrollbarBarColor = true;
            this.gr_add_admin.VerticalScrollbarHighlightOnWheel = false;
            this.gr_add_admin.VerticalScrollbarSize = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // trainer_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 388);
            this.Controls.Add(this.gr_tab_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trainer_profile";
            this.Text = "trainer_profile";
            this.gr_tab_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl gr_tab_admin;
        private MetroFramework.Controls.MetroTabPage gr_view_admin;
        private MetroFramework.Controls.MetroTabPage gr_add_admin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}