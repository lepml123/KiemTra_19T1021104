namespace KiemTra_19T1021104
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textTen = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textDiachi = new System.Windows.Forms.TextBox();
            this.cbxNhom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Liên Lạc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chọn nhóm:";
            // 
            // textTen
            // 
            this.textTen.Location = new System.Drawing.Point(216, 115);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(224, 22);
            this.textTen.TabIndex = 0;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(216, 161);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(224, 22);
            this.textEmail.TabIndex = 1;
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(216, 215);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(224, 22);
            this.textSDT.TabIndex = 2;
            // 
            // textDiachi
            // 
            this.textDiachi.Location = new System.Drawing.Point(216, 272);
            this.textDiachi.Name = "textDiachi";
            this.textDiachi.Size = new System.Drawing.Size(224, 22);
            this.textDiachi.TabIndex = 3;
            // 
            // cbxNhom
            // 
            this.cbxNhom.FormattingEnabled = true;
            this.cbxNhom.Location = new System.Drawing.Point(216, 329);
            this.cbxNhom.Name = "cbxNhom";
            this.cbxNhom.Size = new System.Drawing.Size(224, 24);
            this.cbxNhom.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxNhom);
            this.Controls.Add(this.textDiachi);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textDiachi;
        private System.Windows.Forms.ComboBox cbxNhom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}