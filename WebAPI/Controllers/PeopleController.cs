using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// This is where poeple list comming from
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        /// <summary>
        /// Gets a list of all users        /// 
        /// </summary>
        public PeopleController()
        {
            
            people.Add(new Person { FirstName="Ripal" , LastName ="Patel" , id = 1});
            people.Add(new Person { FirstName = "Viaan", LastName = "Patel", id = 2 });
            people.Add(new Person { FirstName = "Tejas", LastName = "Patel", id = 3 });
        }
        /// <summary>
        /// List of firstnames
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/People/GetFirstNames/{id:int}")]
        [HttpGet]
        
        public List<String> GetFirstNames(int id)
        {
            List<String> output = new List<String>();
            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }
        /// <summary>
        /// Return all users
        /// </summary>
        /// <returns></returns>
        // GET: api/People
        public List<Person> Get()
        {           

            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.id == id).FirstOrDefault() ;
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
