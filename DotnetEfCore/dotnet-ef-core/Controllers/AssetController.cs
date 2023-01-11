using dotnet_ef_core.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core.Controllers;

public class AssetController : Controller
{
    private readonly ApplicationDbContext _context;
    public AssetController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        IEnumerable<AssetEntity> assets = _context.AssetEntities.ToList();
        return View(assets);
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
        AssetEntity asset = _context.AssetEntities.Find(id);
        return View(asset);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Save([Bind("Id, Name, Specification, SerialNumber, PurchaseYear")] AssetEntity request)
    {
        _context.AssetEntities.Add(request);
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        var entity = _context.AssetEntities.Find(id);
        return View(entity);
    }

    [HttpPost]
    public IActionResult Update([Bind("Id, Name, Specification, SerialNumber, PurchaseYear")] AssetEntity request)
    {
        _context.AssetEntities.Update((request));
        _context.SaveChanges();
        return Redirect("GetAll");
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        var entity = _context.AssetEntities.Find(id);
        if (entity == null)
        {
            return Redirect("/Asset/GetAll");
        }

        _context.AssetEntities.Remove(entity);
        _context.SaveChanges();
        return Redirect("GetAll");
    }


}