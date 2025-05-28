using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;

namespace souq.Models
{
    public class ViewModelReview
    {
        // القائمة اللي هتعرض كل الريفيوز
        [ValidateNever] 
        public List<Review> Reviews { get; set; }

        // كائن الريفيو الجديد اللي هيتملأ في الفورم
        public Review NewReview { get; set; }
    }
}
