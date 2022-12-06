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
    public partial class Form1 : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        private static SqlConnection mycon;
        private static string sqlconn= @"Data Source=QUYNHANH\SQLEXPRESS;Initial Catalog=CAPHE;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            hienthi(dataGridView1);
        }
        public static void hienthi(DataGridView dataGridView1)
        {
            try { 
            string chuoi = "SELECT MAHANG, TenHang,DONVITINH, DonGiaBan, HANG.MALOAIHANG, TENLOAIHANG FROM HANG JOIN LOAIHANG ON HANG.MALOAIHANG=LOAIHANG.MALOAIHANG ";
            ad = new SqlDataAdapter(chuoi, sqlconn);
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Mã Hàng";
            dataGridView1.Columns[1].HeaderText = "Tên Hàng";
            dataGridView1.Columns[2].HeaderText = "Đơn Vị Tính";
            dataGridView1.Columns[3].HeaderText = "Đơn Giá Bán";
            dataGridView1.Columns[4].HeaderText = "Mã Loại Hàng";
            dataGridView1.Columns[5].HeaderText = "Tên Loại Hàng";
            } catch(Exception ex) 
            {
                MessageBox.Show("Ket noi that bai"+ex);
            }
        }

        
        private void From1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Them du lieu
     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "INSERT INTO HANG values('" + maHang.Text + "',N'" + tenHang.Text + "',N'" + donGiaBan.Text + "','" + donViTinh.Text + "','" + maLoaiHang.Text + "')";
                mycon = new SqlConnection(sqlconn);
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dataGridView1.DataSource = tb;
                MessageBox.Show("Thêm Thành công");

                hienthi(dataGridView1);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm Thất bại");
            }
            
        }

        private void lb2_Click(object sender, EventArgs e)
        {

        }

        private void lb3_Click(object sender, EventArgs e)
        {

        }

        private void lb4_Click(object sender, EventArgs e)
        {

        }

        private void lb5_Click(object sender, EventArgs e)
        {

        }

        private void maHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void donGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void maLoaiHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
       
            string sql1 = "UPDATE HANG set TenHang= N'"+ tenHang.Text + "',DonGiaBan= '" + donGiaBan.Text + "',DonViTinh='" + donViTinh.Text + "',MaLoaiHang='" + maLoaiHang.Text + "' where mahang='"+maHang.Text+"'" ;
            mycon = new SqlConnection(sqlconn);
            mycon.Open();
            com = new SqlCommand(sql1, mycon);
            com.ExecuteNonQuery();
            MessageBox.Show("Sửa Thành công");
            hienthi(dataGridView1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1 = "Delete Hang where mahang='" + maHang.Text + "'";
            mycon = new SqlConnection(sqlconn);
            mycon.Open();
            com = new SqlCommand(sql1, mycon);
            com.ExecuteNonQuery();
            MessageBox.Show("Xóa Thành công");
            hienthi(dataGridView1);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int curow = dataGridView1.CurrentRow.Index;
            maHang.Text = dataGridView1.Rows[curow].Cells[0].Value.ToString();
            tenHang.Text = dataGridView1.Rows[curow].Cells[1].Value.ToString();
            donViTinh.Text = dataGridView1.Rows[curow].Cells[2].Value.ToString();
            donGiaBan.Text = dataGridView1.Rows[curow].Cells[3].Value.ToString();
            maLoaiHang.Text = dataGridView1.Rows[curow].Cells[4].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
