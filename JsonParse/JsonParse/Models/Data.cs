using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParse.Models
{
    public class Data
    {
        public string sectionType { get; set; }
        public string repeatType { get; set; }
        public int itemCountInRow { get; set; }
        public Boolean lazyLoadingEnabled { get; set; }
        public Boolean titleVisible { get; set; }
        public string title { get; set; }
        public string titleColor { get; set; }
        public string titleBgColor { get; set; }
        public string sectionBgColor { get; set; }
        public List<itemList> itemList { get; set; }




    }
}