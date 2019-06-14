using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParse.Models
{
    public class HomePage
    {
       public int errorCode { get; set; }
       public string errorMessage { get; set; }
       public List<Data> data { get; set; }
        


    }
}