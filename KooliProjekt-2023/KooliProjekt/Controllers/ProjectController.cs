using KooliProjekt.Data;
using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly IFileClient _fileClient;

        public ProjectController(ApplicationDbContext dataContext, IFileClient fileClient)
        {
            _dataContext = dataContext;
            _fileClient = fileClient;
        }

        // GET: ProjectController
        public ActionResult Index(int page = 1, int pageSize = 10)
        {

            var projects = _dataContext.Project.GetPagedAsync(page, pageSize);
            ViewBag.Files = _fileClient.List(FileStoreNames.Images);

            return View(projects);
        }

        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, IFormFile[] files)
        {
            try
            {
                foreach (var file in files)
                {
                    _fileClient.Save(file.OpenReadStream(), file.FileName, FileStoreNames.Images);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
