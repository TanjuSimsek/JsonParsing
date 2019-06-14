using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParse.Models.Detail
{
    public class headerAd
    {
        public string itemType { get; set; }
        public string adUnit { get; set; }
        public int itemWidth { get; set; }
        public int itemHeight { get; set; }
        public newsDetail newsDetail { get;set; }
    }
}