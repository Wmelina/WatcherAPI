using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WatcherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public List<Event> Get()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();

                var a = db.Events.ToList();
                
                return  a;
            }
            
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Event value)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Event ev = new Event { description = value.description, latitude = value.latitude, longitude = value.longitude, name = value.name, type = value.type };
                db.Events.Add(ev);
                db.SaveChanges();
            }

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
