using Microsoft.AspNetCore.Mvc;
using Task3.DataAccess;
using Task3.Models;
using Task3.ViewModels;

namespace Task3.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ServiceViewModel svm = new ServiceViewModel { 
                SerFeatures = Data.SerFeatures
            };
            return View(svm);
        }

        public IActionResult Deatil(int id)
        {
            SerFeature serFeature = Data.SerFeatures.Find(x => x.Id == id);

            return View(serFeature);
        }
        
    }
}
