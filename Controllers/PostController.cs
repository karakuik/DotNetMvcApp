using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Data;

namespace MyMvcApp.Controllers;

public class PostController : Controller
{
    // Might not need
    // private readonly MvcCelebrityContext _context;
    //
    // public PostController(MvcCelebrityContext context)
    // {
    //     _context = context;
    // }

    public string Index()
    {
        return "This will lead to a post... Once I get a clear view ;)";
    }
    
}