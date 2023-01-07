using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolyo_AY.Data;
using Portfolyo_AY.Entities;

namespace Portfolyo_AY.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        MsSqlContext _contex = new MsSqlContext();
        MsSqlContext _contex2 = new MsSqlContext();
        MsSqlContext _contex3 = new MsSqlContext();
        MsSqlContext _contex4 = new MsSqlContext();
        public IActionResult Index()
        {
            return View();
        }

        // Skill
        public IActionResult SkilLs()
        {
            var dataList = _contex.Skills.ToList();
            return View(dataList);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _contex.Skills.Add(skill);
            _contex.SaveChanges();
            return RedirectToAction("Skills");
        }

        public IActionResult RemoveSkill(int id)
        {
            var data = _contex.Skills.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                _contex.Skills.Remove(data);
                _contex.SaveChanges();
            }
            return RedirectToAction("Skills");

        }
        public IActionResult UpdateSkill(int id)
        {
            var data = _contex.Skills.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _contex.Skills.Update(skill);
            _contex.SaveChanges();
            return RedirectToAction("Skills");
        }

        //Reference
        public IActionResult Reference()
        {
            var dataListR = _contex.References.ToList();
            return View(dataListR);
        }

        [HttpGet]
        public IActionResult AddReference()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReference(Reference reference, IFormFile Image)
        {
            try
            {
                if (Image is not null)
                {
                    var fileName = Path.GetExtension(Image.FileName);
                    var newImageName = Guid.NewGuid() + fileName;

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", newImageName);
                    using var stream = new FileStream(path, FileMode.Create);
                    Image.CopyTo(stream);
                    reference.Image = newImageName;
                }
                _contex2.References.Add(reference);
                _contex2.SaveChanges();
                return RedirectToAction("Reference");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult UpdateReference(int id)
        {
            var data = _contex2.References.Find(id);

            return View(data);
        }
        [HttpPost]
        public IActionResult UpdateReference(Reference reference, IFormFile? Image)
        {
            try
            {
                if (Image is not null)
                {
                    var fileName = Path.GetExtension(Image.FileName);
                    var newImageName = Guid.NewGuid() + fileName;

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", newImageName);
                    using var stream = new FileStream(path, FileMode.Create);
                    Image.CopyTo(stream);
                    reference.Image = newImageName;
                }
                _contex2.References.Update(reference);
                _contex2.SaveChanges();
                return RedirectToAction("Reference");
            }
            catch
            {
                return View();
            }
        }
        public IActionResult DeleteReference(int id)
        {
            var data=_contex2.References.Find(id);
            if(data !=null)
            {
                _contex2.References.Remove(data);
                _contex2.SaveChanges(); 
            }
            return RedirectToAction("References");
        }


        //About
        public IActionResult About()
        {
            var dataListA = _contex.Abouts.ToList();
            return View(dataListA);
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _contex3.Abouts.Add(about);
            _contex3.SaveChanges();
            return RedirectToAction("About");
        }
        //Fact
        public IActionResult Fact()
        {
            var dataListF = _contex4.Facts.ToList();
            return View(dataListF);
        }

        [HttpGet]
        public IActionResult AddFact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFact(Fact fact)
        {
            _contex3.Facts.Add(fact);
            _contex3.SaveChanges();
            return RedirectToAction("Fact");
        }
    }
}
