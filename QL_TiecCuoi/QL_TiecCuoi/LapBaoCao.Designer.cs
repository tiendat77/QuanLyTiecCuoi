namespace QL_TiecCuoi
{
    partial class LapBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapBaoCao));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDoanhThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.textBoxSoLuongTiec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(377, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập Báo Cáo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerNgayBaoCao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDoanhThu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBox1.Controls.Add(this.textBoxSoLuongTiec);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(920, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // dateTimePickerNgayBaoCao
            // 
            this.dateTimePickerNgayBaoCao.AllowDrop = true;
            this.dateTimePickerNgayBaoCao.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayBaoCao.Location = new System.Drawing.Point(205, 74);
            this.dateTimePickerNgayBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerNgayBaoCao.Name = "dateTimePickerNgayBaoCao";
            this.dateTimePickerNgayBaoCao.ShowUpDown = true;
            this.dateTimePickerNgayBaoCao.Size = new System.Drawing.Size(253, 26);
            this.dateTimePickerNgayBaoCao.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(35, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày báo cáo";
            // 
            // textBoxDoanhThu
            // 
            this.textBoxDoanhThu.Location = new System.Drawing.Point(633, 76);
            this.textBoxDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDoanhThu.Name = "textBoxDoanhThu";
            this.textBoxDoanhThu.Size = new System.Drawing.Size(253, 26);
            this.textBoxDoanhThu.TabIndex = 13;
            this.textBoxDoanhThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoanhThu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(491, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doanh thu";
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(205, 26);
            this.dateTimePickerNgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(253, 26);
            this.dateTimePickerNgayLap.TabIndex = 12;
            // 
            // textBoxSoLuongTiec
            // 
            this.textBoxSoLuongTiec.Location = new System.Drawing.Point(633, 28);
            this.textBoxSoLuongTiec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSoLuongTiec.Name = "textBoxSoLuongTiec";
            this.textBoxSoLuongTiec.Size = new System.Drawing.Size(253, 26);
            this.textBoxSoLuongTiec.TabIndex = 11;
            this.textBoxSoLuongTiec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoLuongTiec_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(491, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng tiệc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(35, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày lập";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LapBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệc cưới";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSoLuongTiec;
        private System.Windows.Forms.TextBox textBoxDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBaoCao;
    }
}