namespace BaiTapNhom
{
    partial class NhanVien
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
            this.DataG_Nv = new System.Windows.Forms.DataGridView();
            this.Adress_Nv = new System.Windows.Forms.TextBox();
            this.Name_Nv = new System.Windows.Forms.TextBox();
            this.tbID_Nv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dele_NV = new System.Windows.Forms.Button();
            this.Exit_NV = new System.Windows.Forms.Button();
            this.Edit_NV = new System.Windows.Forms.Button();
            this.Add_NV = new System.Windows.Forms.Button();
            this.cbGioiTinh_nv = new System.Windows.Forms.ComboBox();
            this.date_Nv = new System.Windows.Forms.DateTimePicker();
            this.numbwe_Nv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataG_Nv)).BeginInit();
            this.SuspendLayout();
            // 
            // DataG_Nv
            // 
            this.DataG_Nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataG_Nv.Location = new System.Drawing.Point(379, 81);
            this.DataG_Nv.Name = "DataG_Nv";
            this.DataG_Nv.RowTemplate.Height = 25;
            this.DataG_Nv.Size = new System.Drawing.Size(488, 256);
            this.DataG_Nv.TabIndex = 25;
            // 
            // Adress_Nv
            // 
            this.Adress_Nv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Adress_Nv.ForeColor = System.Drawing.Color.Black;
            this.Adress_Nv.Location = new System.Drawing.Point(151, 281);
            this.Adress_Nv.Name = "Adress_Nv";
            this.Adress_Nv.Size = new System.Drawing.Size(193, 27);
            this.Adress_Nv.TabIndex = 21;
            // 
            // Name_Nv
            // 
            this.Name_Nv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Nv.ForeColor = System.Drawing.Color.Black;
            this.Name_Nv.Location = new System.Drawing.Point(151, 150);
            this.Name_Nv.Name = "Name_Nv";
            this.Name_Nv.Size = new System.Drawing.Size(193, 27);
            this.Name_Nv.TabIndex = 20;
            // 
            // tbID_Nv
            // 
            this.tbID_Nv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID_Nv.ForeColor = System.Drawing.Color.Black;
            this.tbID_Nv.Location = new System.Drawing.Point(151, 108);
            this.tbID_Nv.Name = "tbID_Nv";
            this.tbID_Nv.Size = new System.Drawing.Size(193, 27);
            this.tbID_Nv.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(29, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // Dele_NV
            // 
            this.Dele_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dele_NV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dele_NV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dele_NV.Location = new System.Drawing.Point(607, 384);
            this.Dele_NV.Name = "Dele_NV";
            this.Dele_NV.Size = new System.Drawing.Size(86, 34);
            this.Dele_NV.TabIndex = 29;
            this.Dele_NV.Text = "Xóa";
            this.Dele_NV.UseVisualStyleBackColor = true;
            this.Dele_NV.Click += new System.EventHandler(this.Dele_NV_Click);
            // 
            // Exit_NV
            // 
            this.Exit_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_NV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_NV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_NV.Location = new System.Drawing.Point(740, 384);
            this.Exit_NV.Name = "Exit_NV";
            this.Exit_NV.Size = new System.Drawing.Size(86, 34);
            this.Exit_NV.TabIndex = 28;
            this.Exit_NV.Text = "Thoát";
            this.Exit_NV.UseVisualStyleBackColor = true;
            this.Exit_NV.Click += new System.EventHandler(this.Exit_NV_Click);
            // 
            // Edit_NV
            // 
            this.Edit_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_NV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_NV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Edit_NV.Location = new System.Drawing.Point(213, 384);
            this.Edit_NV.Name = "Edit_NV";
            this.Edit_NV.Size = new System.Drawing.Size(86, 34);
            this.Edit_NV.TabIndex = 27;
            this.Edit_NV.Text = "Sửa";
            this.Edit_NV.UseVisualStyleBackColor = true;
            this.Edit_NV.Click += new System.EventHandler(this.Edit_NV_Click);
            // 
            // Add_NV
            // 
            this.Add_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_NV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_NV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_NV.Location = new System.Drawing.Point(53, 384);
            this.Add_NV.Name = "Add_NV";
            this.Add_NV.Size = new System.Drawing.Size(86, 34);
            this.Add_NV.TabIndex = 26;
            this.Add_NV.Text = "Thêm";
            this.Add_NV.UseVisualStyleBackColor = true;
            this.Add_NV.Click += new System.EventHandler(this.Add_NV_Click);
            // 
            // cbGioiTinh_nv
            // 
            this.cbGioiTinh_nv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGioiTinh_nv.ForeColor = System.Drawing.Color.Black;
            this.cbGioiTinh_nv.FormattingEnabled = true;
            this.cbGioiTinh_nv.Items.AddRange(new object[] {
            "Nam ",
            "Nu"});
            this.cbGioiTinh_nv.Location = new System.Drawing.Point(151, 188);
            this.cbGioiTinh_nv.Name = "cbGioiTinh_nv";
            this.cbGioiTinh_nv.Size = new System.Drawing.Size(121, 28);
            this.cbGioiTinh_nv.TabIndex = 30;
            // 
            // date_Nv
            // 
            this.date_Nv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_Nv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Nv.Location = new System.Drawing.Point(151, 238);
            this.date_Nv.Name = "date_Nv";
            this.date_Nv.Size = new System.Drawing.Size(121, 27);
            this.date_Nv.TabIndex = 31;
            // 
            // numbwe_Nv
            // 
            this.numbwe_Nv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numbwe_Nv.ForeColor = System.Drawing.Color.Black;
            this.numbwe_Nv.Location = new System.Drawing.Point(152, 326);
            this.numbwe_Nv.Name = "numbwe_Nv";
            this.numbwe_Nv.Size = new System.Drawing.Size(193, 27);
            this.numbwe_Nv.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(30, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Số Điện Thoại";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(356, 384);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(81, 30);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "Oke";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numbwe_Nv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_Nv);
            this.Controls.Add(this.cbGioiTinh_nv);
            this.Controls.Add(this.Dele_NV);
            this.Controls.Add(this.Exit_NV);
            this.Controls.Add(this.Edit_NV);
            this.Controls.Add(this.Add_NV);
            this.Controls.Add(this.DataG_Nv);
            this.Controls.Add(this.Adress_Nv);
            this.Controls.Add(this.Name_Nv);
            this.Controls.Add(this.tbID_Nv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataG_Nv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataG_Nv;
        private TextBox Adress_Nv;
        private TextBox Name_Nv;
        private TextBox tbID_Nv;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Dele_NV;
        private Button Exit_NV;
        private Button Edit_NV;
        private Button Add_NV;
        private ComboBox cbGioiTinh_nv;
        private DateTimePicker date_Nv;
        private TextBox numbwe_Nv;
        private Label label7;
        private Button btnOk;
    }
}