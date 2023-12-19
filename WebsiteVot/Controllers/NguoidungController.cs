using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteVot.Data;
using WebsiteVot.Models;

namespace WebsiteVot.Controllers
{
    public class NguoidungController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NguoidungController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nguoidung
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nguoidung.ToListAsync());
        }

        // GET: Nguoidung/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoidung = await _context.Nguoidung
                .FirstOrDefaultAsync(m => m.MaNd == id);
            if (nguoidung == null)
            {
                return NotFound();
            }

            return View(nguoidung);
        }

        // GET: Nguoidung/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nguoidung/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaNd,Ten,DienThoai,Email,DiaChi,MatKhau,PhanQuyen")] Nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguoidung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguoidung);
        }

        // GET: Nguoidung/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoidung = await _context.Nguoidung.FindAsync(id);
            if (nguoidung == null)
            {
                return NotFound();
            }
            return View(nguoidung);
        }

        // POST: Nguoidung/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaNd,Ten,DienThoai,Email,DiaChi,MatKhau,PhanQuyen")] Nguoidung nguoidung)
        {
            if (id != nguoidung.MaNd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguoidung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoidungExists(nguoidung.MaNd))
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
            return View(nguoidung);
        }

        // GET: Nguoidung/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoidung = await _context.Nguoidung
                .FirstOrDefaultAsync(m => m.MaNd == id);
            if (nguoidung == null)
            {
                return NotFound();
            }

            return View(nguoidung);
        }

        // POST: Nguoidung/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nguoidung = await _context.Nguoidung.FindAsync(id);
            _context.Nguoidung.Remove(nguoidung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoidungExists(int id)
        {
            return _context.Nguoidung.Any(e => e.MaNd == id);
        }
    }
}
