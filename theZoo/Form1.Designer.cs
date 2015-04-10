namespace theZoo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstdanhsach = new System.Windows.Forms.ListBox();
            this.lblthumoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstthumoi = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuluu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblngaythang = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sở Thú Sài Gòn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lstdanhsach, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblthumoi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstthumoi, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.64103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 146);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lstdanhsach
            // 
            this.lstdanhsach.AllowDrop = true;
            this.lstdanhsach.FormattingEnabled = true;
            this.lstdanhsach.Location = new System.Drawing.Point(140, 21);
            this.lstdanhsach.Name = "lstdanhsach";
            this.lstdanhsach.Size = new System.Drawing.Size(132, 95);
            this.lstdanhsach.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstdanhsach, "danh sách bạn vừa tạo sẽ được lưu vào đây");
            this.lstdanhsach.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstdanhsach_DragDrop);
            this.lstdanhsach.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstthumoi_DragEnter);
            // 
            // lblthumoi
            // 
            this.lblthumoi.AutoSize = true;
            this.lblthumoi.Location = new System.Drawing.Point(3, 0);
            this.lblthumoi.Name = "lblthumoi";
            this.lblthumoi.Size = new System.Drawing.Size(46, 13);
            this.lblthumoi.TabIndex = 1;
            this.lblthumoi.Text = "Thú Mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh Sách Thú";
            // 
            // lstthumoi
            // 
            this.lstthumoi.AllowDrop = true;
            this.lstthumoi.FormattingEnabled = true;
            this.lstthumoi.Location = new System.Drawing.Point(3, 21);
            this.lstthumoi.Name = "lstthumoi";
            this.lstthumoi.Size = new System.Drawing.Size(131, 95);
            this.lstthumoi.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstthumoi, "ấn chuột và kéo sang danh sách con thú để tạo sở thú");
            this.lstthumoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstthumoi_DragEnter);
            this.lstthumoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstthumoi_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutai,
            this.mnuluu,
            this.mnuthoat});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // mnutai
            // 
            this.mnutai.Image = global::theZoo.Properties.Resources.spinner_512;
            this.mnutai.Name = "mnutai";
            this.mnutai.Size = new System.Drawing.Size(153, 22);
            this.mnutai.Text = "Tải Danh Sách";
            this.mnutai.Click += new System.EventHandler(this.mnutai_Click);
            // 
            // mnuluu
            // 
            this.mnuluu.Image = global::theZoo.Properties.Resources.Save_icon;
            this.mnuluu.Name = "mnuluu";
            this.mnuluu.Size = new System.Drawing.Size(153, 22);
            this.mnuluu.Text = "Lưu Danh Sách";
            this.mnuluu.Click += new System.EventHandler(this.save);
            // 
            // mnuthoat
            // 
            this.mnuthoat.Image = global::theZoo.Properties.Resources.images;
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(153, 22);
            this.mnuthoat.Text = "Thoát";
            this.mnuthoat.Click += new System.EventHandler(this.mnuthoat_Click);
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoToolStripMenuItem,
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa Đổi";
            // 
            // saoToolStripMenuItem
            // 
            this.saoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saoToolStripMenuItem.Image")));
            this.saoToolStripMenuItem.Name = "saoToolStripMenuItem";
            this.saoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoToolStripMenuItem.ShowShortcutKeys = false;
            this.saoToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.saoToolStripMenuItem.Text = "Sao ";
            this.saoToolStripMenuItem.Click += new System.EventHandler(this.saoToolStripMenuItem_Click);
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Image = global::theZoo.Properties.Resources.edit_scissor_cut_icon;
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cắtToolStripMenuItem.ShowShortcutKeys = false;
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.cắtToolStripMenuItem.Text = "Cắt";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Image = global::theZoo.Properties.Resources.paste;
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.dánToolStripMenuItem.ShowShortcutKeys = false;
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.dánToolStripMenuItem.Text = "Dán";
            // 
            // lblngaythang
            // 
            this.lblngaythang.AutoSize = true;
            this.lblngaythang.Location = new System.Drawing.Point(6, 207);
            this.lblngaythang.Name = "lblngaythang";
            this.lblngaythang.Size = new System.Drawing.Size(138, 13);
            this.lblngaythang.TabIndex = 6;
            this.lblngaythang.Text = "Bây giờ  là ngày tháng năm ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Save-icon.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 257);
            this.Controls.Add(this.lblngaythang);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lstthumoi;
        private System.Windows.Forms.ListBox lstdanhsach;
        private System.Windows.Forms.Label lblthumoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnutai;
        private System.Windows.Forms.ToolStripMenuItem mnuluu;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.Label lblngaythang;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

