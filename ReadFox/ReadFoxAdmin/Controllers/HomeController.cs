using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReadFoxAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ReadFoxAdmin.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        //public async Task< IActionResult> Index()
        //{
        //    var detail = await GetBooks();
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Books> books = new List<Books>();
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[GetBooks]";
                    cmd.CommandType = CommandType.StoredProcedure;
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
                        books.Add(book);
                    }
                    await connection.CloseAsync();
                    return View(books);
                }
            }
        }
        [HttpGet("search")]
        public async Task<IActionResult> SearchBooks(string productname)
        {
            List<Books> books = new List<Books>();
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[SearchBooks]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = productname;

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
                        books.Add(book);
                    }

                    await connection.CloseAsync();

                    return View("Index", books);
                }
            }
        }
        [HttpGet("Delete")]
        public async Task<IActionResult> DeleteBooks(string bookID)
        {
            List<Books> books = new List<Books>();
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[DeletesBooks]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookID", SqlDbType.VarChar).Value = bookID;

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
                        book.description = reader["description"].ToString();
                        books.Add(book);
                    }
                    await connection.CloseAsync();

                    return RedirectToAction("Index", "Home");
                }
            }
        }

      [HttpGet]
        public async Task<IActionResult> Detail(string bookID)
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

   

        public IActionResult Black()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
