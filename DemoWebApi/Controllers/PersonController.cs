using DemoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebApi.Controllers
{
    public class PersonController : ApiController
    {
        List<Person> people = new List<Person>();

        public PersonController()
        {
            people.Add(new Person { name = "yalda", lastname = "kheirkhah", id = 1 });
            people.Add(new Person { name = "yal", lastname = "kheirkhah", id = 2 });
            people.Add(new Person { name = "yalda", lastname = "kheir", id = 3 });
        }
        // GET: api/Person
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            return people.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/Person
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
