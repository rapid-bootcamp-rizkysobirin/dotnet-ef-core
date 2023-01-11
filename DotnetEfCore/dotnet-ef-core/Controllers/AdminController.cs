using dotnet_ef_core.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core.Controllers;

public class AdminController : Controller
{
    // GET
    /*public IActionResult Index()
    {
        return View();
    }*/
    
    private readonly ApplicationDbContext _context;
    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        IEnumerable<AdminEntity> admins = _context.AdminEntities.ToList();
        return View(admins);
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
        AdminEntity admin = _context.AdminEntities.Find(id);
        return View(admin);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Save([Bind("Id, Name, Role, Email, IdAudit")] AdminEntity request)
    {
        _context.AdminEntities.Add(request);
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        var entity = _context.AdminEntities.Find(id);
        return View(entity);
    }

    [HttpPost]
    public IActionResult Update([Bind("Id, Name, Role, Email, IdAudit")] AdminEntity request)
    {
        _context.AdminEntities.Update((request));
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        var entity = _context.AdminEntities.Find(id);
        if (entity == null)
        {
            return Redirect("/Admin/GetAll");
        }

        _context.AdminEntities.Remove(entity);
        _context.SaveChanges();
        return Redirect("GetAll");
    }
}