using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using FantasyWatch.Models;

namespace FantasyWatch.API
{
    public class PlayerContoller : ApiController
    {
        public async Task<HttpResponseMessage> ConsumeExternalAPI()
        {
            string url = "http://api.sportradar.us/nba-t3/players/82e44ba0-efd4-41de-b998-056d2865cebf/profile.xml?api_key=tm5xu8fgkd8usq6y4859gfvw";
            
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                
                return response;
            }
            //return response;

        }

        //public IEnumerable<Player> Get()
        //{
        //    return new Player();
        //}

    }
}