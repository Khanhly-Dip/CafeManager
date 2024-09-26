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
    public partial class ThongkeBaocao : Form
    {
        internal string ngaybd, ngaykt;
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;

        public ThongkeBaocao()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            string sql2 = "SELECT IDHD, MaNV, Ngay, SLMon, ThanhTien FROM  dbo.HoaDon";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = new SqlCommand(sql2, connect);
            adt.SelectCommand.ExecuteNonQuery();

            DataGV6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGV6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGV6.ScrollBars = ScrollBars.None;
            DataTable tb = new DataTable();
            adt.Fill(tb);
            DataGV6.DataSource = tb;
        }

        private void btnExit_thongke_Click(object sender, EventArgs e)
        {
            QuanTri qt = new QuanTri();
            qt.ShowDialog();
        }

        private void btnChosse_Click(object sender, EventArgs e)
        {
            ngaybd = date1.Value.ToString("yyyy/MM/dd");
            ngaykt = date2.Value.ToString("yyyy/MM/dd");
            string query = "SELECT * FROM dbo.HoaDon WHERE Ngay >= @startDate AND Ngay <= @endDate";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@startDate", ngaybd);
            cmd.Parameters.AddWithValue("@endDate", ngaykt);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataGV6.DataSource = dataTable;

            //Hiển thị sang DTGV7
            int totalQuantity = 0;
            double totalPrice = 0;

            foreach (DataGridViewRow row in DataGV6.Rows)
            {
                if (row.Cells["SLMon"].Value != null)
                {
                    totalQuantity += Convert.ToInt32(row.Cells["SLMon"].Value);
                }

                if (row.Cells["ThanhTien"].Value != null)
                {
                    double price = Convert.ToDouble(row.Cells["ThanhTien"].Value);
                    totalPrice += price;
                }
            }

            // Thêm cột nếu chưa tồn tại
            if (DataGV7.Columns.Count == 0)
            {
                DataGV7.Columns.Add("SLMon", "Tổng Số Lượng");
                DataGV7.Columns.Add("ThanhTien", "Tổng Tiền");
            }

            // Xóa tất cả các dòng hiện có trên DataGridView7
            DataGV7.Rows.Clear();

            // Thêm một dòng mới vào DataGridView7 và hiển thị tổng số lượng và tổng tiền
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = totalQuantity });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = totalPrice });
            DataGV7.Rows.Add(newRow);
        }

        private void ThongkeBaocao_Load(object sender, EventArgs e)
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
    }
}
