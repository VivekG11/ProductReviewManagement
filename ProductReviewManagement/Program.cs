﻿using System;
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
            //ReviewManagement.AddProductReview(products);
            // ReviewManagement.RetrieveTopThreeRecords(products);
            // ReviewManagement.Retrieve(products);
            // ReviewManagement.RetrieveCount(products);
            // ReviewManagement.RetrieveIdAndReview(products);
            //ReviewManagement.SkipTopFiveRecords(products);
            // ProductTable.AddDetails(products);
            // ProductTable.RetrieveBasedOnIsLike(products);
            // ProductTable.FindAvgRating(products);
            //ProductTable.FindReview(products);
            ProductTable.DisplayBasedOnUserId(products);
           
           
        }
    }
}
