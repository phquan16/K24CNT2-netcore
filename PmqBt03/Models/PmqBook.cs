using Microsoft.AspNetCore.Mvc.Rendering;

namespace PmqBt03.Models
{
    public class PmqBook
    {
        public int PmqId { get; set; }
        public string PmqTitle { get; set; }
        public int PmqAuthorID { get; set; }
        public int PmqGenreId { get; set; }
        public string PmqImages { get; set; }
        public float PmqPrice { get; set; }
        public int PmqTotalPage { get; set; }
        public string PmqSumary { get; set; }

        public List<PmqBook> GetBookList()
        {
            List<PmqBook> books = new List<PmqBook>()
            {
                new()
                {
                    PmqId = 1,
                    PmqTitle = "Dế Mèn Phiêu Lưu Ký",
                    PmqAuthorID = 1,
                    PmqGenreId = 1,
                    PmqImages = "/images/1.jpg",
                    PmqPrice = 65000f,
                    PmqTotalPage = 188,
                    PmqSumary = "Tác phẩm văn học thiếu nhi kinh điển kể về cuộc phiêu lưu tự do và bài học trưởng thành của Dế Mèn."
                },
                new()
                {
                    PmqId = 2,
                    PmqTitle = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
                    PmqAuthorID = 2,
                    PmqGenreId = 2,
                    PmqImages = "/images/2.jpg",
                    PmqPrice = 110000f,
                    PmqTotalPage = 378,
                    PmqSumary = "Câu chuyện tuổi thơ êm đềm nhưng đầy xao xuyến ở một làng quê Việt Nam nghèo khó."
                },
                new()
                {
                    PmqId = 3,
                    PmqTitle = "Đắc Nhân Tâm",
                    PmqAuthorID = 3,
                    PmqGenreId = 3,
                    PmqImages = "/images/3.jpg",
                    PmqPrice = 98000f,
                    PmqTotalPage = 320,
                    PmqSumary = "Cuốn sách nghệ thuật ứng xử và thu phục lòng người bán chạy nhất mọi thời đại."
                },
                new()
                {
                    PmqId = 4,
                    PmqTitle = "Nhà Giả Kim",
                    PmqAuthorID = 4,
                    PmqGenreId = 4,
                    PmqImages = "/images/4.jpg",
                    PmqPrice = 79000f,
                    PmqTotalPage = 228,
                    PmqSumary = "Hành trình theo đuổi vận mệnh và ước mơ của chàng chăn cừu Santiago."
                },
                new()
                {
                    PmqId = 5,
                    PmqTitle = "Số Đỏ",
                    PmqAuthorID = 5,
                    PmqGenreId = 5,
                    PmqImages = "/images/5.jpg",
                    PmqPrice = 72000f,
                    PmqTotalPage = 270,
                    PmqSumary = "Tiểu thuyết trào phúng đả kích sâu sắc xã hội Âu hóa nửa mùa thời kỳ Pháp thuộc."
                },
                new()
                {
                    PmqId = 6,
                    PmqTitle = "Cây Cam Ngọt Của Tôi",
                    PmqAuthorID = 6,
                    PmqGenreId = 2,
                    PmqImages = "/images/6.jpg",
                    PmqPrice = 108000f,
                    PmqTotalPage = 244,
                    PmqSumary = "Câu chuyện rung động lòng người về cậu bé Zezé và tình yêu thương trong nghèo khó."
                },
                new()
                {
                    PmqId = 7,
                    PmqTitle = "Tuổi Trẻ Đáng Giá Bao Nhiêu?",
                    PmqAuthorID = 7,
                    PmqGenreId = 3,
                    PmqImages = "/images/7.jpg",
                    PmqPrice = 85000f,
                    PmqTotalPage = 292,
                    PmqSumary = "Cuốn sách truyền cảm hứng sống, học tập và trải nghiệm cho người trẻ."
                },
                new()
                {
                    PmqId = 8,
                    PmqTitle = "Tắt Đèn",
                    PmqAuthorID = 8,
                    PmqGenreId = 5,
                    PmqImages = "/images/8.jpg",
                    PmqPrice = 55000f,
                    PmqTotalPage = 216,
                    PmqSumary = "Tác phẩm hiện thực chấn động về số phận bế tắc của nông dân Việt Nam trước năm 1945."
                },
                new()
                {
                    PmqId = 9,
                    PmqTitle = "Rừng Na Uy",
                    PmqAuthorID = 9,
                    PmqGenreId = 4,
                    PmqImages = "/images/9.jpg",
                    PmqPrice = 135000f,
                    PmqTotalPage = 550,
                    PmqSumary = "Tiểu thuyết về ký ức, tình yêu và những mất mát tuổi trẻ tại Nhật Bản thập niên 1960."
                },
                new()
                {
                    PmqId = 10,
                    PmqTitle = "Mắt Biếc",
                    PmqAuthorID = 2,
                    PmqGenreId = 2,
                    PmqImages = "/images/10.jpg",
                    PmqPrice = 115000f,
                    PmqTotalPage = 300,
                    PmqSumary = "Chuyện tình đơn phương si tình và đượm buồn của Ngạn dành cho Hà Lan."
                }
            };
            return books;
        }
        public PmqBook? GetPmqBookById(int id)
        {
            return GetBookList().FirstOrDefault(b => b.PmqId == id);
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "1", Text = "Tô Hoài" },
            new SelectListItem { Value = "2", Text = "Nguyễn Nhật Ánh" },
            new SelectListItem { Value = "3", Text = "Dale Carnegie" },
            new SelectListItem { Value = "4", Text = "Paulo Coelho" },
            new SelectListItem { Value = "5", Text = "Vũ Trọng Phụng" },
            new SelectListItem { Value = "6", Text = "José Mauro de Vasconcelos" },
            new SelectListItem { Value = "7", Text = "Rosie Nguyễn" },
            new SelectListItem { Value = "8", Text = "Ngô Tất Tố" },
            new SelectListItem { Value = "9", Text = "Haruki Murakami" }
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "1", Text = "Văn học thiếu nhi" },
            new SelectListItem { Value = "2", Text = "Truyện dài / Tâm lý tuổi học trò" },
            new SelectListItem { Value = "3", Text = "Kỹ năng sống / Đào tạo kỹ năng ứng xử" },
            new SelectListItem { Value = "4", Text = "Tiểu thuyết triết lý nước ngoài" },
            new SelectListItem { Value = "5", Text = "Tiểu thuyết trào phúng hiện thực" },
            new SelectListItem { Value = "6", Text = "Truyện dài / Tâm lý tình cảm gia đình" },
            new SelectListItem { Value = "7", Text = "Kỹ năng sống / Truyền cảm hứng cho giới trẻ" },
            new SelectListItem { Value = "8", Text = "Văn học hiện thực phê phán" },
            new SelectListItem { Value = "9", Text = "Tiểu thuyết lãng mạn - tâm lý nước ngoài" },
            new SelectListItem { Value = "10", Text = "Truyện dài / Tình cảm học đường" }
        };
    }
}
