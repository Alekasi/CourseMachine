using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerView.Controllers
{
    [RoutePrefix("api/hub")]
    public class courseHubController : Controller
    {
        public class status
        {
            public int type { get; set; }
            public DateTime time { get; set; }
        }

        public class image
        {
            public int type { get; set; }

            public string path { get; set; }

            public string name { get; set; }
        }

        public class price
        {
            public int amount { get; set; }

            public string currency { get; set; }
            /*
             * EUR, USD etc...
            */
        }

        public class duration
        {
            public int amount { get; set; }

            public int unit { get; set; }
            /*
             * Day, Week, Month, Hour etc...
             */
        }

        public class hub
        {
            public Guid courseId { get; set; }

            public string name { get; set; }

            public Guid creator { get; set; }

            public Guid company { get; set; }

            public DateTime created { get; set; }
            
            public status status { get; set; }

            public image img { get; set; }

            public string information { get; set; }

            public price price { get; set; }

            public duration duration { get; set; } 
        }

        [HttpGet]
        [Route("fetchHub")]
        public List<hub> courseFetch(int amount)
        {
            List<hub> list = new List<hub>();

            for(int i = 0; i < amount; i++)
            {
                hub hubber = new hub
                {
                    courseId = Guid.NewGuid(),
                    name = "Course's name " + i,
                    creator = Guid.NewGuid(),
                    company = Guid.NewGuid(),
                    created = DateTime.Now.Date.ToString() + '.' + DateTime.Now.Month.ToString() + '.' + DateTime.Now.Year.ToString(),
                    img = new image
                    {
                        type = 0,
                        path = "",
                        name = "imageName"
                    },
                    information = "",
                    price = new price
                    {
                        amount = 120,
                        currency = "EUR"
                    },
                    duration = new duration
                    {
                        amount = 12,
                        unit = 0
                    }
                };
                list.Add(hubber);
            }
            return list;
        }
        /*
        [HttpGet]
        [Route("")]
        public IEnumerable<hub> course(int amount, string search)
        {
            amount = amount == 0 ? 50 : amount;
            var ctx = new hub();

            if(search.Length <= 0)
            {
                return ctx.hub.Where(r => r.statusType == 0 || r.statusTime < DateTime.Now).Take(amount);
            }
            else
            {  
                return ctx.hub.Where(r => r.name.Contains(search)).Take(amount);
            }
        }*/
    }
} 