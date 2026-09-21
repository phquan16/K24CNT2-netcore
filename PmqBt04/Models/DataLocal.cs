namespace PmqBt04.Models
{
    public class DataLocal
    {
        public static List<PmqBt> _pmqBt = new List<PmqBt>
        {
            new PmqBt
            {
                PmqId = Guid.NewGuid().ToString(),
                PmqName = "Laptop Dell XPS 13",
                PmqPrice = 25000000m,
                PmqSalePrice = 23500000m,
                PmqStatus = "Active",
                PmqCreateDate = new DateTime(2026, 1, 15),
                PmqImages = "1.jpg",
                PmqCategoryId = "CAT01",
                PmqDescription = "Laptop mỏng nhẹ, cấu hình cao dành cho doanh nhân."
            },
            new PmqBt
            {
                PmqId = Guid.NewGuid().ToString(),
                PmqName = "Bàn phím cơ Keychron K2",
                PmqPrice = 2200000m,
                PmqSalePrice = null,
                PmqStatus = "Active",
                PmqCreateDate = new DateTime(2026, 2, 01),
                PmqImages = "2.jpg",
                PmqCategoryId = "CAT02",
                PmqDescription = "Bàn phím cơ không dây layout 84 phím."
            },
            new PmqBt 
            {
                PmqId = Guid.NewGuid().ToString(),
                PmqName = "Chuột không dây Logitech MX Master 3S",
                PmqPrice = 2700000m,
                PmqSalePrice = 2490000m,
                PmqStatus = "Active",
                PmqCreateDate = new DateTime(2026, 2, 10),
                PmqImages = "3.jpg",
                PmqCategoryId = "CAT02",
                PmqDescription = "Chuột công thái học cao cấp, cuộn vô cực."
            },
            new PmqBt 
            {
                PmqId = Guid.NewGuid().ToString(),
                PmqName = "Màn hình Dell UltraSharp U2723QE",
                PmqPrice = 12500000m,
                PmqSalePrice = 11800000m,
                PmqStatus = "OutOfStock",
                PmqCreateDate = new DateTime(2026, 3, 05),
                PmqImages = "4.jpg",
                PmqCategoryId = "CAT03",
                PmqDescription = "Màn hình 27 inch 4K IPS Black màu sắc chuẩn xác."
            },
            new PmqBt 
            {
                PmqId = Guid.NewGuid().ToString(),
                PmqName = "Tai nghe Sony WH-1000XM5",
                PmqPrice = 8490000m,
                PmqSalePrice = null,
                PmqStatus = "Inactive",
                PmqCreateDate = new DateTime(2026, 3, 12),
                PmqImages = "5.jpg",
                PmqCategoryId = "CAT04",
                PmqDescription = "Tai nghe chụp tai chống ồn chủ động hàng đầu."
            }
        };
        public static List<PmqBt> GetPmqBt()
        {
            return _pmqBt;
        }

        public static PmqBt? GetPmqBtById(string id)
        {
            return _pmqBt.FirstOrDefault(x => x.PmqId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }
    }
}
