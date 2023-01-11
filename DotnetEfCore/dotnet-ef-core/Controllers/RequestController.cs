using dotnet_ef_core.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core.Controllers;

public class RequestController : Controller
{
    // GET
    private readonly ApplicationDbContext _context;
    public RequestController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        IEnumerable<RequestEntity> requests = _context.RequestEntities.ToList();
        return View(requests);
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
        RequestEntity request = _context.RequestEntities.Find(id);
        return View(request);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Save([Bind("Id, IdAsset, PicId, SpecificationReq, Necessary")] RequestEntity request)
    {
        _context.RequestEntities.Add(request);
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        var entity = _context.RequestEntities.Find(id);
        return View(entity);
    }

    [HttpPost]
    public IActionResult Update([Bind("Id, IdAsset, PicId, SpecificationReq, Necessary")] RequestEntity request)
    {
        _context.RequestEntities.Update((request));
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        var entity = _context.RequestEntities.Find(id);
        if (entity == null)
        {
            return Redirect("/Request/GetAll");
        }

        _context.RequestEntities.Remove(entity);
        _context.SaveChanges();
        return Redirect("GetAll");
    }
}