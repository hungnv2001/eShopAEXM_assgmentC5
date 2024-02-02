﻿//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using System.Security.Claims;

//namespace Assignment.Controllers
//{
//    public class CartsController : Controller
//    {
      

//        public CartsController()
//        {
            
//        }

//        // GET: Carts
//        public async Task<IActionResult> Index()
//        {
//            if (!HttpContext.User.Identity.IsAuthenticated)
//            {
//                return View("Not_log");
//            }
//            var y = _context.CartItems.ToList();
//            var myContext = _context.CartItems.Include(p => p.ProductVariant).ThenInclude(p => p.Size).Include(p => p.ProductVariant).ThenInclude(p => p.Color).Include(p => p.ProductVariant).ThenInclude(p => p.Product).Include(p => p.Cart);
//            var x = User.FindFirst(ClaimTypes.NameIdentifier).Value;
//            var result = new List<CartItem>();
//            if (x != null)
//            {

//                result = myContext.Where(p => p.Cart.CustomerID.ToString() == x.ToString()).ToList();
//            }

//            if (result == null)
//            {
//                return View("Emty");
//            }
//            return View(result);

//        }

//        // GET: Carts/Details/5
//        public async Task<IActionResult> Details(Guid? id)
//        {
//            if (id == null || _context.Carts == null)
//            {
//                return NotFound();
//            }

//            var cart = await _context.Carts
//                .Include(c => c.User)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (cart == null)
//            {
//                return NotFound();
//            }

//            return View(cart);
//        }

//        // GET: Carts/Create
//        public IActionResult Create()
//        {
//            ViewData["CustomerID"] = new SelectList(_context.Users, "Id", "Address");
//            return View();
//        }

//        // POST: Carts/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Quantity,CustomerID")] Cart cart)
//        {
//            if (!ModelState.IsValid)
//            {
//                _context.Add(cart);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["CustomerID"] = new SelectList(_context.Users, "Id", "Address", cart.CustomerID);
//            return View(cart);
//        }

//        // GET: Carts/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.Carts == null)
//            {
//                return NotFound();
//            }

//            var cart = await _context.Carts.FindAsync(id);
//            if (cart == null)
//            {
//                return NotFound();
//            }
//            ViewData["CustomerID"] = new SelectList(_context.Users, "Id", "Address", cart.CustomerID);
//            return View(cart);
//        }

//        // POST: Carts/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Quantity,CustomerID")] Cart cart)
//        {
//            if (id != cart.Id)
//            {
//                return NotFound();
//            }

//            if (!ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(cart);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!CartExists(cart.Id))
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
//            ViewData["CustomerID"] = new SelectList(_context.Users, "Id", "Address", cart.CustomerID);
//            return View(cart);
//        }

//        // GET: Carts/Delete/5
//        public async Task<IActionResult> Delete(Guid? id)
//        {
//            if (id == null || _context.Carts == null)
//            {
//                return NotFound();
//            }

//            var cart = await _context.Carts
//                .Include(c => c.User)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (cart == null)
//            {
//                return NotFound();
//            }

//            return View(cart);
//        }

//        // POST: Carts/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(Guid id)
//        {
//            if (_context.Carts == null)
//            {
//                return Problem("Entity set 'MyContext.Carts'  is null.");
//            }
//            var cart = await _context.Carts.FindAsync(id);
//            if (cart != null)
//            {
//                _context.Carts.Remove(cart);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool CartExists(Guid id)
//        {
//            return (_context.Carts?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
