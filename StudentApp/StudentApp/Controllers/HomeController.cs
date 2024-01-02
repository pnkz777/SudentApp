using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentApp.Data;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var user = _context.users.Select(x => x).ToList();
             
                //DataSet ds = new DataSet();
                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = "Data Source=LAPTOP-N11DF4JK;Initial Catalog=StaffVault_3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                //{
                //    //Sql connection from the database
                //    using (SqlCommand cmd = new SqlCommand("userDetails", conn))
                //    {
                //        conn.Open();
                //        cmd.CommandType = CommandType.StoredProcedure;
                //       // cmd.Parameters.AddWithValue("@UserName", UserName);
                //        SqlDataAdapter da = new SqlDataAdapter(cmd);
                //        da.Fill(ds);
                //        conn.Close();

                //    }
                //}

                //if (ds.Tables[0].Rows.Count >= 1)
                //{
                //   foreach(DataRow item in ds.Tables[0].Rows)
                //   {
                //        var id = item["Id"];
                //   }
                //}
            }
            catch (Exception ex)
            {
                
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class studentDB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
