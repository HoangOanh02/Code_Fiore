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

namespace CaPhe
{
    
    public partial class Form3 : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        private static SqlConnection mycon;
        private static string sqlconn = @"Data Source=QUYNHANH\SQLEXPRESS;Initial Catalog=CAPHE;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();

            hienthi(dataGridView1);
        }
        public static void hienthi(DataGridView dataGridView1)
        {

            string chuoi = "SELECT * FROM NguyenLieu ";
            ad = new SqlDataAdapter(chuoi, sqlconn);
            dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Mã Nguyên Liệu";
            dataGridView1.Columns[1].HeaderText = "Tên Nguyên Liệu";
            dataGridView1.Columns[2].HeaderText = "Đơn Giá";
            dataGridView1.Columns[3].HeaderText = "Đơn Vị Tính";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "INSERT INTO NGUYENLIEU values('" + maNL.Text + "',N'" + tenNL.Text + "','" + donGiaBan.Text + "',N'" + donViTinh.Text + "')";
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
            maNL.Text = dataGridView1.Rows[curow].Cells[0].Value.ToString();
            tenNL.Text = dataGridView1.Rows[curow].Cells[1].Value.ToString();
            donGiaBan.Text = dataGridView1.Rows[curow].Cells[2].Value.ToString();
            donViTinh.Text = dataGridView1.Rows[curow].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            string sql1 = "UPDATE NguyenLieu set TenNguyenLieu= N'" + tenNL.Text + "',DonGiaTinh= N'" + donGiaBan.Text + "',DonViTinh='" + donViTinh.Text + "' where maNL='" + maNL.Text + "'";
            mycon = new SqlConnection(sqlconn);
            mycon.Open();
            com = new SqlCommand(sql1, mycon);
            com.ExecuteNonQuery();
            MessageBox.Show("Sửa Thành công");
            hienthi(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            string sql1 = "DELETE NGUYENLIEU where maNL='" + maNL.Text + "'";
            mycon = new SqlConnection(sqlconn);
            mycon.Open();
            com = new SqlCommand(sql1, mycon);
            com.ExecuteNonQuery();
            MessageBox.Show("Xóa Thành công");
            hienthi(dataGridView1);
        }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Thất bại");
            }
}

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
