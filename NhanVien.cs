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
    public partial class NhanVien : Form
    {
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;

        internal string datebirth;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
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
        void HienThi()
        {
            string sql2 = "SELECT MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT FROM dbo.NhanVien";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = new SqlCommand(sql2, connect);
            adt.SelectCommand.ExecuteNonQuery();

            DataG_Nv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataG_Nv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataG_Nv.ScrollBars = ScrollBars.None;
            DataTable tb = new DataTable();
            adt.Fill(tb);
            DataG_Nv.DataSource = tb;
        }

        private void Exit_NV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbID_Nv_Leave(object sender, EventArgs e)
        {
            string temp = "SELECT Pass FROM dbo.Admin WHERE Account = @Account";
            SqlCommand com = new SqlCommand(temp, connect);
            com.Parameters.AddWithValue("@Account", tbID_Nv.Text);

            SqlDataReader reader1 = com.ExecuteReader();
            if (reader1.Read())
            {
                
                MessageBox.Show("Mã Nhân Viên đã tồn tại, Vui lòng nhập lại");
                tbID_Nv.Text = "";
            }
            reader1.Close();
        }
        private void Add_NV_Click(object sender, EventArgs e)
        {
            datebirth = date_Nv.Value.ToString("yyyy/MM/dd");

            string sql1 = "INSERT INTO dbo.NhanVien(MaNV, HoTen, NgaySinh,GioiTinh,DiaChi,SDT) VALUES ('" + tbID_Nv.Text + "','"
                   + Name_Nv.Text + "','" + datebirth + "','" + cbGioiTinh_nv.Text + "', '" + Adress_Nv.Text + "','"+ numbwe_Nv.Text+"')";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            adapter1.InsertCommand = new SqlCommand(sql1, connect);
            adapter1.InsertCommand.ExecuteNonQuery();
            HienThi();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            datebirth = date_Nv.Value.ToString("yyyy/MM/dd");

            string sql3 = "UPDATE dbo.NhanVien SET  HoTen = '"+ Name_Nv.Text + "', NgaySinh = '" + datebirth + "',GioiTinh = '" + cbGioiTinh_nv.Text + "',DiaChi =  '" + Adress_Nv.Text + "',SDT ='" + numbwe_Nv.Text + "'where MaNV = '" + tbID_Nv.Text + "'";

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            adapter2.InsertCommand = new SqlCommand(sql3, connect);
            adapter2.InsertCommand.ExecuteNonQuery();
            HienThi();
        }

        private void Edit_NV_Click(object sender, EventArgs e)
        {
            if (DataG_Nv.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = DataG_Nv.SelectedRows[0];

                // Lấy giá trị của các ô cụ thể trong hàng đã chọn
                tbID_Nv.Text = selectedRow.Cells[0].Value.ToString(); // Cột đầu tiên
                Name_Nv.Text = selectedRow.Cells[1].Value.ToString(); // Cột thứ hai
                cbGioiTinh_nv.Text = selectedRow.Cells[3].Value.ToString(); // Cột thứ ba
                Adress_Nv.Text = selectedRow.Cells[4].Value.ToString(); // Cột thứ năm
                numbwe_Nv.Text = selectedRow.Cells[5].Value.ToString(); // Cột thứ sáu
                date_Nv.Value = Convert.ToDateTime(selectedRow.Cells[2].Value);
            }
        }

        private void Dele_NV_Click(object sender, EventArgs e)
        {
            string Del = DataG_Nv.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Ban chac chan muon xoa sinh vien co ma sv: "
                + Del, "Thong bao", MessageBoxButtons.YesNo);

           
                if (DataG_Nv.SelectedRows.Count > 0)
                {
                if (result == DialogResult.Yes) {
                    string sql4 = "DELETE FROM dbo.NhanVien WHERE MaNV = '" + Del + "'";
                    SqlDataAdapter adapter3 = new SqlDataAdapter();
                    adapter3.DeleteCommand = new SqlCommand(sql4, connect);
                    adapter3.DeleteCommand.ExecuteNonQuery();

                    HienThi();
                }
                
            }
        }
    }
}
