﻿using DtoRepos;
using Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExmployeeReviews.Controllers
{
    
    public class ValuesController : ApiController
    {
        private IEmployeeDtoRepo _employeeDtoRepo;

        public ValuesController() {
            _employeeDtoRepo = new EmployeeDtoRepo(new EmployeeReviewsContext());            
        }

        // GET api/values

          
        public IEnumerable<EmployeeDto> Get()
        {
            return _employeeDtoRepo.Get();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
