using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    class ReviewManagement
    {
        public static void AddProductReview(List<ProductReview> products)
        {
            Console.WriteLine("Displaying Data.....");
            products.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 2, UserId = 2, Rating =10, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 3, UserId = 3, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 4, UserId = 4, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 5, UserId = 5, Rating = 7, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 6, UserId = 6, Rating = 7, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 7, UserId = 7, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 8, UserId = 8, Rating = 5, Review = "Bad", isLike = true });
            products.Add(new ProductReview() { ProductId = 9, UserId = 9, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 9, UserId = 9, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 10, UserId = 10, Rating = 7, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 11, UserId = 11, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 12, UserId = 12, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 13, UserId = 13, Rating = 7, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 14, UserId = 14, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 15, UserId = 15, Rating = 10, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 16, UserId = 16, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 17, UserId = 17, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 18, UserId = 18, Rating = 5, Review = "Bad", isLike = true });
            products.Add(new ProductReview() { ProductId = 19, UserId = 19, Rating = 6, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 20, UserId = 20, Rating = 6, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 21, UserId = 21, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 22, UserId = 22, Rating = 9, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 23, UserId = 23, Rating = 8, Review = "Good", isLike = true });
            products.Add(new ProductReview() { ProductId = 24, UserId = 24, Rating = 7, Review = "Average", isLike = true });
            products.Add(new ProductReview() { ProductId = 25, UserId = 25, Rating = 10, Review = "Good", isLike = true });

           // IterateMethod(products);

        }
        public static void IterateMethod(List<ProductReview> products)
        {
            foreach (var i in products)
            {
                Console.WriteLine("Product Id :" + i.ProductId + ", User Id :" + i.UserId + ", Rating :" + i.Rating + ", REview :" + i.Review);
            }
        }

        public static void RetrieveTopThreeRecords(List<ProductReview> products)
        {
            Console.WriteLine("Top three records are ...");

            var res = (from product in products orderby product.Rating descending select product).Take(3).ToList();
            IterateMethod(res);
        }
        public static void Retrieve(List<ProductReview> products)
        {
            Console.WriteLine("Records greater than 7 rating among 1,11,13 are......");
            //retrieving records greater than 7
            var result = (from product in products where product.Rating > 7 && (product.ProductId == 1 || product.ProductId == 11 || product.ProductId == 13) select product ).ToList();
            IterateMethod(result);
        }

        public static void RetrieveCount(List<ProductReview> products)
        {
           
            //retrieving count grouping by Rating
            var res = products.GroupBy(p => p.ProductId).Select(x => new { ID = x.Key, count = x.Count() });
            foreach(var i in res)
            {
                Console.WriteLine("ProductId :"+i.ID +"  count :"+i.count);
             
            }
           
        }

        public static void RetrieveIdAndReview(List<ProductReview> products)
        {
            var res = products.Select(s => new { Id = s.ProductId, review = s.Review });

           foreach(var i in res)
            {
                Console.WriteLine("Product ID :"+i.Id+" Review :"+i.review);
            }
        }

        public static void SkipTopFiveRecords(List<ProductReview> products)
        {
            Console.WriteLine("Products After skipping Top 5 records are ....");
            //Arranging products in order and retrieving records by skpping top 5 records
            var res = (from product in products orderby product.ProductId ascending select product).Skip(5).ToList();
            IterateMethod(res);
        }
    }
}
