using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParse.Models
{
    public class PageDetail
    {
        public int errorCode { get; set; }
        public string errorMessage { get; set; }
        public DataDetail DataDetail { get; set; }
    }
}