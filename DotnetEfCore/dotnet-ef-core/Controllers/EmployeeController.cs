using dotnet_ef_core.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core.Controllers;

public class EmployeeController : Controller
{
    // GET
    private readonly ApplicationDbContext _context;
    public EmployeeController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        IEnumerable<EmployeeEntity> employees = _context.EmployeeEntities.ToList();
        return View(employees);
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
        EmployeeEntity asset = _context.EmployeeEntities.Find(id);
        return View(asset);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Save([Bind("Id, Name, Position, Email, Number,Address")] EmployeeEntity request)
    {
        _context.EmployeeEntities.Add(request);
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        var entity = _context.EmployeeEntities.Find(id);
        return View(entity);
    }

    [HttpPost]
    public IActionResult Update([Bind("Id, Name, Position, Email, Number,Address")] EmployeeEntity request)
    {
        _context.EmployeeEntities.Update((request));
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        var entity = _context.EmployeeEntities.Find(id);
        if (entity == null)
        {
            return Redirect("/Employee/GetAll");
        }

        _context.EmployeeEntities.Remove(entity);
        _context.SaveChanges();
        return Redirect("GetAll");
    }
}