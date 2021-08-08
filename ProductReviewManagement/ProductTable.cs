using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;


namespace ProductReviewManagement
{
     class ProductTable
    {
        public static void AddDetails(List<ProductReview> products)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserId");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

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

        }

        public static void DisplayTable(DataTable table)
        {
           /* var productId = from products in table.AsEnumerable() select products.Field<int>("ProductId");
            foreach(var i in productId)
            {
                Console.WriteLine(i);
            }*/
           foreach(DataRow row in table.Rows)
            {

                foreach(var i in row.ItemArray)
                {
                    Console.WriteLine(i);
                    
                }
                Console.WriteLine("...........");
            }
        }
        
    }
}
