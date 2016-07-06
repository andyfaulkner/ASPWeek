using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTypedViewsExample.Models
{
    public class Album
    {
        public string title;
        public string artist;
        public string format;
        public decimal price;

        public void AddAlbum(string title, string artist, string format, decimal price)
        {
            this.title = title;
            this.artist = artist;
            this.format = format;
            this.price = price;
        }
    }
}