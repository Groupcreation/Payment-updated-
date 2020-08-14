using Payment.Models;


namespace Payment.Repository
{
    public interface IPayment
    {
        public dynamic ProcessPayment(CardDetails det);
    }
}
