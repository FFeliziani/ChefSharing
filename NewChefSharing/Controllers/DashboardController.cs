using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NewChefSharing.Models;

namespace NewChefSharing.Controllers
{
    public class DashboardController : ApiController
    {
        public Video[] Get(int id)
        {
            Video video = new Video();
            video.descrizione = "Ecce Video";
            video.durata = 10000;
            video.nome = "Polentina";
            video.thumbnail = "video.png";
            video.indirizzo = "video.mp4";
            Video[] returnArray = { video };
            return returnArray;
        }
    }
}
