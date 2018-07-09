using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.Specialized;
using qlcv.Reponses;
using Newtonsoft.Json.Linq;
using System;

namespace qlcv.Network
{
    class Retrofit
    {
        //private string BASE_URL = "https://dmhoang.herokuapp.com/";
        private string BASE_URL = "http://10.100.1.38:6788/";
        private User userLogin;

        public static Retrofit instance = new Retrofit();
        private Retrofit()
        {

        }
        public User getLoginUser()
        {
            return userLogin;
        }
        public User Login(string username, string password)
        {
            NameValueCollection login = new NameValueCollection();
            login["username"] = username;
            login["password"] = password;
            string json = Networking.getInstance().Post(BASE_URL + "api/user/login", login);
            if (json != null)
            {
                userLogin = JsonConvert.DeserializeObject<User>(json);
            }
                
            return userLogin;
        }
        //user
        public List<User> getAllUser()
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/user/getAll");
            return JsonConvert.DeserializeObject<List<User>>(json);
        }
        public StatusRespon addUser(User user)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/user/add", user);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        public StatusRespon updateUser(User user)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/user/edit", user);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        public StatusRespon deleteUser(User user)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/user/delete", user);
            StatusRespon s = JObject.Parse(json).ToObject<StatusRespon>();
            return JsonConvert.DeserializeObject<StatusRespon>(json);

        }
        //du an
        public List<DuAn> getAllDuAn()
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/duan/getAll");
            return JsonConvert.DeserializeObject<List<DuAn>>(json);
        }
        public StatusRespon addDuAn(DuAn duAn)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/duan/addDuan", duAn);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        public StatusRespon deleteDuAn(DuAn duAn)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/duan/deleteDuAn", duAn);
            StatusRespon s = JObject.Parse(json).ToObject<StatusRespon>();
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        //work
        public StatusRespon doneWork(string id)
        {
            string json = Networking.getInstance().Get(BASE_URL+"api/work/done/"+id);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        public List<WorkV2> getAllWork(string idDuan)
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/work/getAll/"+ idDuan);
            return JsonConvert.DeserializeObject<List<WorkV2>>(json);
        }
        public List<Work> getAllWork(int idDuan)
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/work/getAll/" + idDuan);
            return JsonConvert.DeserializeObject<List<Work>>(json);
        }
        public Work getChiTietWork(string id)
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/work/get/" + id);
            return JsonConvert.DeserializeObject<Work>(json);
        }
        public StatusRespon updateWork(Work work)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/work/edit", work);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        public StatusRespon addWork(Work works)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/work/add", works);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        public StatusRespon deleteWork(Work works)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/work/delete", works);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        //trang thai công việc
        public List<TrangThaiCongViec> getAllTrangThai()
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/trangthai/getAll");
            return JsonConvert.DeserializeObject<List<TrangThaiCongViec>>(json);
        }
        //phân hệ
        public List<PhanHe> getAllPhanHe()
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/phanhe/getAll");
            return JsonConvert.DeserializeObject<List<PhanHe>>(json);
        }
        //Báo lỗi
        public StatusRespon BaoLoi(BaoLoi baoLoi)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/work/baoloi", baoLoi);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
        //lấy ghim
        public List<Ghim> Ghim(DateTime TuNgay,DateTime DenNgay )
        {
            LocOBJ loc = new LocOBJ(TuNgay.ToString("MM-dd-yyyy HH:mm:ss"), DenNgay.ToString("MM-dd-yyyy HH:mm:ss"));
            string json = Networking.getInstance().PostV2(BASE_URL + "api/ghim/ghimhoiha", loc);
            return JsonConvert.DeserializeObject<List<Ghim>>(json);
        }
        public List<BaoCaoChiTietGhimOBJ> BaoCaoChiTietGhim(DateTime TuNgay, DateTime DenNgay,int ID)
        {
            ParameterBaoCaoChiTietGhim pa = new ParameterBaoCaoChiTietGhim(TuNgay.ToString("MM-dd-yyyy HH:mm:ss"), DenNgay.ToString("MM-dd-yyyy HH:mm:ss"), ID);
            string json = Networking.getInstance().PostV2(BASE_URL + "api/baocao/baoCaoChiTietGhim", pa);
            return JsonConvert.DeserializeObject<List<BaoCaoChiTietGhimOBJ>>(json);
        }
        public List<LoaiGhimOBJ> LoaiGhim()
        {

            string json = Networking.getInstance().PostV2(BASE_URL + "api/baocao/getAllGhim", new Object());
            return JsonConvert.DeserializeObject<List<LoaiGhimOBJ>>(json);
        }
        public List<BaoCaoTongHopGhim> BaoCaoTongHopGhim(DateTime TuNgay, DateTime DenNgay, int ID,int IDLoaiGhim)
        {
            ParameterBaoCaoTongHopGhim pa = new ParameterBaoCaoTongHopGhim(TuNgay.ToString("MM-dd-yyyy HH:mm:ss"), DenNgay.ToString("MM-dd-yyyy HH:mm:ss"), ID, IDLoaiGhim);
            string json = Networking.getInstance().PostV2(BASE_URL + "api/baocao/baoCaoTHGhim", pa);
            return JsonConvert.DeserializeObject<List<BaoCaoTongHopGhim>>(json);
        }
        public List<BieuDoTheoThangOBJ> BieuDoGhimTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            LocOBJ pa = new LocOBJ(TuNgay.ToString("MM-dd-yyyy HH:mm:ss"), DenNgay.ToString("MM-dd-yyyy HH:mm:ss"));
            string json = Networking.getInstance().PostV2(BASE_URL + "api/baocao/baocaoththeongay", pa);
            return JsonConvert.DeserializeObject<List<BieuDoTheoThangOBJ>>(json);
        }
        public StatusRespon UserDoiMatKhau(string oldpass, string newpass)
        {
            var value = new NameValueCollection();
            value["ID"] = userLogin.ID+"";
            value["PassNew"] = newpass;
            value["PassOld"] = oldpass;
            string json = Networking.getInstance().Post(BASE_URL + "api/user/updatepass", value);
            return JsonConvert.DeserializeObject<StatusRespon>(json);
        }
    }
}
