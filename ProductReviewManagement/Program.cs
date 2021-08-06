using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management......");
            List<ProductReview> products = new List<ProductReview>();
            ReviewManagement.AddProductReview(products);
            ReviewManagement.RetrieveTopThreeRecords(products);

        }
    }
}
