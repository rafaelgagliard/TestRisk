using Risk.Interfaces;

namespace Risk.Models
{
    public struct Trade(double value, string clientSector, DateTime nextPaymentDate) : ITrade
    {
        public double Value { get; set; } = value;
        public string ClientSector { get; set; } = clientSector;
        public DateTime NextPaymentDate { get; set; } = nextPaymentDate;
    }
}
