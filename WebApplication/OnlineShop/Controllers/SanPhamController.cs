using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
namespace OnlineShop.Controllers
{
    public class SanPhamController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: SanPham
        public ActionResult SanPham1()
        {

            return View();
        }
        public ActionResult SanPham2()
        {

            return View();
        }
        //Tạo patial view
        public ActionResult SanPhamPartial()
        {

            return PartialView();
        }
    }
}