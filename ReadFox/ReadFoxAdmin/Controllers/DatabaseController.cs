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
    public class DatabaseController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-H4COTNG\\SQLEXPRESS;Database=ReadFox-web;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "[dbo].[GetBooks]";
                    cmd.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Books> proviceResponses = new List<Books>();
                    while (reader.Read())
                    {
                        Books proviceResponse = new Books();
                        //proviceResponse.Id = int.Parse(reader["id"].ToString());
                        //proviceResponse.Name = reader["productname"].ToString();
                        proviceResponses.Add(proviceResponse);
                    }
                    await connection.CloseAsync();
                    return Ok(proviceResponses);
                }
            }
        }
    }
}
