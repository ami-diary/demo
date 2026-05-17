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

        public void Add(Product product)
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                string sql = @"
                    INSERT INTO [dbo].[Товары] 
                    ([Артикул], [Наименование товара], [Единица измерения], [Цена], 
                     [Поставщик], [Производитель], [Категория товара], [Действующая скидка], 
                     [Кол-во на складе], [Описание товара])
                    VALUES 
                    (@Article, @Name, @Unit, @Price, @Supplier, @Manufacturer, 
                     @Category, @DiscountPercent, @StockQty, @Description)";

                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Article", product.Article);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Unit", product.Unit);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                    cmd.Parameters.AddWithValue("@Manufacturer", product.Manufacturer);
                    cmd.Parameters.AddWithValue("@Category", product.Category);
                    cmd.Parameters.AddWithValue("@DiscountPercent", product.DiscountPercent);
                    cmd.Parameters.AddWithValue("@StockQty", product.StockQty);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Product product)
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                string sql = @"
                    UPDATE [dbo].[Товары] SET
                        [Артикул] = @Article,
                        [Наименование товара] = @Name,
                        [Единица измерения] = @Unit,
                        [Цена] = @Price,
                        [Поставщик] = @Supplier,
                        [Производитель] = @Manufacturer,
                        [Категория товара] = @Category,
                        [Действующая скидка] = @DiscountPercent,
                        [Кол-во на складе] = @StockQty,
                        [Описание товара] = @Description
                    WHERE [Номер товара] = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Id", product.Id);
                    cmd.Parameters.AddWithValue("@Article", product.Article);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Unit", product.Unit);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                    cmd.Parameters.AddWithValue("@Manufacturer", product.Manufacturer);
                    cmd.Parameters.AddWithValue("@Category", product.Category);
                    cmd.Parameters.AddWithValue("@DiscountPercent", product.DiscountPercent);
                    cmd.Parameters.AddWithValue("@StockQty", product.StockQty);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int productId)
        {
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();

                // Проверяем, есть ли товар в заказах
                string checkSql = "SELECT COUNT(*) FROM [dbo].[Позиции] WHERE [Номер товара] = @Id";
                using (SqlCommand checkCmd = new SqlCommand(checkSql, myConnection))
                {
                    checkCmd.Parameters.AddWithValue("@Id", productId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                        throw new InvalidOperationException("Товар присутствует в заказах и не может быть удалён.");
                }

                // Удаляем товар
                string deleteSql = "DELETE FROM [dbo].[Товары] WHERE [Номер товара] = @Id";
                using (SqlCommand deleteCmd = new SqlCommand(deleteSql, myConnection))
                {
                    deleteCmd.Parameters.AddWithValue("@Id", productId);
                    deleteCmd.ExecuteNonQuery();
                }
            }
        }
    }
}