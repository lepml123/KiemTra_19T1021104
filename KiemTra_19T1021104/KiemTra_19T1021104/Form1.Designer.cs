namespace KiemTra_19T1021104
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridnhom = new System.Windows.Forms.DataGridView();
            this.gridnguoi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttengoi = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.Label();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridnhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridnguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.txttengoi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gridnguoi);
            this.panel1.Controls.Add(this.gridnhom);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 506);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::KiemTra_19T1021104.Properties.Resources._4781840___add_circle_create_expand_icon__1_;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel1.Text = "Thêm nhóm";
            this.toolStripLabel1.Click += new System.EventHandler(this.ClickThemNhom);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::KiemTra_19T1021104.Properties.Resources._1564505_close_delete_exit_remove_icon;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabel2.Text = "Xóa nhóm";
            this.toolStripLabel2.Click += new System.EventHandler(this.ClickXoaNhom);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::KiemTra_19T1021104.Properties.Resources._4781840___add_circle_create_expand_icon__1_;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(117, 22);
            this.toolStripLabel3.Text = "Thêm liên lạc";
            this.toolStripLabel3.Click += new System.EventHandler(this.ClickThemLienLac);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = global::KiemTra_19T1021104.Properties.Resources._1564505_close_delete_exit_remove_icon;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(106, 22);
            this.toolStripLabel4.Text = "Xóa liên lạc";
            this.toolStripLabel4.Click += new System.EventHandler(this.ClickXoaLienLac);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập từ cần tìm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(712, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 3;
            // 
            // gridnhom
            // 
            this.gridnhom.AutoGenerateColumns = false;
            this.gridnhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.gridnhom.DataSource = this.nhomBindingSource;
            this.gridnhom.Location = new System.Drawing.Point(3, 3);
            this.gridnhom.Name = "gridnhom";
            this.gridnhom.RowHeadersWidth = 51;
            this.gridnhom.RowTemplate.Height = 24;
            this.gridnhom.Size = new System.Drawing.Size(299, 500);
            this.gridnhom.TabIndex = 0;
            this.gridnhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridnhom_cellclick);
            // 
            // gridnguoi
            // 
            this.gridnguoi.AutoGenerateColumns = false;
            this.gridnguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnguoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SDT});
            this.gridnguoi.DataSource = this.nguoiBindingSource;
            this.gridnguoi.Location = new System.Drawing.Point(308, 3);
            this.gridnguoi.Name = "gridnguoi";
            this.gridnguoi.RowHeadersWidth = 51;
            this.gridnguoi.RowTemplate.Height = 24;
            this.gridnguoi.Size = new System.Drawing.Size(604, 338);
            this.gridnguoi.TabIndex = 1;
            this.gridnguoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNguoi_cellclick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "[Tên Gọi]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại:";
            // 
            // txttengoi
            // 
            this.txttengoi.AutoSize = true;
            this.txttengoi.Location = new System.Drawing.Point(508, 368);
            this.txttengoi.Name = "txttengoi";
            this.txttengoi.Size = new System.Drawing.Size(0, 16);
            this.txttengoi.TabIndex = 3;
            // 
            // txtdiachi
            // 
            this.txtdiachi.AutoSize = true;
            this.txtdiachi.Location = new System.Drawing.Point(508, 401);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(0, 16);
            this.txtdiachi.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(508, 436);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(0, 16);
            this.txtemail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 3;
            // 
            // txtsdt
            // 
            this.txtsdt.AutoSize = true;
            this.txtsdt.Location = new System.Drawing.Point(508, 473);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(0, 16);
            this.txtsdt.TabIndex = 3;
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "TenGoi";
            this.TenGoi.HeaderText = "TenGoi";
            this.TenGoi.MinimumWidth = 6;
            this.TenGoi.Name = "TenGoi";
            this.TenGoi.Width = 160;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 220;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 170;
            // 
            // nguoiBindingSource
            // 
            this.nguoiBindingSource.DataSource = typeof(KiemTra_19T1021104.Model.Nguoi);
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "TenNhom";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Width = 245;
            // 
            // nhomBindingSource
            // 
            this.nhomBindingSource.DataSource = typeof(KiemTra_19T1021104.Model.Nhom);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridnhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridnguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gridnguoi;
        private System.Windows.Forms.DataGridView gridnhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtsdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtdiachi;
        private System.Windows.Forms.Label txttengoi;
        private System.Windows.Forms.BindingSource nguoiBindingSource;
        private System.Windows.Forms.BindingSource nhomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}

