using System.Security.Principal;
namespace _17._6._6.Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Создаем обычный аккаунт
            Account ordinaryAccount = new Account
            {
                Type = "Обычный",
                Balance = 900
            };
            
            // Рассчитываем процентную ставку для обычного аккаунта
            Calculator.CalculateInterest(ordinaryAccount);
            
            Console.WriteLine($"Процентная ставка для обычного аккаунта: {ordinaryAccount.Interest}");

            // Создаем зарплатный аккаунт
            Account salaryAccount = new Account
            {
                Type = "Зарплатный",
                Balance = 2000
            };

            // Рассчитываем процентную ставку для зарплатного аккаунта
            Calculator.CalculateInterest(salaryAccount);
            Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {salaryAccount.Interest}");
        }
    }
}