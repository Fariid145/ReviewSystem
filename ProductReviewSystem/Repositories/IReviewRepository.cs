using ProductReviewSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewSystem.Repositories
{
    public interface IReviewRepository
    {
        public Review AddReview(Review review);

        public Review FindById(int id);

        public List<Review> FindByProductId(int productId);

        public Review UpdateReview(Review review);

        public List<Review> GetReviewsPerProduct(int productId);

        public void Delete(int id);

        public List<Review> GetReviews();
        
    }
}
