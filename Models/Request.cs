namespace Risk.Models
{
    public class Request
    {
        public DateTime ReferenceDate { get; set; }
        public List<Trade> Trades { get; set; } = [];


    }
}
