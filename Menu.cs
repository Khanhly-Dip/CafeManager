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
    public partial class Menu : Form
    {
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;
        public Menu()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            string sql2 = "SELECT IDMon, TenMon, Gia, PhanLoai FROM dbo.ThucDon";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = new SqlCommand(sql2, connect);
            adt.SelectCommand.ExecuteNonQuery();

            DataGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGV2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGV2.ScrollBars = ScrollBars.None;
            DataTable tb = new DataTable();
            adt.Fill(tb);
            DataGV2.DataSource = tb;
        }

        private void btnExit_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
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

        private void Add_Menu_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO dbo.ThucDon(IDMon, TenMon, Gia,PhanLoai) VALUES ('" + ID_Mon.Text + "','"
                   + name_Mon.Text + "','" + Gia.Text + "','" + Kind_Mon.Text + "')";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            adapter1.InsertCommand = new SqlCommand(sql1, connect);
            adapter1.InsertCommand.ExecuteNonQuery();
            HienThi();
        }

        private void Del_Menu_Click(object sender, EventArgs e)
        {
            string Del = DataGV2.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đồ uống có mã: "
                + Del, "Thông Báo", MessageBoxButtons.YesNo);


            if (DataGV2.SelectedRows.Count > 0)
            {
                if (result == DialogResult.Yes)
                {
                    string sql4 = "DELETE FROM dbo.ThucDon WHERE IDMon = '" + Del + "'";
                    SqlDataAdapter adapter3 = new SqlDataAdapter();
                    adapter3.DeleteCommand = new SqlCommand(sql4, connect);
                    adapter3.DeleteCommand.ExecuteNonQuery();

                    HienThi();
                }

            }
        }

        private void Update_Menu_Click(object sender, EventArgs e)
        {
            string sql3 = "UPDATE dbo.ThucDon SET  TenMon = '" + name_Mon.Text + "', Gia = '" + Gia.Text + "',PhanLoai = '" + Kind_Mon.Text + "'where IDMon = '" + ID_Mon.Text + "'";

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            adapter2.InsertCommand = new SqlCommand(sql3, connect);
            adapter2.InsertCommand.ExecuteNonQuery();
            HienThi();
        }

        private void edit_Menu_Click(object sender, EventArgs e)
        {
            if (DataGV2.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = DataGV2.SelectedRows[0];

                // Lấy giá trị của các ô cụ thể trong hàng đã chọn
                ID_Mon.Text = selectedRow.Cells[0].Value.ToString(); // Cột đầu tiên
                name_Mon.Text = selectedRow.Cells[1].Value.ToString(); // Cột thứ hai
                Gia.Text = selectedRow.Cells[2].Value.ToString(); // Cột thứ ba
                Kind_Mon.Text = selectedRow.Cells[3].Value.ToString(); // Cột thứ năm

            }
        }
    }
}
