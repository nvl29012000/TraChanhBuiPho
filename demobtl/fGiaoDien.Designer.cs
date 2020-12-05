namespace demobtl
{
    partial class fGiaoDien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnstipaccount = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripchamcong = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvbill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbsum = new System.Windows.Forms.TextBox();
            this.btntablechange = new System.Windows.Forms.Button();
            this.nmrdiscount = new System.Windows.Forms.NumericUpDown();
            this.btndiscount = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmrcount = new System.Windows.Forms.NumericUpDown();
            this.btnaddfood = new System.Windows.Forms.Button();
            this.cbfood = new System.Windows.Forms.ComboBox();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.fpnltable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrdiscount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnstipaccount,
            this.mnstripchamcong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnstipaccount
            // 
            this.mnstipaccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.mnstipaccount.Name = "mnstipaccount";
            this.mnstipaccount.Size = new System.Drawing.Size(69, 20);
            this.mnstipaccount.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // mnstripchamcong
            // 
            this.mnstripchamcong.Name = "mnstripchamcong";
            this.mnstripchamcong.Size = new System.Drawing.Size(146, 20);
            this.mnstripchamcong.Text = "Nhân viên - Chấm công";
            this.mnstripchamcong.Click += new System.EventHandler(this.mnstripchamcong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvbill);
            this.panel1.Location = new System.Drawing.Point(472, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 328);
            this.panel1.TabIndex = 2;
            // 
            // lsvbill
            // 
            this.lsvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvbill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvbill.HideSelection = false;
            this.lsvbill.Location = new System.Drawing.Point(3, 3);
            this.lsvbill.Name = "lsvbill";
            this.lsvbill.Size = new System.Drawing.Size(377, 322);
            this.lsvbill.TabIndex = 0;
            this.lsvbill.UseCompatibleStateImageBehavior = false;
            this.lsvbill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbsum);
            this.panel2.Controls.Add(this.btntablechange);
            this.panel2.Controls.Add(this.nmrdiscount);
            this.panel2.Controls.Add(this.btndiscount);
            this.panel2.Controls.Add(this.btnout);
            this.panel2.Location = new System.Drawing.Point(472, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 61);
            this.panel2.TabIndex = 3;
            // 
            // txbsum
            // 
            this.txbsum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsum.Location = new System.Drawing.Point(137, 29);
            this.txbsum.Name = "txbsum";
            this.txbsum.ReadOnly = true;
            this.txbsum.Size = new System.Drawing.Size(117, 29);
            this.txbsum.TabIndex = 8;
            this.txbsum.Text = "0";
            // 
            // btntablechange
            // 
            this.btntablechange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntablechange.Location = new System.Drawing.Point(137, 0);
            this.btntablechange.Name = "btntablechange";
            this.btntablechange.Size = new System.Drawing.Size(117, 30);
            this.btntablechange.TabIndex = 7;
            this.btntablechange.Text = "Tổng tiền";
            this.btntablechange.UseVisualStyleBackColor = true;
            // 
            // nmrdiscount
            // 
            this.nmrdiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrdiscount.Location = new System.Drawing.Point(3, 29);
            this.nmrdiscount.Name = "nmrdiscount";
            this.nmrdiscount.Size = new System.Drawing.Size(128, 29);
            this.nmrdiscount.TabIndex = 5;
            this.nmrdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrdiscount.ValueChanged += new System.EventHandler(this.nmrdiscount_ValueChanged);
            // 
            // btndiscount
            // 
            this.btndiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiscount.Location = new System.Drawing.Point(3, 0);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(128, 30);
            this.btndiscount.TabIndex = 4;
            this.btndiscount.Text = "Chiết khấu";
            this.btndiscount.UseVisualStyleBackColor = true;
            // 
            // btnout
            // 
            this.btnout.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.Location = new System.Drawing.Point(260, 0);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(117, 58);
            this.btnout.TabIndex = 3;
            this.btnout.Text = "Thanh toán";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmrcount);
            this.panel3.Controls.Add(this.btnaddfood);
            this.panel3.Controls.Add(this.cbfood);
            this.panel3.Controls.Add(this.cbcategory);
            this.panel3.Location = new System.Drawing.Point(472, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 80);
            this.panel3.TabIndex = 4;
            // 
            // nmrcount
            // 
            this.nmrcount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcount.Location = new System.Drawing.Point(260, 3);
            this.nmrcount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrcount.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nmrcount.Name = "nmrcount";
            this.nmrcount.Size = new System.Drawing.Size(117, 35);
            this.nmrcount.TabIndex = 3;
            this.nmrcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnaddfood
            // 
            this.btnaddfood.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddfood.Location = new System.Drawing.Point(260, 39);
            this.btnaddfood.Name = "btnaddfood";
            this.btnaddfood.Size = new System.Drawing.Size(117, 38);
            this.btnaddfood.TabIndex = 2;
            this.btnaddfood.Text = "Thêm món";
            this.btnaddfood.UseVisualStyleBackColor = true;
            this.btnaddfood.Click += new System.EventHandler(this.btnaddfood_Click);
            // 
            // cbfood
            // 
            this.cbfood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfood.FormattingEnabled = true;
            this.cbfood.Location = new System.Drawing.Point(3, 39);
            this.cbfood.Name = "cbfood";
            this.cbfood.Size = new System.Drawing.Size(251, 29);
            this.cbfood.TabIndex = 1;
            // 
            // cbcategory
            // 
            this.cbcategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(3, 0);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(251, 29);
            this.cbcategory.TabIndex = 0;
            this.cbcategory.SelectedValueChanged += new System.EventHandler(this.cbcategory_SelectedValueChanged);
            // 
            // fpnltable
            // 
            this.fpnltable.AutoScroll = true;
            this.fpnltable.Location = new System.Drawing.Point(0, 28);
            this.fpnltable.Name = "fpnltable";
            this.fpnltable.Size = new System.Drawing.Size(466, 478);
            this.fpnltable.TabIndex = 5;
            // 
            // fgiaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(855, 507);
            this.Controls.Add(this.fpnltable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "fgiaodien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRÀ CHANH BỤI PHỐ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fgiaodien_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrdiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnstipaccount;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnstripchamcong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvbill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmrdiscount;
        private System.Windows.Forms.Button btndiscount;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmrcount;
        private System.Windows.Forms.Button btnaddfood;
        private System.Windows.Forms.ComboBox cbfood;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.FlowLayoutPanel fpnltable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbsum;
        private System.Windows.Forms.Button btntablechange;
    }
}