using Dtos;
using System.Collections.Generic;
using System.Linq;


namespace DtoRepos
{
    public interface IReviewDtoRepo
    {
        IEnumerable<ReviewDto> Get();
        void Create(ReviewDto ReviewDto);
        void Update(ReviewDto ReviewDto);
    }

    public class ReviewDtoRepo : IReviewDtoRepo
    {
        private EmployeeReviews _ctx;

        public ReviewDtoRepo(EmployeeReviews ctx){
            _ctx = ctx;
        }

        public IEnumerable<ReviewDto> Get()
        {
            return _ctx.Reviews.Select(x => new ReviewDto() { Id = x.Id, Comments = x.Comments, Rating= x.Rating });
        }

        public void Create(ReviewDto ReviewDto)
            {

                var Review = new Review()
                {
                    Id = ReviewDto.Id,
                    Comments = ReviewDto.Comments,
                    Rating = ReviewDto.Rating
                };

                _ctx.Reviews.Add(Review);
                _ctx.SaveChanges();
            }
       

        public void Update(ReviewDto ReviewDto)
        {
           var Review = _ctx.Reviews.FirstOrDefault(x => x.Id == ReviewDto.Id);
                        
            Review.Comments = ReviewDto.Comments;
            Review.Rating = ReviewDto.Rating;
                   
            _ctx.SaveChanges();
        }
    }
}

