namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtSNLV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.gbGT = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSGTC = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giolam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tangca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // dtpNS
            // 
            this.dtpNS.Location = new System.Drawing.Point(152, 112);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(200, 20);
            this.dtpNS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số ngày làm việc";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(152, 23);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(200, 20);
            this.txtMa.TabIndex = 2;
            this.txtMa.Text = "01";
            // 
            // txtSNLV
            // 
            this.txtSNLV.Location = new System.Drawing.Point(152, 152);
            this.txtSNLV.Name = "txtSNLV";
            this.txtSNLV.Size = new System.Drawing.Size(119, 20);
            this.txtSNLV.TabIndex = 2;
            this.txtSNLV.Text = "0";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(152, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 3;
            this.txtTen.Text = "Nguyễn Văn A";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(571, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 28);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(571, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(95, 28);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(571, 112);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 28);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(27, 19);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 5;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(27, 45);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 5;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // gbGT
            // 
            this.gbGT.Controls.Add(this.rbNu);
            this.gbGT.Controls.Add(this.rbNam);
            this.gbGT.Location = new System.Drawing.Point(402, 23);
            this.gbGT.Name = "gbGT";
            this.gbGT.Size = new System.Drawing.Size(82, 89);
            this.gbGT.TabIndex = 6;
            this.gbGT.TabStop = false;
            this.gbGT.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lương thực tập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số giờ tăng ca";
            // 
            // txtLuong
            // 
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(402, 177);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(112, 20);
            this.txtLuong.TabIndex = 9;
            // 
            // txtSGTC
            // 
            this.txtSGTC.Location = new System.Drawing.Point(402, 145);
            this.txtSGTC.Name = "txtSGTC";
            this.txtSGTC.Size = new System.Drawing.Size(111, 20);
            this.txtSGTC.TabIndex = 10;
            this.txtSGTC.Text = "0";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(571, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu File";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manv,
            this.Tennv,
            this.Gt,
            this.Ngaysinh,
            this.Giolam,
            this.Tangca,
            this.LuongNV});
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNV.Location = new System.Drawing.Point(0, 217);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(800, 92);
            this.dgvNV.TabIndex = 12;
            this.dgvNV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_RowEnter);
            // 
            // Manv
            // 
            this.Manv.DataPropertyName = "Manv";
            this.Manv.HeaderText = "Mã nhân viên";
            this.Manv.Name = "Manv";
            // 
            // Tennv
            // 
            this.Tennv.DataPropertyName = "Tennv";
            this.Tennv.HeaderText = "Tên nhân viên";
            this.Tennv.Name = "Tennv";
            // 
            // Gt
            // 
            this.Gt.DataPropertyName = "Gt";
            this.Gt.HeaderText = "Giới tính";
            this.Gt.Name = "Gt";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Giolam
            // 
            this.Giolam.DataPropertyName = "Giolam";
            this.Giolam.HeaderText = "Số giờ làm việc";
            this.Giolam.Name = "Giolam";
            // 
            // Tangca
            // 
            this.Tangca.DataPropertyName = "Tangca";
            this.Tangca.HeaderText = "Số tăng ca";
            this.Tangca.Name = "Tangca";
            // 
            // LuongNV
            // 
            this.LuongNV.DataPropertyName = "LuongNV";
            this.LuongNV.HeaderText = "Lương thực lãnh";
            this.LuongNV.Name = "LuongNV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSGTC);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbGT);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSNLV);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.dtpNS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGT.ResumeLayout(false);
            this.gbGT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtSNLV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.GroupBox gbGT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtSGTC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tangca;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongNV;
    }
}

