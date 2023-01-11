using dotnet_ef_core.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core.Controllers;

public class AuditController : Controller
{
    // GET
    private readonly ApplicationDbContext _context;
    public AuditController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        IEnumerable<AuditEntity> audits = _context.AuditEntities.ToList();
        return View(audits);
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
        AuditEntity asset = _context.AuditEntities.Find(id);
        return View(asset);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Save([Bind("Id, IdAsset, AntiVirus, WindowsLicense, OfficeLicense, Condition, Validation")] AuditEntity request)
    {
        _context.AuditEntities.Add(request);
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        var entity = _context.AuditEntities.Find(id);
        return View(entity);
    }

    [HttpPost]
    public IActionResult Update([Bind("Id, IdAsset, AntiVirus, WindowsLicense, OfficeLicense, Condition, Validation")] AuditEntity request)
    {
        _context.AuditEntities.Update((request));
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        var entity = _context.AuditEntities.Find(id);
        if (entity == null)
        {
            return Redirect("/Audit/GetAll");
        }

        _context.AuditEntities.Remove(entity);
        _context.SaveChanges();
        return Redirect("GetAll");
    }
}