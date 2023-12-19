using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Session;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteVot.Data;
using WebsiteVot.Models;

namespace WebsiteVot.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        void GetInfo()
        {
            ViewBag.danhmuc = _context.Danhmuc.ToList();

            //ViewData["solg"] = GetCartItems().Count();
        }
        // GET: Customer
        public async Task<IActionResult> Index()
        {
            GetInfo();
            var applicationDbContext = _context.Mathang.Include(m => m.MaDmNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            GetInfo();
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

        //// GET: Customer/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten");
        //    return View();
        //}

        //// POST: Customer/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("MaMh,Ten,GiaGoc,GiaBan,SoLuong,MoTa,HinhAnh,MaDm,LuotXem,LuotMua")] Mathang mathang)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(mathang);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", mathang.MaDm);
        //    return View(mathang);
        //}

        //// GET: Customer/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var mathang = await _context.Mathang.FindAsync(id);
        //    if (mathang == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", mathang.MaDm);
        //    return View(mathang);
        //}

        //// POST: Customer/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("MaMh,Ten,GiaGoc,GiaBan,SoLuong,MoTa,HinhAnh,MaDm,LuotXem,LuotMua")] Mathang mathang)
        //{
        //    if (id != mathang.MaMh)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(mathang);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!MathangExists(mathang.MaMh))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", mathang.MaDm);
        //    return View(mathang);
        //}

        //// GET: Customer/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var mathang = await _context.Mathang
        //        .Include(m => m.MaDmNavigation)
        //        .FirstOrDefaultAsync(m => m.MaMh == id);
        //    if (mathang == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(mathang);
        //}

        //// POST: Customer/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var mathang = await _context.Mathang.FindAsync(id);
        //    _context.Mathang.Remove(mathang);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        // Lưu danh sách CartItem trong giỏ hàng vào session
        void SaveCartSession(List<CartItem> list)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(list);
            session.SetString("Votshopcart", jsoncart);
        }

        // Xóa session giỏ hàng
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove("Votshopcart");
        }
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("Votshopcart");
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }
        // Cho hàng vào giỏ
        public async Task<IActionResult> AddToCart(int id)
        {
            var mathang = await _context.Mathang.FirstOrDefaultAsync(m => m.MaMh == id);
            if (mathang == null)
            {
                return NotFound("Sản phẩm không tồn tại");
            }
            var cart = GetCartItems();
            var item = cart.Find(p => p.MatHang.MaMh == id);
            if (item != null)
            {
                item.SoLuong++;
            }
            else
            {
                cart.Add(new CartItem() { MatHang = mathang, SoLuong = 1 });
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }
        // Chuyển đến view xem giỏ hàng
        public IActionResult ViewCart()
        {
            GetInfo();
            return View(GetCartItems());
        }

        // Xóa một mặt hàng khỏi giỏ
        public IActionResult RemoveItem(int id)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.MatHang.MaMh == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }

        // Cập nhật số lượng một mặt hàng trong giỏ
        public IActionResult UpdateItem(int id, int quantity)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.MatHang.MaMh == id);
            if (item != null)
            {
                item.SoLuong = quantity;
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }

        // Chuyển đến view thanh toán
        public IActionResult CheckOut()
        {
            GetInfo();
            return View(GetCartItems());
        }

        // Lưu đơn
        public async Task<IActionResult> CreateBill(int id, string email, string hoten, string dienthoai, string diachi)
        {

            // Xử lý thông tin khách hàng (trường hợp khách mới)
            var kh = new Nguoidung();
            if (id != 0)
            {
                kh.MaNd = id;
            }
            else
            {
                kh.Email = email;
                kh.Ten = hoten;
                kh.DienThoai = dienthoai;
                _context.Add(kh);
                await _context.SaveChangesAsync();
            }

            var hd = new Hoadon();
            hd.Ngay = DateTime.Now;
            hd.MaNd = kh.MaNd;

            _context.Add(hd);
            await _context.SaveChangesAsync();


            // thêm chi tiết hóa đơn
            var cart = GetCartItems();

            int thanhtien = 0;
            int tongtien = 0;
            foreach (var i in cart)
            {
                var ct = new Cthoadon();
                ct.MaHd = hd.MaHd;
                ct.MaMh = i.MatHang.MaMh;
                thanhtien = i.MatHang.GiaBan * i.SoLuong;
                tongtien += thanhtien;
                ct.DonGia = i.MatHang.GiaBan;
                ct.SoLuong = (short)i.SoLuong;
                ct.ThanhTien = thanhtien;
                _context.Add(ct);
            }
            await _context.SaveChangesAsync();

            // cập nhật tổng tiền hóa đơn
            hd.TongTien = tongtien;
            _context.Update(hd);
            await _context.SaveChangesAsync();

            // xóa giỏ hàng
            ClearCart();

            GetInfo();
            return View(hd);
        }
        private bool MathangExists(int id)
        {
            return _context.Mathang.Any(e => e.MaMh == id);
        }
        public async Task<IActionResult> ProductsByName(string keyword)
        {
            GetInfo();
            var mathang = _context.Mathang.Where(p => p.Ten.Contains(keyword));
            return View(await mathang.ToListAsync());
        }
        public async Task<IActionResult> ProductsByManufactuner(int id)
        {
            GetInfo();
            var products = _context.Mathang.Include(m => m.MaDmNavigation).Where(m => m.MaMh == id).ToList();
            return View(products);

        }
    }
}
