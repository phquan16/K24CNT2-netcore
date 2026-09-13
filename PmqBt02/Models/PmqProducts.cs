namespace PmqBt02.Models
{
    public class PmqProducts
    {
        public int PmqId { get; set; }
        public string PmqName { get; set; }
        public string PmqImages { get; set; }
        public decimal PmqPrice { get; set; }
        public decimal? PmqPriceSale { get; set; }
        public int PmqCategoryId { get; set; }
        public string PmqDescription { get; set; }
        public bool PmqStatus { get; set; }
        public DateTime? PmqCreatedAt { get; set; }
    }
}
