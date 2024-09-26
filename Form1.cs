using System.Data.SqlClient;
using System.Security.Principal;

namespace BaiTapNhom
{
    public partial class Form1 : Form
    {
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            try
            {
                connect.Open();

            }
            catch
            {
                MessageBox.Show("Lỗi Hệ Thống!! Xin Vui Lòng Thử Lại.", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDky_Click(object sender, EventArgs e)
        {
            Đăng_Ký menu = new Đăng_Ký();
            menu.ShowDialog(this);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string temp = "SELECT Pass FROM dbo.Admin WHERE Account = @Account";
            SqlCommand com = new SqlCommand(temp, connect);
            com.Parameters.AddWithValue("@Account", tbAcc.Text);

            SqlDataReader reader1 = com.ExecuteReader();


            if (tbAcc.Text == "Admin1" && tbPass.Text == "Admin1")
            {
                QuanTri fadmin = new QuanTri();
                fadmin.ShowDialog();
                this.Close();
            }
            else
            {
                if(tbAcc.Text == "Admin1" && tbPass.Text != "Admin1")
                {
                    MessageBox.Show("Mật khẩu không chính xác, vui lòng nhập lại");
                    tbPass.Text = "";
                }
                else
                {
                        string sql2 = "SELECT ExtraInfor FROM dbo.Admin WHERE Account = @Account";

                        SqlCommand command = new SqlCommand(sql2, connect);
                        command.Parameters.AddWithValue("@Account", tbAcc.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {

                            string extraInfo = reader["ExtraInfor"].ToString();
                            string extraInfo1 = reader["ExtraInfor"].ToString();
                            reader.Close();
                            string sqlQuery = "SELECT pass FROM dbo.Admin WHERE Account = @Account";
                            SqlCommand cmd = new SqlCommand(sqlQuery, connect);
                            cmd.Parameters.AddWithValue("@Account", tbAcc.Text);
                            object result = cmd.ExecuteScalar();
                            string passwordFromDatabase = result.ToString();
                            string enteredPassword = tbPass.Text;

                            if (extraInfo == "Account" && passwordFromDatabase == enteredPassword)
                            {
                                QuanTri fadmin = new QuanTri();
                                this.Hide();
                                fadmin.ShowDialog();
                            }
                            else
                            {
                                if (extraInfo == "Account" && passwordFromDatabase != enteredPassword)
                                {
                                    MessageBox.Show("Dữ liệu nhập không chính xác, vui lòng nhập lại!");
                                    tbPass.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Tài khoản không tồn tại!");
                                    tbAcc.Text = "";
                                    tbPass.Text = "";
                                }

                            }

                        }
                    

                }
            }
            
           
            
        }
    }
}