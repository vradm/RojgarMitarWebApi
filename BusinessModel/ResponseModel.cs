using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RojgarMitraWebApi.BusinessModel
{
    public class ResponseModel
    {
        public long? id { get; set; }
        public string message { get; set; }
        public object data { get; set; }
        public bool status { get; set; } = false;
        public string redirectUrl { get; set; }
    }
}