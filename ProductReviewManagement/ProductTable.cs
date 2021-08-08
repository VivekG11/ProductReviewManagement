using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;


namespace ProductReviewManagement
{
     class ProductTable
    {
        public static DataTable AddDetails(List<ProductReview> products)
        {
            //Creating data table initializing columns
            DataTable table = new DataTable();
            table.Columns.Add("ProductID",typeof(int));
            table.Columns.Add("UserId",typeof(int));
            table.Columns.Add("Rating",typeof(int));
            table.Columns.Add("Review",typeof(string));
            table.Columns.Add("isLike",typeof(bool));
            //Adding elements to table from Products list
            foreach(var i in products)
            {
                var row = table.NewRow();
                row["ProductId"] = i.ProductId;
                row["UserId"] = i.UserId;
                row["Rating"] = i.Rating;
                row["Review"] = i.Review;
                row["isLike"] = i.isLike;
                table.Rows.Add(row);
            }
            
            
            DisplayTable(table);
            return table;

        }

        public static void DisplayTable(DataTable table)
        {
           //displaying elements from table
           foreach(DataRow row in table.Rows)
            {

                foreach(var i in row.ItemArray)
                {
                    Console.WriteLine(i);
                    
                }
                Console.WriteLine("...........");
            }
        }

        public static int RetrieveBasedOnIsLike(List<ProductReview> products)
        {
            int count = 0;
            DataTable table = AddDetails(products);
          
           var res= from t in table.AsEnumerable() where t.Field<bool>("isLike") == true select t;
            foreach (var i in res)
            {
                Console.WriteLine($"{i["isLike"]}");
                count++;
            }
            return count;
        }

        public static void FindAvgRating(List<ProductReview> products)
        {
            DataTable table = AddDetails(products);
            double avg = (double)table.AsEnumerable().Average(x => x.Field<int>("Rating"));
            Console.WriteLine("The average of ratings of all products is..."+avg);
            
        }
        public static void FindReview(List<ProductReview> products)
        {
            DataTable table = AddDetails(products);
            Console.WriteLine("Products with Good Review are ...");
            var res = from product in table.AsEnumerable() where product.Field<string>("Review") == "Good" select product;
            foreach (var i in res)
            {
                
                Console.WriteLine($"{i["ProductId"]},{i["Review"]}");
               
            }
        }
        public static void DisplayBasedOnUserId(List<ProductReview> products)
        {
            DataTable table = AddDetails(products);
            var res = from record in table.AsEnumerable() where record.Field<int>("UserId") == 10 orderby record.Field<int>("review") select record;
            Console.WriteLine("Products with userId 10 are ...");
            foreach (var i in res)
            {
                Console.WriteLine(".");
                Console.WriteLine($"{i["ProductId"]}");

            }
        }
        
    }
}
