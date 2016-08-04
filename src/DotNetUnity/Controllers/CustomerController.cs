using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetUnity.Models;

namespace DotNetUnity.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {

        public static List<Customer> customer_list;

        public CustomerController()
        {
            customer_list = new List<Customer>();

            customer_list.Add(new Customer
            {
                guid = new Guid("e79c5df9-6d4a-43fb-be0e-d42ef5bc116f"),
                name = "Mark's Mega Mart",
                state = "Schaumburg",
                address = "123 Main Street",
                city = "IL",
                zip = "60085"
            });

            customer_list.Add(new Customer
            {
                guid = new Guid("c8a9eeca-195a-4593-8ed1-12d32203df85"),
                name = "Adam's Awsome Antiques",
                state = "IL",
                address = "88 South Northpoint Bvld",
                city = "Gurnee",
                zip = "605987"
            });

            customer_list.Add(new Customer
            {
                guid = new Guid("6024a0ef-260b-44db-9208-176448aff1cb"),
                name = "Eric's Electronics Emporium",
                state = "NV",
                address = "900 West Winward",
                city = "Las Vegas",
                zip = "70325"
            });

            customer_list.Add(new Customer
            {
                guid = new Guid("7987334f-0b54-4a54-b4b8-c230ca10aaa6"),
                name = "Mary's Magic Shop",
                state = "NY",
                address = "2255 Fairy Lane",
                city = "New York",
                zip = "13254"
            });


        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customer_list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<Customer> Get(Guid id)
        {
            return customer_list.Where(a => a.guid == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
