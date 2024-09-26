using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class DatBan : Form
    {
        string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Bai Kiem Tra\BaiTapNhom\Data_cafe.mdf"";Integrated Security=True;";
        SqlConnection connect;

        public static string SoBan { get; set; }

        public DatBan()
        {
            InitializeComponent();
        }

        void HienThi()
        {
            string sql2 = "SELECT IDHD, MaNV, Ngay, SLMon, ThanhTien, SoBan FROM dbo.HoaDon";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = new SqlCommand(sql2, connect);
            adt.SelectCommand.ExecuteNonQuery();

            DTGV3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DTGV3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGV3.ScrollBars = ScrollBars.None;
            DataTable tb = new DataTable();
            adt.Fill(tb);
            DTGV3.DataSource = tb;
        }

        private void DatBan_Load(object sender, EventArgs e)
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

            foreach (Control panelControl in FLO1.Controls)
            {
                if (panelControl is Panel)
                {
                    Panel panel = (Panel)panelControl;

                    foreach (Control control in panel.Controls)
                    {
                        if (control is RichTextBox)
                            {
                            RichTextBox richTextBox = (RichTextBox)control;
                           

                            string ma = richTextBox.Text;
                            string sql2 = "SELECT TinhTrang FROM dbo.Ban WHERE SoBan = @SoBan";

                            using (SqlCommand cmd = new SqlCommand(sql2, connect))
                            {
                                cmd.Parameters.AddWithValue("@SoBan", ma);

                                string tinhTrang = (string)cmd.ExecuteScalar();


                                if (!string.IsNullOrEmpty(tinhTrang) && tinhTrang.Trim() == "Dat")
                                {
                                    richTextBox.BackColor = Color.SkyBlue;
                                    

                                }
                            }
                        }
                    }
                }
            }
            
        

        }

        private void dat1_Click(object sender, EventArgs e)
        {
            if(RickT01.BackColor != Color.DarkGray) {
                Gọi_Món toan = new Gọi_Món();

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {

                    SoBan = RickT01.Text;
                    string tt = "Da Thanh Toan";
                    string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT01.Text + "'";
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    adapter2.InsertCommand = new SqlCommand(sql1, connect);
                    adapter2.InsertCommand.ExecuteNonQuery();


                    string tt1 = "Trong";
                    string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT01.Text + "'";
                    SqlDataAdapter adapter3 = new SqlDataAdapter();
                    adapter2.InsertCommand = new SqlCommand(sql2, connect);
                    adapter2.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
    


                }
            }
            else
            {
                
                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }

        }

        private void dat2_Click(object sender, EventArgs e)
        {
            if (RickT02.BackColor != Color.DarkGray)
            {
                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    Gọi_Món toan = new Gọi_Món();
                    toan.soBan = RickT02.Text;
                    string tt = "Da Thanh Toan";
                    string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT02.Text + "'";
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    adapter2.InsertCommand = new SqlCommand(sql1, connect);
                    adapter2.InsertCommand.ExecuteNonQuery();


                    string tt1 = "Trong";
                    string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT02.Text + "'";
                    SqlDataAdapter adapter3 = new SqlDataAdapter();
                    adapter2.InsertCommand = new SqlCommand(sql2, connect);
                    adapter2.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
                   
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void dat3_Click(object sender, EventArgs e)
        {
            if (RickT03.BackColor != Color.DarkGray)
            {

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    if (dia == DialogResult.OK)
                    {
                        Gọi_Món toan = new Gọi_Món();
                        toan.soBan = RickT03.Text;
                        string tt = "Da Thanh Toan";
                        string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT03.Text + "'";
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql1, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();


                        string tt1 = "Trong";
                        string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT03.Text + "'";
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql2, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
            
                    }
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void dat4_Click(object sender, EventArgs e)
        {
            if (RickT04.BackColor != Color.DarkGray)
            {

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    if (dia == DialogResult.OK)
                    {
                        Gọi_Món toan = new Gọi_Món();
                        toan.soBan = RickT04.Text;
                        string tt = "Da Thanh Toan";
                        string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT04.Text + "'";
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql1, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();


                        string tt1 = "Trong";
                        string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT04.Text + "'";
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql2, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
                        HienThi();
                    }
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void dat5_Click(object sender, EventArgs e)
        {
            if (RickT05.BackColor != Color.DarkGray)
            {

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    if (dia == DialogResult.OK)
                    {

                        Gọi_Món toan = new Gọi_Món();
                        toan.soBan = RickT05.Text;
                        string tt = "Da Thanh Toan";
                        string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT05.Text + "'";
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql1, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();


                        string tt1 = "Trong";
                        string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT05.Text + "'";
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql2, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
                   
                    }
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void dat6_Click(object sender, EventArgs e)
        {
            if (RickT06.BackColor != Color.DarkGray)
            {

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    if (dia == DialogResult.OK)
                    {
                        ThanhToan toan = new ThanhToan();
                        toan.soBan = RickT06.Text;
                        string tt = "Da Thanh Toan";
                        string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT06.Text + "'";
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql1, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();


                        string tt1 = "Trong";
                        string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT06.Text + "'";
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        adapter3.InsertCommand = new SqlCommand(sql2, connect);
                        adapter3.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
                        HienThi();
                    }
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void dat7_Click(object sender, EventArgs e)
        {
            if (RickT07.BackColor != Color.DarkGray)
            {

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    if (dia == DialogResult.OK)
                    {
                        ThanhToan toan = new ThanhToan();
                        toan.soBan = RickT07.Text;
                        string tt = "Da Thanh Toan";
                        string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT07.Text + "'";
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql1, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();


                        string tt1 = "Trong";
                        string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT07.Text + "'";
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql2, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
                        HienThi();
                    }
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void dat8_Click(object sender, EventArgs e)
        {
            if (RickT08.BackColor != Color.DarkGray)
            {

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    if (dia == DialogResult.OK)
                    {
                        ThanhToan toan = new ThanhToan();
                        toan.soBan = RickT08.Text;
                        string tt = "Da Thanh Toan";
                        string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT08.Text + "'";
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql1, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();


                        string tt1 = "Trong";
                        string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT08.Text + "'";
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql2, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
                        HienThi();
                    }
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void dat9_Click(object sender, EventArgs e)
        {
            if (RickT09.BackColor != Color.DarkGray)
            {

                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán?");
                if (dia == DialogResult.OK)
                {
                    if (dia == DialogResult.OK)
                    {
                        ThanhToan toan = new ThanhToan();
                        toan.soBan = RickT09.Text;
                        string tt = "Da Thanh Toan";
                        string sql1 = "UPDATE  dbo.Hoadon SET  TinhTrang = '" + tt + "' WHERE SoBan = '" + RickT09.Text + "'";
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql1, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();


                        string tt1 = "Trong";
                        string sql2 = "UPDATE  dbo.Ban SET  TinhTrang = '" + tt1 + "' WHERE SoBan = '" + RickT09.Text + "'";
                        SqlDataAdapter adapter3 = new SqlDataAdapter();
                        adapter2.InsertCommand = new SqlCommand(sql2, connect);
                        adapter2.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("Thanh toán thành công, cảm ơn quý khách");
                        HienThi();
                    }
                }
            }
            else
            {

                Gọi_Món xn = new Gọi_Món();
                xn.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
