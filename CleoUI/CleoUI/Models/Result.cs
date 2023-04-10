using System.ComponentModel.DataAnnotations;

namespace CleoUI.Models
{
    public class Result
    {
        [Key]
        public int ResultID { get; set; }
        [Required]
        public int InstrumentID { get; set; }
        public string? WeeklyResult { get; set; }
        public string? MonthlyResult { get; set; }
        public int Price { get; set; }
        public DateTime When { get; set; }
    }
}
