namespace _199._Exercício_de_fixação.Services
{
    internal interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
