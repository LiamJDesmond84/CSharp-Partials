using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharp_Partials.Models;

namespace CSharp_Partials.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // OLD INDEX - Just an example of passing data to partials
    //public IActionResult Index()
    //{


    //    Product product = new Product();
    //    product.ProductName = "WHATEVA";
    //    product.Price = 6.69;

    //    // assigning ViewBag properties for the Index view
    //    ViewBag.CurrentTime = DateTime.Now;
    //    ViewBag.Message = "The Time is:";


    //    return View(product);
    //}

    public IActionResult Index()
    {
        return View();
    }

    // USING SEPARATE MODELS & PARTIALS

    //[HttpPost("create/product")]
    //public IActionResult CreateProduct(Product newProduct)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        return RedirectToAction("Success");
    //    }
    //    return View("Index");
    //}

    //[HttpPost("create/user")]
    //public IActionResult CreateUser(User newUser)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        return RedirectToAction("Success");
    //    }
    //    return View("Index");
    //}

    //[HttpGet("success")]
    //public string Success()
    //{
    //    return "You have successfully submitted!";
    //}


    // USING SINGLE VIEW MODEL(IndexViewModel)
    [HttpPost("create/product")]
    public IActionResult CreateProduct(IndexViewModel modelData)
    {
        Console.WriteLine("HERERERE");
        // To get the submitted Product from the submission, 
        // we would just need to grab "NewProduct" from the modelData object
        Product submittedProduct = modelData.NewProduct;
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpPost("create/user")]
    public IActionResult CreateUser(IndexViewModel modelData)
    {
        // To get the submitted User from the submission, 
        // we would just need to grab "NewUser" from the modelData object
        User submittedUser = modelData.NewUser;
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }

    [HttpGet("success")]
    public string Success()
    {
        return "You have successfully submitted!";
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
