using JsonParse.Models.Detail1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonParse.Models.Detail
{
    public class relatedNews
    {
        public bool hasPhotoGallery { get; set; }
        public bool hasVideo { get; set; }
        public string publishDate { get; set; }
        public string shortText { get; set; }
        public categoryrelatedNews categoryrelatedNews { get; set; }
        public int itemId { get; set; }
        public string title { get; set; }
        public string imageUrl { get; set; }
        public string itemType { get; set; }
        public bool titleVisible { get; set; }
    }
}