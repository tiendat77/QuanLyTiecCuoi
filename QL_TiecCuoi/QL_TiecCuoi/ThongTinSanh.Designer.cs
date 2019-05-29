namespace QL_TiecCuoi
{
    partial class ThongTinSanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinSanh));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDS_Sanh = new System.Windows.Forms.DataGridView();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxBan = new System.Windows.Forms.TextBox();
            this.textBoxLoai = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_Sanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông Tin Sảnh ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewDS_Sanh);
            this.groupBox4.Controls.Add(this.textBoxGhiChu);
            this.groupBox4.Controls.Add(this.textBoxGia);
            this.groupBox4.Controls.Add(this.textBoxBan);
            this.groupBox4.Controls.Add(this.textBoxLoai);
            this.groupBox4.Controls.Add(this.textBoxTen);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.buttonSua);
            this.groupBox4.Controls.Add(this.buttonThem);
            this.groupBox4.Controls.Add(this.buttonXoa);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(10, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(616, 300);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin sảnh";
            // 
            // dataGridViewDS_Sanh
            // 
            this.dataGridViewDS_Sanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_Sanh.Location = new System.Drawing.Point(8, 159);
            this.dataGridViewDS_Sanh.Name = "dataGridViewDS_Sanh";
            this.dataGridViewDS_Sanh.Size = new System.Drawing.Size(599, 128);
            this.dataGridViewDS_Sanh.TabIndex = 5;
            this.dataGridViewDS_Sanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDS_Sanh_CellContentClick);
            this.dataGridViewDS_Sanh.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewDS_Sanh_RowHeaderMouseClick);
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Location = new System.Drawing.Point(326, 70);
            this.textBoxGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(98, 22);
            this.textBoxGhiChu.TabIndex = 18;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(148, 70);
            this.textBoxGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(98, 22);
            this.textBoxGia.TabIndex = 17;
            this.textBoxGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSo_KeyPress);
            // 
            // textBoxBan
            // 
            this.textBoxBan.Location = new System.Drawing.Point(570, 26);
            this.textBoxBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBan.Name = "textBoxBan";
            this.textBoxBan.Size = new System.Drawing.Size(38, 22);
            this.textBoxBan.TabIndex = 16;
            this.textBoxBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSo_KeyPress);
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.Location = new System.Drawing.Point(326, 24);
            this.textBoxLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.Size = new System.Drawing.Size(98, 22);
            this.textBoxLoai.TabIndex = 15;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(148, 24);
            this.textBoxTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(98, 22);
            this.textBoxTen.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(255, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ghi Chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn Giá Bàn Tối Thiểu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(435, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số Lượng Bàn Tối Đa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(255, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại Sảnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Sảnh:";
            // 
            // buttonSua
            // 
            this.buttonSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSua.Location = new System.Drawing.Point(532, 112);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 8;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonThem.Location = new System.Drawing.Point(370, 112);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonXoa.Location = new System.Drawing.Point(452, 112);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 7;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonThoat.Location = new System.Drawing.Point(542, 372);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 9;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ThongTinSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 405);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ThongTinSanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệc cưới";
            this.Load += new System.EventHandler(this.ThongTin_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_Sanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewDS_Sanh;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxBan;
        private System.Windows.Forms.TextBox textBoxLoai;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGhiChu;
    }
}