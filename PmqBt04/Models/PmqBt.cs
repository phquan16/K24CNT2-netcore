namespace PmqBt04.Models
{
    public class PmqBt
    {
        public string PmqId { get; set; }
        public string PmqName { get; set; }
        public decimal PmqPrice { get; set; }
        public decimal? PmqSalePrice { get; set; }
        public string PmqStatus { get; set; }
        public DateTime PmqCreateDate { get; set; }
        public string PmqImages { get; set; }
        public string PmqCategoryId { get; set; }
        public string PmqDescription { get; set; }
    }
}
