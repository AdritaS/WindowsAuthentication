using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsAuthenticationAPI.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}