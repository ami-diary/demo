using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShoeStore.Data
{
    public class ProductRepository
    {
        static string connectionString = @"Server=AMISCOMPUTER\SQLEXPRESS;Database=Demo26-1;Integrated Security=True;";

        public List<Product> GetAll()
        {
            var list = new List<Product>();

            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                string sql = @"
                    SELECT 
                        [Номер товара] as Id,
                        [Артикул] as Article,
                        [Наименование товара] as Name,
                        [Единица измерения] as Unit,
                        [Цена] as Price,
                        [Поставщик] as Supplier,
                        [Производитель] as Manufacturer,
                        [Категория товара] as Category,
                        [Действующая скидка] as DiscountPercent,
                        [Кол-во на складе] as StockQty,
                        [Описание товара] as Description,
                        [Фото] as Photo
                    FROM [dbo].[Товары]";

                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Article = reader["Article"].ToString(),
                            Name = reader["Name"].ToString(),
                            Unit = reader["Unit"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Supplier = reader["Supplier"].ToString(),
                            Manufacturer = reader["Manufacturer"].ToString(),
                            Category = reader["Category"].ToString(),
                            DiscountPercent = Convert.ToInt32(reader["DiscountPercent"]),
                            StockQty = Convert.ToInt32(reader["StockQty"]),
                            Description = reader["Description"].ToString(),
                            Photo = reader["Photo"].ToString()
                        };
                        list.Add(product);
                    }
                }
            }
            return list;
        }
    }
}