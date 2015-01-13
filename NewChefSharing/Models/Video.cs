using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewChefSharing.Models
{
    public class Video
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string thumbnail { get; set; }
        public string descrizione { get; set; }
        public int durata { get; set; }
        public string indirizzo { get; set; }
    }
}