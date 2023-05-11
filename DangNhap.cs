using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
           if(tentk.Trim()=="")
            {
                MessageBox.Show("Vui Long Nhap Ten Tai Khoan!");
            }else if(matkhau.Trim() == "") {
                MessageBox.Show("Vui Long Nhap Mat Khau!");
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan='"+tentk+"' and MatKhau = '"+matkhau+"'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Dang Nhap Thanh Cong!","Thông Báo");
                    this.Hide();
                    QuanLySinhVien.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ten Hoac Mat Khau Khong Chinh Xac!", "Thông Báo");
                }
            }
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
    }
}
