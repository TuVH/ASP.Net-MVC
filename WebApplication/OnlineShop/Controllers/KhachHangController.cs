using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
namespace OnlineShop.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult Index()
        {
            //Cách 1 : Lấy dữ liệu là 1 danh sách Khách Hàng
            //var lstKH = from KH in db.KhachHangs select KH;

            //cách 2 :
            var lstKH = db.KhachHangs;
            return View(lstKH);
        }
        public ActionResult Index1()
        {
            var lstKH = from KH in db.KhachHangs select KH;

            return View(lstKH);
        }

        public ActionResult TruyVan1DoiTuong()
        {
            //Cách 1:Truy vấn 1 đối tượng = câu lệnh truy vấn
            var lstKH = from KH in db.KhachHangs where KH.MaKH ==1 select KH ;
            //Lấy đối tượng khách hàng dựa trên phương thức hỗ trợ
            KhachHang kh = db.KhachHangs.SingleOrDefault(n=>n.MaKH==1);
            return View(kh);
        }

        public ActionResult SortDuLieu()
        {
            //Phuong thức sắp xếp dữ liệu
            List<KhachHang> kh = db.KhachHangs.OrderByDescending(n => n.TenKH).ToList();
            return View(kh);
        }
        public ActionResult GroupDuLieu()
        {
            //Phương thức group dữ liệu
            List<ThanhVien> tv = db.ThanhViens.OrderBy(n => n.Hoten).ToList(); 
            return View(tv);
        }
    }
}