﻿using JsonParse.Models.Detail;
using JsonParse.Models.Detail1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParse.Models
{
    public class DataDetail
    {
        public headerAd headerAd { get; set; }
        public newsDetail newsDetail { get; set; }
        public footerAd footerAd { get; set; }
        public List<itemListDetail> itemList { get; set; }
        public multimedia multimedia { get; set; }
        public relatedNews relatedNews { get; set; }
        public video video { get; set; }
    

        public photoGallery photoGallery { get; set; }







    }
}