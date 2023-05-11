using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoan(){}
    public TaiKhoan(string tenTaiKhoan,string matKhau){
            this.TenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;  
     }

        public string Matkhau { get => matKhau; set => matKhau = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
    }
}
