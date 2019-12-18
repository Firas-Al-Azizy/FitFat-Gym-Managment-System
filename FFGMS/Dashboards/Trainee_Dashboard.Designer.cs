namespace FFGMS.Dashboards
{
    partial class Trainee_Dashboard
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
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainee_Dashboard));
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            this.menu_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.form_list_tabs = new MetroFramework.Controls.MetroPanel();
            this.form_list_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.logo_panel.SuspendLayout();
            this.form_list_tabs.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_trans
            // 
            this.menu_trans.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menu_trans.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.menu_trans.DefaultAnimation = animation11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.menu_trans.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(282, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 73);
            this.label4.TabIndex = 3;
            this.label4.Text = "GMS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_trans.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::FFGMS.Properties.Resources.icons8_deadlift_100;
            this.pictureBox2.Location = new System.Drawing.Point(297, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 119);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.Transparent;
            this.logo_panel.Controls.Add(this.label4);
            this.logo_panel.Controls.Add(this.pictureBox2);
            this.logo_panel.Controls.Add(this.label5);
            this.title_trans.SetDecoration(this.logo_panel, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.logo_panel, BunifuAnimatorNS.DecorationType.None);
            this.logo_panel.Location = new System.Drawing.Point(177, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(548, 568);
            this.logo_panel.TabIndex = 41;
            this.logo_panel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.menu_trans.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(77, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 66);
            this.label5.TabIndex = 0;
            this.label5.Text = "FitFat";
            // 
            // form_list_tabs
            // 
            this.form_list_tabs.BackColor = System.Drawing.Color.Transparent;
            this.form_list_tabs.Controls.Add(this.logo_panel);
            this.menu_trans.SetDecoration(this.form_list_tabs, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.form_list_tabs, BunifuAnimatorNS.DecorationType.None);
            this.form_list_tabs.Dock = System.Windows.Forms.DockStyle.Right;
            this.form_list_tabs.HorizontalScrollbarBarColor = true;
            this.form_list_tabs.HorizontalScrollbarHighlightOnWheel = false;
            this.form_list_tabs.HorizontalScrollbarSize = 10;
            this.form_list_tabs.Location = new System.Drawing.Point(48, 33);
            this.form_list_tabs.Name = "form_list_tabs";
            this.form_list_tabs.Size = new System.Drawing.Size(723, 528);
            this.form_list_tabs.TabIndex = 42;
            this.form_list_tabs.VerticalScrollbarBarColor = true;
            this.form_list_tabs.VerticalScrollbarHighlightOnWheel = false;
            this.form_list_tabs.VerticalScrollbarSize = 10;
            this.form_list_tabs.Visible = false;
            // 
            // form_list_panel
            // 
            this.form_list_panel.BackColor = System.Drawing.Color.Transparent;
            this.title_trans.SetDecoration(this.form_list_panel, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.form_list_panel, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.form_list_panel.Location = new System.Drawing.Point(48, 33);
            this.form_list_panel.Name = "form_list_panel";
            this.form_list_panel.Size = new System.Drawing.Size(720, 528);
            this.form_list_panel.TabIndex = 40;
            this.form_list_panel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.form_list_panel);
            this.panel3.Controls.Add(this.back_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.exit_btn);
            this.title_trans.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 33);
            this.panel3.TabIndex = 41;
            // 
            // back_btn
            // 
            this.menu_trans.SetDecoration(this.back_btn, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.back_btn, BunifuAnimatorNS.DecorationType.None);
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.back_btn.Location = new System.Drawing.Point(682, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(46, 33);
            this.back_btn.TabIndex = 29;
            this.back_btn.Text = "<";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.menu_trans.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "FitFat";
            // 
            // exit_btn
            // 
            this.menu_trans.SetDecoration(this.exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.exit_btn.Location = new System.Drawing.Point(725, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(46, 33);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.menu_trans.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "TraineeDashboard";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_trans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::FFGMS.Properties.Resources.icons8_menu_50_4;
            this.pictureBox1.InitialImage = global::FFGMS.Properties.Resources.icons8_menu_50_3;
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Profile";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title_trans.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::FFGMS.Properties.Resources.icons8_resume_50;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 70D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(1, 122);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(225, 51);
            this.bunifuFlatButton8.TabIndex = 42;
            this.bunifuFlatButton8.Text = "Profile";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.bunifuFlatButton8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.title_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(-1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 528);
            this.panel1.TabIndex = 40;
            // 
            // title_trans
            // 
            this.title_trans.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.title_trans.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.title_trans.DefaultAnimation = animation12;
            // 
            // Trainee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 561);
            this.Controls.Add(this.form_list_tabs);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.menu_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainee_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainee_Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            this.form_list_tabs.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition menu_trans;
        private System.Windows.Forms.Label label4;
        private BunifuAnimatorNS.BunifuTransition title_trans;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroPanel form_list_tabs;
        private System.Windows.Forms.FlowLayoutPanel form_list_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private System.Windows.Forms.Panel panel1;
    }
}