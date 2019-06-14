using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParse.Models.Detail
{
    public class photoGallery
    {
        public bool itemList { get; set; }
        public int itemId { get; set; }
        public string title { get; set; }
        public string imageUrl { get; set; }
        public string itemType { get; set; }
        public bool titleVisible { get; set; }
    }
}