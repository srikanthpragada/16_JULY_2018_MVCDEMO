using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Create()
        {
            var model = new Product();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            // process 
            if (!ModelState.IsValid)
                return View(model);
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(Database.LocalDbConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into products(prodname,price,qoh,catcode,remarks) values(@prodname,@price,@qoh,@catcode,@remarks)", con);
                    cmd.Parameters.AddWithValue("@prodname", model.Name);
                    cmd.Parameters.AddWithValue("@price", model.Price);
                    cmd.Parameters.AddWithValue("@qoh", model.Qoh);
                    cmd.Parameters.AddWithValue("@catcode", model.Category);
                    if (model.Remarks == null)
                        model.Remarks = "";
                    HttpContext.Trace.Write("Value of Remarks = " + model.Remarks.Length);
                    cmd.Parameters.AddWithValue("@remarks", model.Remarks);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error : " + ex.Message;
                    HttpContext.Trace.Write("Error = " + ex.Message );
                    return View(model);
                }
            }
        }

        [HttpGet]
        public ActionResult Discount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Discount(double amount, double rate)
        {
            double discount = amount * rate / 100;
            ViewBag.Discount = discount;
            ViewBag.Amount = amount;
            ViewBag.Rate = rate;
            return View();
        }

        [HttpGet]
        public ActionResult Discount2()
        {
            var model = new DiscountModel();
            model.Rate = 10;
            return View(model);
        }

        [HttpPost]
        public ActionResult Discount2(DiscountModel model)
        {
            model.Discount = model.Amount * model.Rate / 100;
            return View(model);
        }

        public ActionResult Delete(String id)
        {
            // Delete product by given id
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            // Connect to MS Sql Server 
            SqlConnection con = new SqlConnection(Database.LocalDbConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from products", con);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Product> products = new List<Product>();

            while (dr.Read())
            {
                products.Add(new Product
                {
                    Id = dr["prodid"].ToString(),
                    Name = dr["prodname"].ToString(),
                    Remarks = dr["remarks"].ToString(),
                    Category = dr["catcode"].ToString(),
                    Price = Double.Parse(dr["price"].ToString()),
                    Qoh = Int32.Parse(dr["qoh"].ToString())
                });

            }
            con.Close();

            return View(products);
        }
    }
}