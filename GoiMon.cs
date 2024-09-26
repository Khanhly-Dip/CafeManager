using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class Gọi_Món : Form
    {
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;
        decimal tongGia = 0;
        int somon = 0;
        public string soBan { get; set; }
        public Gọi_Món()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            string sql2 = "SELECT TenMon, Gia, PhanLoai FROM dbo.ThucDon";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = new SqlCommand(sql2, connect);
            adt.SelectCommand.ExecuteNonQuery();

            DataGV3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGV3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGV3.ScrollBars = ScrollBars.None;
            DataTable tb = new DataTable();
            adt.Fill(tb);
            DataGV3.DataSource = tb;
        }
        void Choose()
        {
           
        }
        private void Gọi_Món_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            try
            {
                connect.Open();
                HienThi();
               


            }
            catch
            {
                MessageBox.Show("Lỗi Hệ Thống!! Xin Vui Lòng Thử Lại.", "Thông báo");
            }
        }

        private void Chon_GoiMon_Click(object sender, EventArgs e)
        {
            string Del = DataGV3.SelectedRows[0].Cells[0].Value.ToString();
            if (DataGV3.SelectedRows.Count > 0)
            {
                string tenMon = DataGV3.SelectedRows[0].Cells["TenMon"].Value.ToString();
                decimal gia = decimal.Parse(DataGV3.SelectedRows[0].Cells["Gia"].Value.ToString());
                int soLuong = 0;
                if(Quality.Text == "So Luong")
                {
                    soLuong = 1;
                }
                else {
                    soLuong = int.Parse(Quality.Text);
                }
                // Tạo một DataTable mới hoặc sử dụng DataTable hiện tại của DataGridView
                DataTable dt;
                if (DataGV4.DataSource == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("TenMon", typeof(string));
                    dt.Columns.Add("Gia", typeof(decimal));
                    // Gán DataTable cho DataSource của DataGridView
                    DataGV4.DataSource = dt;
                }
                else
                {
                    dt = (DataTable)DataGV4.DataSource;
                }

                // Thêm dữ liệu vào DataTable
                for (int i = 0; i < soLuong; i++)
                {
                    dt.Rows.Add(tenMon, gia);
                    somon++;
                }

                tongGia = 0;

                // Lặp qua từng hàng trong DataGridView3 và tính tổng giá
                foreach (DataGridViewRow row in DataGV4.Rows)
                {
                    // Kiểm tra xem ô dữ liệu không rỗng và có thể chuyển đổi thành giá trị decimal
                    if (!row.IsNewRow && row.Cells["Gia"].Value != null && row.Cells["Gia"].Value != DBNull.Value)
                    {
                        tongGia += Convert.ToDecimal(row.Cells["Gia"].Value);
                       

                    }
                }

                // Hiển thị tổng giá trong DataGridView5
                DataTable dt1 = new DataTable();
                dt1.Columns.Add("Thông tin");
                dt1.Columns.Add("Số Lượng");

                // Thêm thông tin tổng giá vào DataTable
                dt1.Rows.Add("Số lượng:", somon);
                dt1.Rows.Add("Tổng giá:", tongGia);

                // Gán DataTable cho DataGridView5
                DataGV5.DataSource = dt1;
                Quality.Text = "So Luong";
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan ttoan = new ThanhToan();
            ttoan.Total = tongGia;
            ttoan.Quali = somon;
            ttoan.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
