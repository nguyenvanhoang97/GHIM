﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.IO;

namespace qlcv.Network
{
    class Networking
    {
        private static Networking instance = new Networking();
        public static Networking getInstance()
        {
            return instance;
        }
        private string token="";


        private Networking()
        {
            
        }
        public void setToken(string tk)
        {

            this.token = tk;
        }
        public string Post(string url, NameValueCollection values)
        {
            using (var client = new WebClient())
            {
                client.Headers.Set("token", token);
                //var values = new NameValueCollection();
                //values["thing1"] = "hello";
                //values["thing2"] = "world";
                var response = client.UploadValues(url, values);

                return Encoding.Default.GetString(response);
            }
        }
        public  string PostV2(string url,Object obj)
        {
            var http = (HttpWebRequest)WebRequest.Create(new Uri(url));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "POST";
            http.Headers["token"] = token;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(json);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            return sr.ReadToEnd();
           
        }
        public string Get(string url)
        {
            using (var client = new WebClient())
            {
                client.Headers.Set("token", token);
                client.Encoding = Encoding.UTF8;
                return client.DownloadString(url);
            }
        }
    }
}