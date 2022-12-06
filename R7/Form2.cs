using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CaPhe
{
    public partial class Form2 : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        private static SqlConnection mycon;
        private static string sqlconn = @"Data Source=QUYNHANH\SQLEXPRESS;Initial Catalog=CAPHE;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
            hienthi(dataGridView1);
        }
        public static void hienthi(DataGridView dataGridView1)
        {
            
                string chuoi = "SELECT * FROM NHANVIEN ";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
                dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
                dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
                dataGridView1.Columns[3].HeaderText = "Địa Chỉ";
                dataGridView1.Columns[4].HeaderText = "Số Điện Thoại";
          
        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            
            frm1.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "INSERT INTO NHANVIEN values('" + maNV.Text + "',N'" + tenNV.Text + "',N'" + ngaySinh.Text + "',N'" + diaChi.Text + "','" + soDienThoai.Text + "')";
                mycon = new SqlConnection(sqlconn);
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dataGridView1.DataSource = tb;
                MessageBox.Show("Thêm Thành công");

                hienthi(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
                int curow = dataGridView1.CurrentRow.Index;
                maNV.Text = dataGridView1.Rows[curow].Cells[0].Value.ToString();
                tenNV.Text = dataGridView1.Rows[curow].Cells[1].Value.ToString();
                ngaySinh.Text = dataGridView1.Rows[curow].Cells[2].Value.ToString();
                diaChi.Text = dataGridView1.Rows[curow].Cells[3].Value.ToString();
                soDienThoai.Text = dataGridView1.Rows[curow].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1 = "UPDATE NhanVien set TenNV= N'" + tenNV.Text + "',ngaySinh= '" + ngaySinh.Text + "N',diaChi='" + diaChi.Text + "',SoDienThoai='" + soDienThoai.Text + "' where MaNV='" + maNV.Text + "'";
            mycon = new SqlConnection(sqlconn);
            mycon.Open();
            com = new SqlCommand(sql1, mycon);
            com.ExecuteNonQuery();
            MessageBox.Show("Sửa Thành công");
            hienthi(dataGridView1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1 = "DELETE NHANVIEN where MaNV='" + maNV.Text + "'";
            mycon = new SqlConnection(sqlconn);
            mycon.Open();
            com = new SqlCommand(sql1, mycon);
            com.ExecuteNonQuery();
            MessageBox.Show("Xóa Thành công");
            hienthi(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
