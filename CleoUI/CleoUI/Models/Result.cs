namespace CleoUI.Models
{
    public class Result
    {
        public  int InstrumentID { get; set; }
        public string WeeklyResult { get; set; }
        public string MonthlyResult { get; set; }
        public int Price { get; set; }
        public DateTime When { get; set; }
    }
}
