namespace QL_TiecCuoi
{
    partial class BaoCaoDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoDoanhThu));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_tatca = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTongDoanhThu = new System.Windows.Forms.DataGridView();
            this.labelThang = new System.Windows.Forms.Label();
            this.button_thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSBaoCao = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTongDoanhThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo Cáo Doanh Số";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_tatca);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.labelThang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(4, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(920, 489);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // button_tatca
            // 
            this.button_tatca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_tatca.Location = new System.Drawing.Point(659, 41);
            this.button_tatca.Margin = new System.Windows.Forms.Padding(4);
            this.button_tatca.Name = "button_tatca";
            this.button_tatca.Size = new System.Drawing.Size(122, 28);
            this.button_tatca.TabIndex = 22;
            this.button_tatca.Text = "Xem tất cả";
            this.button_tatca.UseVisualStyleBackColor = true;
            this.button_tatca.Visible = false;
            this.button_tatca.Click += new System.EventHandler(this.ButtonTatca_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(417, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 26);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewTongDoanhThu);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(8, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(897, 132);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng doanh thu theo tháng";
            // 
            // dataGridViewTongDoanhThu
            // 
            this.dataGridViewTongDoanhThu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTongDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTongDoanhThu.Location = new System.Drawing.Point(15, 26);
            this.dataGridViewTongDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTongDoanhThu.Name = "dataGridViewTongDoanhThu";
            this.dataGridViewTongDoanhThu.ReadOnly = true;
            this.dataGridViewTongDoanhThu.Size = new System.Drawing.Size(868, 82);
            this.dataGridViewTongDoanhThu.TabIndex = 0;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelThang.Location = new System.Drawing.Point(312, 49);
            this.labelThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(55, 20);
            this.labelThang.TabIndex = 1;
            this.labelThang.Text = "Tháng";
            // 
            // button_thoat
            // 
            this.button_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_thoat.Location = new System.Drawing.Point(807, 582);
            this.button_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(100, 28);
            this.button_thoat.TabIndex = 17;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDSBaoCao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(8, 246);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(897, 225);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách báo cáo của tháng";
            // 
            // dataGridViewDSBaoCao
            // 
            this.dataGridViewDSBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSBaoCao.Location = new System.Drawing.Point(15, 26);
            this.dataGridViewDSBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDSBaoCao.Name = "dataGridViewDSBaoCao";
            this.dataGridViewDSBaoCao.Size = new System.Drawing.Size(868, 192);
            this.dataGridViewDSBaoCao.TabIndex = 0;
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệc cưới";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTongDoanhThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDSBaoCao;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_tatca;
        private System.Windows.Forms.DataGridView dataGridViewTongDoanhThu;
    }
}