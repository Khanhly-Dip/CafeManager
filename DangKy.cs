using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class Đăng_Ký : Form
    {
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;
        public Đăng_Ký()
        {
            InitializeComponent();
        }

        private void exit_dky_Click(object sender, EventArgs e)
        {
            Form1 comback = new Form1();
            comback.ShowDialog();
        }

        private void accept_dky_Click(object sender, EventArgs e)
        {
            string temp = "SELECT MaNV FROM dbo.NhanVien WHERE MaNV = @Account";
            SqlCommand com = new SqlCommand(temp, connect);
            com.Parameters.AddWithValue("@Account", idnv_dky.Text);

            SqlDataReader reader1 = com.ExecuteReader();
            string pas1 = pass_dky.Text.Trim();
            string pas2 = passgain_dky.Text.Trim();
            bool equals = pas1.Equals(pas2);
            if (reader1.Read()){

                reader1.Close();

                 if (equals){
                    string extr = "Account";
                    string sql = "INSERT INTO dbo.Admin(Account, Pass, ExtraInfor) VALUES ('" + tbAcc_dky.Text + "','"
                    + pass_dky.Text + "','"+ extr + "')";

                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    adapter1.InsertCommand = new SqlCommand(sql, connect);
                    adapter1.InsertCommand.ExecuteNonQuery();
                    DialogResult re = MessageBox.Show("Đăng Ký thành công, Trở về trang đăng nhập", "Thông báo", MessageBoxButtons.OKCancel);
                    if (re == DialogResult.OK)
                    {
                        Form1 comback1 = new Form1();
                        comback1.ShowDialog();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Mat khau khong khop!Vui long nhap lai!");
                    pass_dky.Text = "";
                    passgain_dky.Text = "";
                   
                }
            }
            else
            {
                MessageBox.Show("Ma Nhan Vien Khong Khop Vui Long Nhap Lai");
                idnv_dky.Text = "";
            }
        }


        private void Đăng_Ký_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            connect.Open();
        }
    }
}
