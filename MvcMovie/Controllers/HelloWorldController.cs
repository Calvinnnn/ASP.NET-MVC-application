using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }   
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    public IActionResult FavouriteMovie(string favourite_movie)
    {
        ViewData["user_favourite_movie"] = favourite_movie;
        return View();
    }
    
    public IActionResult DisplayMovie(string movie_title)
    {
        ViewData["movie_title"] = movie_title;
        return View();
    }

}