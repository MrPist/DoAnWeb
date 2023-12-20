using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteVot.Data;
using WebsiteVot.Models;

namespace WebsiteVot.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        void GetInfo()
        {

        }
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            GetInfo();
            var applicationDbContext = _context.Mathang.Include(m => m.MaDmNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathang = await _context.Mathang
                .Include(m => m.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaMh == id);
            if (mathang == null)
            {
                return NotFound();
            }

            return View(mathang);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten");
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMh,Ten,GiaGoc,GiaBan,SoLuong,MoTa,HinhAnh,MaDm,LuotXem,LuotMua")] Mathang mathang, FormFile file)
        {
            if (ModelState.IsValid)
            {
                mathang.HinhAnh = Upload(file);
                _context.Add(mathang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", mathang.MaDm);
            return View(mathang);
        }
        public string Upload(IFormFile file) 
        {
            string uploadfileName = null;
            if(file != null)
            {
                uploadfileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = $"wwwroot\\images\\{uploadfileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            return uploadfileName;
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathang = await _context.Mathang.FindAsync(id);
            if (mathang == null)
            {
                return NotFound();
            }
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", mathang.MaDm);
            return View(mathang);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaMh,Ten,GiaGoc,GiaBan,SoLuong,MoTa,HinhAnh,MaDm,LuotXem,LuotMua")] Mathang mathang)
        {
            if (id != mathang.MaMh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mathang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MathangExists(mathang.MaMh))
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
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", mathang.MaDm);
            return View(mathang);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mathang = await _context.Mathang
                .Include(m => m.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaMh == id);
            if (mathang == null)
            {
                return NotFound();
            }

            return View(mathang);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mathang = await _context.Mathang.FindAsync(id);
            _context.Mathang.Remove(mathang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MathangExists(int id)
        {
            return _context.Mathang.Any(e => e.MaMh == id);
        }
        public IActionResult Login()
        {
            GetInfo();
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string matkhau)
        {
            var kh = _context.Nguoidung.FirstOrDefault(k => k.Email == email);

            return RedirectToAction(nameof(Login));
        }
        public IActionResult Customer()
        {
            GetInfo();
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("nguoidung", "");
            GetInfo();
            return RedirectToAction(nameof(Index));
        }

        //GET
        public IActionResult Register()
        {
            GetInfo();
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string matkhau, string hoten, string dienthoai)
        {
            var kh = new Nguoidung();
            kh.Email = email;
            kh.MatKhau = matkhau; //can ma hoa
            kh.Ten = hoten;
            kh.DienThoai = dienthoai;

            _context.Add(kh);
            _context.SaveChanges();
            // yeu cau Login
            return RedirectToAction(nameof(Login));





        }
    }
}
