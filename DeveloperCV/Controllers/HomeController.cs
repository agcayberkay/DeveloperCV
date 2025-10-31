using DeveloperCV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DeveloperCV.Controllers;

public class HomeController : Controller
{
    private readonly ProfileModel _model;

    public HomeController(IOptions<ProfileModel> options)
    {
        _model = options.Value;
    }

    public IActionResult Index()
    {
        return View(_model);
    }
}
