using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyphongkhamnhakhoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Xoatt()
        {
            txtTenkhachhang.Text = "";
            txtSodienthoai.Text = "";
            txtDiachi.Text = "";
            txtLoaidichvu.Text = "";
            txtDongia.Text = "";
            txtMasobenhnhan.Text = "";
                }
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtTenkhachhang.Text !=""& txtSodienthoai.Text !=""&& txtDiachi.Text !="" && txtLoaidichvu.Text !="" 
                && txtGioitinh.Text !="" && txtDongia.Text !="" && txtMasobenhnhan.Text !="" )
            {
                try
                {
                    int dongia = Convert.ToInt32(txtDongia.Text);
                    int thanhtien = dongia ;
                    txtdataGridViewPK.Rows.Add(txtTenkhachhang.Text, txtSodienthoai.Text, txtDiachi.Text, txtGioitinh.Text, txtMasobenhnhan.Text,
                        dateTimePicker1.Text, txtDongia.Text, txtMasobenhnhan.Text,thanhtien.ToString(),dateTimePicker2.Text);
                    btnXoa.Enabled = true;
                    btnTimkiem.Enabled = true;
                    btnThongke.Enabled = true;
                    btnSua.Enabled = true;
                    btnThongke.Enabled = true;
                    Xoatt();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Dữ liệu đơn giá hoặc mã số bệnh nhân sai");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnTimkiem.Enabled=false;
           btnThongke.Enabled = false;
            btnSua.Enabled = false;
            btnThongke.Enabled = false;
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = dataGridViewTTHK.CurrentCell.RowIndex;
            txtTenkhachhang.Text = dataGridViewTTHK[0, index].Value.ToString();
            txtDiachi.Text = dataGridViewTTHK[1, index].Value.ToString();
            txtDongia.Text = dataGridViewTTHK[2, index].Value.ToString();
            txtGioitinh.Text = dataGridViewTTHK[3, index].Value.ToString();
            txtLoaidichvu.Text = dataGridViewTTHK[4, index].Value.ToString();
            txtMasobenhnhan.Text = dataGridViewTTHK[5, index].Value.ToString();
            
           
        }

        private void dataGridViewTTHK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
