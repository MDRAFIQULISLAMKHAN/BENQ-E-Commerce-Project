using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayer
{
    public interface IReviewProvider
    {
        List<ReviewModel> GetAllReview();
        ReviewModel GetReviewById(long Id);
        long InsertReview(ReviewModel Review);
        bool UpdateReview(ReviewModel review);
        bool DeleteReview(long Id);
    }
}
