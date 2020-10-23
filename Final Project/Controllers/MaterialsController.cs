using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class MaterialsController : Controller
    {
        private readonly IMaterialsRepository repo;

        public MaterialsController(IMaterialsRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var allMaterials = repo.GetAllMaterials();
            return View(allMaterials);
        }
        public IActionResult ViewMaterials(int id)
        {
            var material = repo.GetMaterials(id);

            return View(material);
        }
        public IActionResult Search(string searchString)
        {
            var search = repo.SearchMaterial(searchString);

            return View(search);
        }
        
    }
}
