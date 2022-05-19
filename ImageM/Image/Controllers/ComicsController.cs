using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Image.Data;
using Image.Models;

namespace Image.Controllers
{
    public class ComicsController : Controller
    {
        private readonly ImageContext _context;

        public ComicsController(ImageContext context)
        {
            _context = context;
        }

        // GET: Comics
        public async Task<IActionResult> Index(string ComicGenre, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from b in _context.Comics
                                            orderby b.TheLoai
                                            select b.TheLoai;
            var Comics = from b in _context.Comics
                        select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                Comics = Comics.Where(s => s.TenTruyen!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(ComicGenre))
            {
                Comics = Comics.Where(x => x.TheLoai == ComicGenre);
            }
            var ComicGenreVM = new ComicGenreViewModel
            {
                Genres = new SelectList(await
            genreQuery.Distinct().ToListAsync()),
                Comics = await Comics.ToListAsync()
            };
            return View(ComicGenreVM);
        }


        public async Task<IActionResult> User(string ComicGenre, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from b in _context.Comics
                                            orderby b.TheLoai
                                            select b.TheLoai;
            var Comics = from b in _context.Comics
                         select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                Comics = Comics.Where(s => s.TenTruyen!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(ComicGenre))
            {
                Comics = Comics.Where(x => x.TheLoai == ComicGenre);
            }
            var ComicGenreVM = new ComicGenreViewModel
            {
                Genres = new SelectList(await
            genreQuery.Distinct().ToListAsync()),
                Comics = await Comics.ToListAsync()
            };
            return View(ComicGenreVM);
        }
        public async Task<IActionResult> TrangChu1(string ComicGenre, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from b in _context.Comics
                                            orderby b.TheLoai
                                            select b.TheLoai;
            var Comics = from b in _context.Comics
                         select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                Comics = Comics.Where(s => s.TenTruyen!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(ComicGenre))
            {
                Comics = Comics.Where(x => x.TheLoai == ComicGenre);
            }
            var ComicGenreVM = new ComicGenreViewModel
            {
                Genres = new SelectList(await
            genreQuery.Distinct().ToListAsync()),
                Comics = await Comics.ToListAsync()
            };
            return View(ComicGenreVM);
        }

        // GET: Comics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comics = await _context.Comics
                .FirstOrDefaultAsync(m => m.ID == id);
            if (comics == null)
            {
                return NotFound();
            }

            return View(comics);
        }

        public async Task<IActionResult> UserDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comics = await _context.Comics
                .FirstOrDefaultAsync(m => m.ID == id);
            if (comics == null)
            {
                return NotFound();
            }

            return View(comics);
        }
        public async Task<IActionResult> ThongTin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comics = await _context.Comics
                .FirstOrDefaultAsync(m => m.ID == id);
            if (comics == null)
            {
                return NotFound();
            }

            return View(comics);
        }
        // GET: Comics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TenTruyen,NgayPhatHanh,TheLoai,Gia, Rating")] Comics comics)
        {
            



            if (ModelState.IsValid)
            {
                _context.Add(comics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comics);
        }

        // GET: Comics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comics = await _context.Comics.FindAsync(id);
            if (comics == null)
            {
                return NotFound();
            }
            return View(comics);
        }

        // POST: Comics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TenTruyen,NgayPhatHanh,TheLoai,Gia, Rating")] Comics comics)
        {
            if (id != comics.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComicsExists(comics.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(comics);
        }

        // GET: Comics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comics = await _context.Comics
                .FirstOrDefaultAsync(m => m.ID == id);
            if (comics == null)
            {
                return NotFound();
            }

            return View(comics);
        }

        // POST: Comics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comics = await _context.Comics.FindAsync(id);
            _context.Comics.Remove(comics);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComicsExists(int id)
        {
            return _context.Comics.Any(e => e.ID == id);
        }
    }
}
