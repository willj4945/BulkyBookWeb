﻿using BulkyBook.Data;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Controllers;

public class CategoryController : Controller
{
    private readonly AppDbContext _db;

    public CategoryController(AppDbContext db)
    {
        _db = db;
        
    }

    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories;
        return View(objCategoryList);
    }
    
    //GET
    public IActionResult Create()
    {

        return View();
    }
}
