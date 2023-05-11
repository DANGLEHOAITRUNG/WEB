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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label_KetQua.Text = "";
        }
        Modify modify = new Modify();
        private void btnlaylaimatkhau_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            if(email.Trim()=="")
            {
                MessageBox.Show("Vui Lòng Nhập Email Đã Được Đăng Ký");
            }
            else
            {
                string query = "select * from TaiKhoan Where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    label_KetQua.ForeColor = Color.Blue;
                    label_KetQua.Text = "Mật Khẩu:" + modify.TaiKhoans(query)[0].Matkhau;
                }
                else
                {
                    label_KetQua.ForeColor = Color.Red;
                    label_KetQua.Text = "Email Này Chưa Được Đăng Kí";
                }
            }
        }
    }
}
