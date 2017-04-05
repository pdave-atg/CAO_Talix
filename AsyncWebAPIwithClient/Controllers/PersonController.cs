using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AsyncWebAPIwithClient.Models;
using AsyncWebAPIwithClient.Repository;
using System.Web.Http.Description;

namespace AsyncWebAPIwithClient
{
    public class PersonController : ApiController
    {
        private IPersonRepository<PersonInfo, int> _repository;

        public PersonController(IPersonRepository<PersonInfo, int> r)
        {
            _repository = r;
        }

        // GET api/<controller>
        
        public IEnumerable<PersonInfo> Get()
        {
            return _repository.Get();
        }

        // GET api/<controller>/5
        [ResponseType(typeof(PersonInfo))]
        public IHttpActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }

        // POST api/<controller>
        [ResponseType(typeof(PersonInfo))]
        public IHttpActionResult Post([FromBody]PersonInfo value)
        {
            _repository.Add(value);
            return Ok(value);
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, [FromBody]PersonInfo value)
        {
            _repository.Update(id, value);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/<controller>/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            _repository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}