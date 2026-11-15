using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace SHOPHOAQUA.Controllers
{
    public class ShopController : Controller
    {
        public class SanPhamModel
        {
            public string TenDanhMuc { get; set; }
            public string TenSanPham { get; set; }
            public string Gia { get; set; }
            public string Anh { get; set; }
        }

        private static readonly List<SanPhamModel> _danhSach = new List<SanPhamModel>
        {
            // 1. Best-seller (Sản phẩm bán chạy)
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "Nho Xanh Sữa Hàn Quốc", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/c4/29/6a/c4296a717e9984cc1bf38343ab9b0774.jpg" },
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "Lê", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/24/e1/37/24e1378ca3226cda07480a7b7eb6c3ca.jpg" },
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "Táo hữu cơ Juliet", Gia = "Liên hệ", Anh = "https://images.unsplash.com/photo-1560806887-1e4cd0b6cbd6?w=400" },
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "HỘP QUÀ CHERRY CAO CẤP", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/64/6b/b2/646bb21507e5994ca0c53031cee1626b.jpg" },
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "Hộp quà Biểu tặng Envy 6", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/9e/e1/3d/9ee13d79c2f3bd6c37341c0485f9b429.jpg" },
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "Hộp quà Biểu tặng Envy 8", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/11/44/3e/11443ebf92bf1353c04c20573235e041.jpg" },
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "Hộp quà Kiwi cao cấp", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/63/4c/3e/634c3e26114bb71c822c997917a47297.jpg" },
            new SanPhamModel { TenDanhMuc = "Best-seller (Sản phẩm bán chạy)", TenSanPham = "Táo Dazzle Mỹ", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/f3/4d/5b/f34d5b84558090e3ecb7791c0df9c024.jpg" },

            // 2. Mâm quả thắp hương tài lộc
            new SanPhamModel { TenDanhMuc = "Mâm quả thắp hương tài lộc", TenSanPham = "Mâm quả tài lộc 1", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/bc/0a/8e/bc0a8e2168c107656e0cc3914ab982a7.jpg" },
            new SanPhamModel { TenDanhMuc = "Mâm quả thắp hương tài lộc", TenSanPham = "Mâm quả tài lộc 2", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/b7/0a/77/b70a77df2c757ccefe10a819c05d1636.jpg" },
            new SanPhamModel { TenDanhMuc = "Mâm quả thắp hương tài lộc", TenSanPham = "Mâm quả tài lộc 3", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/af/f4/0e/aff40e3af6709621f66d68d852889053.jpg" },
            new SanPhamModel { TenDanhMuc = "Mâm quả thắp hương tài lộc", TenSanPham = "Mâm quả tài lộc 4", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/50/e1/e6/50e1e63474bbc8b2f17f03329dd085f3.jpg" },

            // 3. Giỏ quà biếu tặng
            new SanPhamModel { TenDanhMuc = "Giỏ quà biếu tặng", TenSanPham = "Giỏ quà biếu tặng 8/3 số 1", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/a0/61/89/a06189f251fbcb9ad031fc78c2062743.jpg" },
            new SanPhamModel { TenDanhMuc = "Giỏ quà biếu tặng", TenSanPham = "Giỏ quà biếu tặng 2", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/b9/e4/74/b9e474f219550b9d8b815c4e7f4a65ff.jpg" },
            new SanPhamModel { TenDanhMuc = "Giỏ quà biếu tặng", TenSanPham = "Giỏ quà biếu tặng 3", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/e6/8f/6b/e68f6bb0ee62f1724498f70920a38efe.jpg" },
            new SanPhamModel { TenDanhMuc = "Giỏ quà biếu tặng", TenSanPham = "Giỏ quà biếu tặng 4", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/29/20/50/2920507be29f02f36fed470547353857.jpg" },

            // 4. Hoa quả bóc sẵn
            new SanPhamModel { TenDanhMuc = "Hoa quả bóc sẵn", TenSanPham = "Đĩa hoa quả bóc sẵn mẫu 1", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/8a/ba/4b/8aba4bf4c9fb8eedf6a105aee55b6f27.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả bóc sẵn", TenSanPham = "Đĩa hoa quả bóc sẵn mẫu 2", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/66/80/3e/66803e11ed32e050fc010695ae016899.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả bóc sẵn", TenSanPham = "Đĩa hoa quả bóc sẵn mẫu 3", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/0a/6f/64/0a6f64955f77fbc12338f956dcea7612.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả bóc sẵn", TenSanPham = "Đĩa hoa quả bóc sẵn mẫu 4", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/d1/d1/87/d1d187b8b47ccd6527f5860afee8f03c.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả bóc sẵn", TenSanPham = "Đĩa hoa quả bóc sẵn mẫu 5", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/ff/ec/61/ffec61835bf4190f7e31611a0d1e5bea.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả bóc sẵn", TenSanPham = "Đĩa hoa quả bóc sẵn mẫu 6", Gia = "Liên hệ", Anh = "https://i.pinimg.com/1200x/2e/5d/78/2e5d78762b1b32060c1558e54ddfd72a.jpg" },
            // 5. Hoa quả nhập khẩu
            new SanPhamModel { TenDanhMuc = "Hoa quả nhập khẩu", TenSanPham = "Cherry Canada", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/37/0e/8f/370e8fa972c7d1f96d2acdfe1ce15a89.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả nhập khẩu", TenSanPham = "Kiwi xanh Newzealand", Gia = "Liên hệ", Anh = "https://images.unsplash.com/photo-1585059895524-72359e06133a?w=400" },
            new SanPhamModel { TenDanhMuc = "Hoa quả nhập khẩu", TenSanPham = "Lê Xanh", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/cf/c1/60/cfc1607e8a81ed5abafd7d8c8d3d21b1.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả nhập khẩu", TenSanPham = "Táo ống Rockit", Gia = "Liên hệ", Anh = "https://images.unsplash.com/photo-1560806887-1e4cd0b6cbd6?w=400" },

            // 6. Hoa quả nội địa
            new SanPhamModel { TenDanhMuc = "Hoa quả nội địa", TenSanPham = "Xoài cát chu Đồng Tháp", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/d1/20/c8/d120c805d9959c414b74b35edad0a26c.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả nội địa", TenSanPham = "Bưởi da xanh Phú Quý", Gia = "Liên hệ", Anh = "https://images.unsplash.com/photo-1577234286642-fc512a5f8f11?w=400" },
            new SanPhamModel { TenDanhMuc = "Hoa quả nội địa", TenSanPham = "Dưa hấu không hạt", Gia = "Liên hệ", Anh = "https://i.pinimg.com/736x/ba/7d/81/ba7d8119771b1d9147e467b743c14f9d.jpg" },
            new SanPhamModel { TenDanhMuc = "Hoa quả nội địa", TenSanPham = "Cam xoàn", Gia = "Liên hệ", Anh = "https://images.unsplash.com/photo-1611080626919-7cf5a9dbab5b?w=400" },

            // 7. Thực phẩm
            new SanPhamModel { TenDanhMuc = "Thực phẩm", TenSanPham = "TINH CHẤT HỒNG SÂM LỘC NHUNG CAO CẤP", Gia = "Liên hệ", Anh = "https://tse4.mm.bing.net/th/id/OIP.r8761xLNS8Mla21d4RnHmgHaJ4?r=0&rs=1&pid=ImgDetMain&o=7&rm=3" },
            new SanPhamModel { TenDanhMuc = "Thực phẩm", TenSanPham = "Hạt điều rang muối 3H size King", Gia = "Liên hệ", Anh = "https://hoaquafuji.com/storage/app/media/3H-Hong-Lam/Hat-dieu-280g-1-min.png" },
            new SanPhamModel { TenDanhMuc = "Thực phẩm", TenSanPham = "Macca rang củi 3H size to 500g", Gia = "Liên hệ", Anh = "https://hoaquafuji.com/storage/app/media/3H-Hong-Lam/macca-min.png" },
            new SanPhamModel { TenDanhMuc = "Thực phẩm", TenSanPham = "Ô Mai Mơ Hồng Lam 5", Gia = "Liên hệ", Anh = "https://www.lottemart.vn/media/catalog/product/cache/0x0/8/9/8935210902061.jpg.webp" },

        };

        public IActionResult SanPham(string loai = "Best-seller (Sản phẩm bán chạy)")
        {
            var ketQua = _danhSach.Where(x => x.TenDanhMuc == loai).ToList();
            if (!ketQua.Any())
            {
                ketQua = _danhSach.Where(x => x.TenDanhMuc == "Best-seller (Sản phẩm bán chạy)").ToList();
            }

            ViewBag.TenDanhMuc = loai;
            return View(ketQua);
        }

        public IActionResult ThanhToan() => View();
        public IActionResult LienHe() => View();
    }
}