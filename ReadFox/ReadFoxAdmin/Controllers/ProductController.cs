using Microsoft.AspNetCore.Mvc;
using ReadFoxAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ReadFoxAdmin.Controllers
{
    public class ProductController : Controller
    {


        public async Task<IActionResult> Index()
        {
            List<Books> proviceResponses = new List<Books>();
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    int count = 0;
                    cmd.CommandText = "[dbo].[GetCount]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                      count = int.Parse(reader["counts"].ToString());
                    }
                    await connection.CloseAsync();
                    ViewBag.count=count;
                    return View();
                }
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddBooks( string count,string productname, int price, string pubbisger, string author, string descrip, string categoryID)
        {
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {

                    string PK = CheckPK(int.Parse( count));
                    cmd.CommandText = "[dbo].[AddBook]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = PK;
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = productname;
                    cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = price;
                    cmd.Parameters.Add("@Pubblisher", SqlDbType.NVarChar).Value = pubbisger;
                    cmd.Parameters.Add("@Author", SqlDbType.NVarChar).Value = author;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = descrip;
                    cmd.Parameters.Add("@CategoriID", SqlDbType.NVarChar).Value = categoryID;
                    await connection.OpenAsync();

                    SqlDataReader reader = cmd.ExecuteReader();

                    return RedirectToAction("Index");
                }
            }
        }
       
        static string CheckPK(int count)
        {
            string pk_input = count.ToString();
            System.Globalization.CultureInfo _cultureTHInfo = new System.Globalization.CultureInfo("th-TH");
            string date = DateTime.Now.ToString("yyMM", _cultureTHInfo);

            string pk = "";
            count += 1;
            
                if (count.ToString().Length == 1)
                {
                    pk_input = $"00{count}";
                }
                else if (count.ToString().Length == 2)
                {
                    pk_input = $"0{count}";
                }
                else if (count.ToString().Length == 3)
                {
                    pk_input = $"{count}";
                }
                pk = $"B{date}{pk_input}";
               
            return pk;
        }
        [HttpPost]
        public async Task<IActionResult> Edits(string bookID, string productname, int price, string pubbisger, string author, string descrip, string categoryID)
        { 
            List<Books> books = new List<Books>();
            List<Books> booksnow = new List<Books>();  
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[UpdateBooks]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = bookID;
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = productname;
                    cmd.Parameters.Add("@Price", SqlDbType.NVarChar).Value = price;
                    cmd.Parameters.Add("@Pubblisher", SqlDbType.NVarChar).Value = pubbisger;
                    cmd.Parameters.Add("@Author", SqlDbType.NVarChar).Value = author;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = descrip;
                    cmd.Parameters.Add("@CategoriID", SqlDbType.NVarChar).Value = categoryID;
                    await connection.OpenAsync();
                    SqlDataReader reader = cmd.ExecuteReader();
                    await connection.CloseAsync();
                    return RedirectToAction("Index", "Home");
                }
            }

        }
        [HttpGet]
        public async Task<IActionResult> EditBooks(string bookID)
        {
           
            List<Books> books = new List<Books>();
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[GetDetails]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = bookID;

                    await connection.OpenAsync();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Books book = new Books();
                        book.bookID = reader["bookid"].ToString();
                        book.productName = reader["productname"].ToString();
                        book.CattegoryName = reader["categoryname"].ToString();
                        book.Author = reader["author"].ToString();
                        book.pubisher = reader["publisher"].ToString();
                        book.price = int.Parse(reader["price"].ToString());
                        book.description = reader["descriptions"].ToString();
                        books.Add(book);
                    }

                    await connection.CloseAsync();

                    return View(books);
                }
            }
        }

    }
}
