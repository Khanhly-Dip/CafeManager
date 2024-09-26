namespace BaiTapNhom
{
    partial class ThongkeBaocao
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
            this.DataGV6 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.btnChosse = new System.Windows.Forms.Button();
            this.btnExit_thongke = new System.Windows.Forms.Button();
            this.DataGV7 = new System.Windows.Forms.DataGridView();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV7)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGV6
            // 
            this.DataGV6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV6.Location = new System.Drawing.Point(12, 191);
            this.DataGV6.Name = "DataGV6";
            this.DataGV6.RowTemplate.Height = 25;
            this.DataGV6.Size = new System.Drawing.Size(418, 247);
            this.DataGV6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ BÁO CÁO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(97, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(97, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ Ngày";
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(205, 133);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(150, 23);
            this.date2.TabIndex = 5;
            // 
            // btnChosse
            // 
            this.btnChosse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChosse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChosse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChosse.Location = new System.Drawing.Point(490, 66);
            this.btnChosse.Name = "btnChosse";
            this.btnChosse.Size = new System.Drawing.Size(107, 33);
            this.btnChosse.TabIndex = 6;
            this.btnChosse.Text = "Thống Kê";
            this.btnChosse.UseVisualStyleBackColor = true;
            this.btnChosse.Click += new System.EventHandler(this.btnChosse_Click);
            // 
            // btnExit_thongke
            // 
            this.btnExit_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit_thongke.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit_thongke.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit_thongke.Location = new System.Drawing.Point(490, 123);
            this.btnExit_thongke.Name = "btnExit_thongke";
            this.btnExit_thongke.Size = new System.Drawing.Size(107, 33);
            this.btnExit_thongke.TabIndex = 7;
            this.btnExit_thongke.Text = "Trở Về";
            this.btnExit_thongke.UseVisualStyleBackColor = true;
            this.btnExit_thongke.Click += new System.EventHandler(this.btnExit_thongke_Click);
            // 
            // DataGV7
            // 
            this.DataGV7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV7.Location = new System.Drawing.Point(468, 191);
            this.DataGV7.Name = "DataGV7";
            this.DataGV7.RowTemplate.Height = 25;
            this.DataGV7.Size = new System.Drawing.Size(296, 150);
            this.DataGV7.TabIndex = 8;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(205, 80);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(150, 23);
            this.date1.TabIndex = 9;
            // 
            // ThongkeBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.DataGV7);
            this.Controls.Add(this.btnExit_thongke);
            this.Controls.Add(this.btnChosse);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGV6);
            this.Name = "ThongkeBaocao";
            this.Text = "ThongkeBaocao";
            this.Load += new System.EventHandler(this.ThongkeBaocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGV6;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker date2;
        private Button btnChosse;
        private Button btnExit_thongke;
        private DataGridView DataGV7;
        private DateTimePicker date1;
    }
}