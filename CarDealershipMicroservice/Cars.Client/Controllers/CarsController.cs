using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cars.Client.Models;
using Cars.Client.ApiServices;

namespace Cars.Client.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarApiService _carApiService;

        public CarsController(ICarApiService carApiService)
        {
            _carApiService = carApiService ?? throw new ArgumentNullException(nameof(carApiService));
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            return View(await _carApiService.GetCars());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var car = await _context.Car
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (car == null)
            //{
            //    return NotFound();
            //}

            //return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Model,Brand,DateAcquired,PreviousOwners")] Car car)
        {
            return View();
            //if (ModelState.IsValid)
            //{
            //    _context.Add(car);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var car = await _context.Car.FindAsync(id);
            //if (car == null)
            //{
            //    return NotFound();
            //}
            //return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Model,Brand,DateAcquired,PreviousOwners")] Car car)
        {
            return View();
            //if (id != car.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(car);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!CarExists(car.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var car = await _context.Car
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (car == null)
            //{
            //    return NotFound();
            //}

            //return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();
            //var car = await _context.Car.FindAsync(id);
            //_context.Car.Remove(car);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return true;
            //return _context.Car.Any(e => e.Id == id);
        }
    }
}
