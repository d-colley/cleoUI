using System.ComponentModel.DataAnnotations;

namespace CleoUI.Models
{
    public class Instrument
    {
        [Key]
        public int InstrumentID { get; set; }
        [Required]
        public string InstrumentName { get; set; }
        public string InstrumentCode { get; set; }
        public string InstrumentURL { get; set; }

    }
}
