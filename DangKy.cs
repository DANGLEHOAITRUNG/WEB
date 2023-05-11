using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string checkac)
        {
            return Regex.IsMatch(checkac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string checkemail)
        {
            return Regex.IsMatch(checkemail, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_NLMK.Text;
            string email = textBox_Email.Text;
            if (!checkAccount(tentk))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Tài Khoản Dài 6-24 kí tự , kí tự chữ - số,kí tự chữ hoa -thường");return; 
            }
            if (!checkAccount(matkhau))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Mật Khẩu Dài 6-24 kí tự , kí tự chữ - số,kí tự chữ hoa -thường"); return;
            }
            if(xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui Lòng Xác Nhận Mật Khẩu Chính Xác"); return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui Lòng Nhập Đúng Email"); return;
            }
            if (modify.TaiKhoans("Select * from TaiKhoan Where Email ='" + email + "'").Count != 0)
            {
                MessageBox.Show(" Email này đã được sử dụng"); return;
            }
            try
            {   
                string query = "Insert into TaiKhoan values('"+tentk+"','"+matkhau+"','"+email+"'");
                modify.Command(query);
                if(MessageBox.Show("Đăng Ký Thành Công! Bạn Có Muốn Đăng Nhập Luôn Không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes))
                {
                    this.Close();
                }
             }
            catch
            {
                MessageBox.Show("Tên Tài Khoản Này Đã Được Đăng Ký. Vui Lòng Đăng Ký Tên tài Khoản Khác!");
            }
        }
    }
}
