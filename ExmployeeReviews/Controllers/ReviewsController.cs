using DtoRepos;
using Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExmployeeReviews.Controllers
{
    
    public class ReviewsController : ApiController
    {
        private IReviewDtoRepo _ReviewDtoRepo;

        public ReviewsController() {
            _ReviewDtoRepo = new ReviewDtoRepo(new EmployeeReviews());            
        }

        // GET api/values

          
        public IEnumerable<ReviewDto> Get()
        {
            return _ReviewDtoRepo.Get();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(ReviewDto ReviewDto)
        {
            _ReviewDtoRepo.Create(ReviewDto);
        }

        // PUT api/values/5
        public void Put(ReviewDto ReviewDto)
        {
            _ReviewDtoRepo.Update(ReviewDto);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
