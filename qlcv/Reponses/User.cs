using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qlcv.Reponses
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DiaChi { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool ThemDuAn { get; set; }
        public bool status { get; set; }
        public string Token { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string gt { get; set; }
        public User()
        {

        }

        public User(string name, string diaChi, string mail, string username, string password, bool isAdmin, string soDienThoai, DateTime ngaySinh, bool gioiTinh)
        {
            Name = name;
            DiaChi = diaChi;
            Mail = mail;
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
            SoDienThoai = soDienThoai;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
        }
        public User(int iD, string name, string diaChi, string mail, string username, string password, bool isAdmin, string token, string soDienThoai, DateTime? ngaySinh, bool gioiTinh, string gt)
        {
            ID = iD;
            Name = name;
            DiaChi = diaChi;
            Mail = mail;
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
            Token = token;
            SoDienThoai = soDienThoai;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            this.gt = gt;
        }
    }
   
}
