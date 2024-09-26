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
    public partial class ThanhToan : Form
    {
        public decimal Total { get; set; }
        public int Quali { get; set; }
        internal string date;
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;
        public string soBan { get; set; }
        public ThanhToan()
        {
            InitializeComponent();

        }
        public ThanhToan(decimal Total)
        {
            TaTol.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gọi_Món or = new Gọi_Món();
            or.ShowDialog();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            connect.Open();
            TaTol.Text = Total.ToString();
            Qua_HD.Text = Quali.ToString();
          

        }

        private void Done_Click(object sender, EventArgs e)
        {
            string temp = "SELECT MaNV FROM dbo.NhanVien WHERE MaNV = @Account";
            SqlCommand com = new SqlCommand(temp, connect);
            com.Parameters.AddWithValue("@Account", NV_HD.Text);

            SqlDataReader reader1 = com.ExecuteReader();
            if (reader1.Read())
            {
                reader1.Close();
                string ttrang = "Chua";
                date = date_1.Value.ToString("yyyy/MM/dd");
                string sql1 = "INSERT INTO dbo.Hoadon(IDHD, MaNV, Ngay, SLMon, ThanhTien, SoBan, TinhTrang) VALUES ('" + ID_Hd.Text + "','"
                   + NV_HD.Text + "','" + date + "','" + Qua_HD.Text + "', '" + TaTol.Text + "', '" + tb1.Text + "', '" + ttrang + "')";

                SqlDataAdapter adapter1 = new SqlDataAdapter();
                adapter1.InsertCommand = new SqlCommand(sql1, connect);
                adapter1.InsertCommand.ExecuteNonQuery();

                string tt1 = "Dat";
                string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + tb1.Text + "'";
                SqlDataAdapter adapter3 = new SqlDataAdapter();
                adapter3.InsertCommand = new SqlCommand(sql2, connect);
                adapter3.InsertCommand.ExecuteNonQuery();
                DatBan or1 = new DatBan();
                or1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã nhân viên không chính xác vui lòng nhập lại!");
                NV_HD.Text = "";
                reader1.Close();
            }
        }
    }
}
