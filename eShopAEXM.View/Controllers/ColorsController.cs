﻿//using Microsoft.AspNetCore.Mvc;

//namespace Assignment.Controllers
//{
//    public class ColorsController : Controller
//    {
      

//        public ColorsController()
//        {
            
//        }

//        // GET: Colors
//        public async Task<IActionResult> Index()
//        {
//            return _context.Colors != null ?
//                        View(await _context.Colors.ToListAsync()) :
//                        Problem("Entity set 'MyContext.Colors'  is null.");
//        }

//        // GET: Colors/Details/5
//        public async Task<IActionResult> Details(Guid? id)
//        {
//            if (id == null || _context.Colors == null)
//            {
//                return NotFound();
//            }

//            var color = await _context.Colors
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (color == null)
//            {
//                return NotFound();
//            }

//            return View(color);
//        }

//        // GET: Colors/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Colors/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Name")] Color color)
//        {
//            if (!ModelState.IsValid)
//            {
//                _context.Add(color);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(color);
//        }

//        // GET: Colors/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.Colors == null)
//            {
//                return NotFound();
//            }

//            var color = await _context.Colors.FindAsync(id);
//            if (color == null)
//            {
//                return NotFound();
//            }
//            return View(color);
//        }

//        // POST: Colors/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] Color color)
//        {
//            if (id != color.Id)
//            {
//                return NotFound();
//            }

//            if (!ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(color);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ColorExists(color.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(color);
//        }

//        // GET: Colors/Delete/5
//        public async Task<IActionResult> Delete(Guid? id)
//        {
//            if (id == null || _context.Colors == null)
//            {
//                return NotFound();
//            }

//            var color = await _context.Colors
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (color == null)
//            {
//                return NotFound();
//            }

//            return View(color);
//        }

//        // POST: Colors/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(Guid id)
//        {
//            if (_context.Colors == null)
//            {
//                return Problem("Entity set 'MyContext.Colors'  is null.");
//            }
//            var color = await _context.Colors.FindAsync(id);
//            if (color != null)
//            {
//                _context.Colors.Remove(color);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ColorExists(Guid id)
//        {
//            return (_context.Colors?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
