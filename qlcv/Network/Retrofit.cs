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
        private string BASE_URL = "http://10.82.1.72:6788/";
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
            userLogin = JsonConvert.DeserializeObject<User>(json);
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
        public List<Work> getAllWork(string id)
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/work/getAll/"+id);
            return JsonConvert.DeserializeObject<List<Work>>(json);
        }
        public List<Work> getAllWork(int id)
        {
            string json = Networking.getInstance().Get(BASE_URL + "api/work/getAll/" + id);
            return JsonConvert.DeserializeObject<List<Work>>(json);
        }
        public StatusRespon addWork(Work works)
        {
            string json = Networking.getInstance().PostV2(BASE_URL + "api/work/addWork", works);
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
    }
}
